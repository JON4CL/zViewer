using System.Diagnostics;
using System.Windows.Forms;
using System;
using System.IO;
using System.Collections.Generic;

namespace zViewer
{
    public partial class frmMain : Form
    {
        private long totalFileSize = 0;
        private long totalFileSizePacked = 0;
        private long totalNumFiles = 0;
        private long selectedFileSize = 0;

        private Icomp icomp = new Icomp();
        private List<ZFile> files = new List<ZFile>();

        #region " FORM FUNCTIONS"
        //
        public frmMain()
        {
            InitializeComponent();
            progressStatus_SetStatus("", "", "", 0, 0);
            progressStatus_Hide();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // GETTING PARAMETERS FROM COMMAND LINE
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1 && args[1].Substring(args[1].Length - 1, 1).ToUpper() == "Z")
            {
                files = icomp.listFiles(args[1]);
            }
            updateGrid();
            icomp.createTempDirectory();
        }
        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            //-------------------------------------
            // CAN BE:
            //        OPEN A Z FILE 
            //        ADD FILES TO THE OPENED FILE
            //        CREATE A NEW Z FILE
            //-------------------------------------
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                // CHECK FOR Z FILES
                foreach (string file in files)
                {
                    string[] fileData = file.Split(char.Parse("."));
                    string fileExtension = fileData[fileData.Length - 1].ToUpper();
                    if (file.Substring(file.Length - 1, 1).ToUpper() == "Z")
                    {
                        if(MessageBox.Show("The file '" + getFileName(file) + "' has been found, this file is a Z file.\nDo you want open the file?", "File Confusion.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.files = icomp.listFiles(file);
                            refreshListFiles();
                            updateGrid();
                            return;
                        }
                    }
                }
                //
                if (dgvFiles.RowCount > 0)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        progressStatus_SetStatus(icomp.OpenedFileName, "Adding Files", files[i], i + 1, files.Length);
                        Application.DoEvents();
                        if (icomp.addFile(files[i]) == false)
                        {
                            return;
                        }
                    }

                    refreshListFiles();
                    updateGrid();
                    MessageBox.Show("Process Finished Successfully.", "Process Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //
        }
        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Are you sure to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                e.Cancel = false;
                icomp.deleteTempDirectory();
            }
            else
            {
                e.Cancel = true;
            }
        }
        //
        #endregion

        #region " PROGRESS STATUS FUNCTIONS"
        //
        private void progressStatus_Clean()
        {
            progressStatus_SetStatus("", "", "", 0, 0);
        }
        private void progressStatus_Hide()
        {
            progressStatus_SetStatus("", "", "", 0, 0);
            spcDataProcess.Panel2Collapsed = true;
        }
        private void progressStatus_Show()
        {
            spcDataProcess.Panel2Collapsed = false;
        }
        private void progressStatus_SetStatus(string zFile, string action, string actualFile, int actualValue, int maxValue)
        {
            this.txtArchive.Text = getFileName(zFile);
            this.txtAction.Text = action;
            this.txtFileInProgress.Text = getFileName(actualFile);
            this.txtProgressOverview.Text = actualValue.ToString() + "/" + maxValue.ToString();
            this.pgbTotal.Maximum = maxValue;
            this.pgbTotal.Value = actualValue;
            progressStatus_Show();
        }
        private void btnHiddeStatus_Click(object sender, EventArgs e)
        {
            progressStatus_Hide();
        }
        //
        #endregion

        #region " GENERAL FUNCTIONS"
        //
        private string getFileName(string fullFileName)
        {
            string[] splited = fullFileName.Split(char.Parse("\\"));
            return splited[splited.Length - 1];

        }
        private void updateGrid()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = this.files;

            dgvFiles.DataSource = bs;
            updateStatusBar();
        }
        private void refreshListFiles()
        {
            files = icomp.listFiles(icomp.OpenedFileName);
        }
        private void updateStatusBar()
        {
            totalFileSize = 0;
            totalFileSizePacked = 0;
            totalNumFiles = dgvFiles.RowCount;
            if (totalNumFiles > 0)
            {
                for (int i = 0; i < totalNumFiles; i++)
                {
                    totalFileSize = totalFileSize + long.Parse(dgvFiles.Rows[i].Cells[3].Value.ToString());
                    totalFileSizePacked = totalFileSizePacked + long.Parse(dgvFiles.Rows[i].Cells[4].Value.ToString());
                }
            }
            string fileTotalStatus = "Total [TOTAL_FILE_SIZE] bytes in [TOTAL_FILE_NUM] files";
            fileTotalStatus = fileTotalStatus.Replace("[TOTAL_FILE_SIZE]", totalFileSize.ToString());
            fileTotalStatus = fileTotalStatus.Replace("[TOTAL_FILE_NUM]", totalNumFiles.ToString());
            stsStatusBar.Items["tsslTotalFiles"].Text = fileTotalStatus;

            selectedFileSize = 0;
            DataGridViewSelectedRowCollection rowsSelection = dgvFiles.SelectedRows;
            if (rowsSelection.Count > 0)
            {
                foreach (DataGridViewRow row in rowsSelection)
                {
                    selectedFileSize = selectedFileSize + long.Parse(row.Cells[3].Value.ToString());
                }

                string fileSelectedStatus = "Selected [SELECTED_FILE_SIZE] bytes in [SELECTED_FILE_NUM] files";
                fileSelectedStatus = fileSelectedStatus.Replace("[SELECTED_FILE_SIZE]", selectedFileSize.ToString());
                fileSelectedStatus = fileSelectedStatus.Replace("[SELECTED_FILE_NUM]", rowsSelection.Count.ToString());
                stsStatusBar.Items["tsslFilesSelected"].Text = fileSelectedStatus;
            }
            else
            {
                stsStatusBar.Items["tsslFilesSelected"].Text = "";
            }
        }
        private void openSelectedFile()
        {
            // EXTRACT FILE IN TEMP DIRECTORY
            DataGridViewSelectedRowCollection rowsSelection = dgvFiles.SelectedRows;
            if (rowsSelection.Count > 0)
            {
                icomp.extractFile(rowsSelection[0].Cells[5].Value.ToString(), icomp.TempPath);
                string tempFile = icomp.TempPath + rowsSelection[0].Cells[5].Value.ToString();
                try
                {
                    // OPEN THE FILE WITH THE ASSOCIATED PROGRAM
                    System.Diagnostics.Process.Start(tempFile);
                }
                catch (System.ComponentModel.Win32Exception ex)
                {
                    // IF AN EXCEPTION IS FIRED OPEN THE FILE WITH THE DEFAULT EDITOR
                    string defaultEditor = IniManager.IniGet(IniManager.iniFilePath, "DEFAULT", "defaultEditor", "");
                    if (defaultEditor != "")
                    {
                        CommonFunctions.runApp(defaultEditor, tempFile);
                    }
                }
            }
        }
        //
        #endregion

        #region " BUTTON MENU FUNCTIONS"
        //
        private void tsbOpen_Click(object sender, EventArgs e)
        {
            // SELECT AND ADD FILES AND FOLDERS TO THE FILE
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "Select a file to open.";
            ofd.Filter = "Z Files *.z|*.z";
            ofd.InitialDirectory = @"C:\";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            //
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] file = ofd.FileNames;
                files = icomp.listFiles(file[0]);

                refreshListFiles();
                updateGrid();
            }
            return;
        }
        private void tsmiAddFiles_Click(object sender, EventArgs e)
        {
            // SELECT AND ADD FILES AND FOLDERS TO THE FILE
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Select the files to add.";
            ofd.Filter = "All Files *.*|*.*";
            ofd.InitialDirectory = @"C:\";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            //
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] files = ofd.FileNames;
                for(int i=0; i < files.Length; i++)
                {
                    progressStatus_SetStatus(icomp.OpenedFileName, "Adding Files", files[i], i+1, files.Length);
                    Application.DoEvents();
                    if (icomp.addFile(files[i]) == false)
                    {
                        return;
                    }
                }

                refreshListFiles();
                updateGrid();
                MessageBox.Show("Process Finished Successfully.", "Process Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
        private void tsmiAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdOpen = new FolderBrowserDialog();
            fbdOpen.Description = "Select a folder to add.";
            fbdOpen.RootFolder = Environment.SpecialFolder.MyComputer;
            fbdOpen.ShowNewFolderButton = true;

            if (fbdOpen.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            /*
             * COULD BE BETTER PROCESS FILE  BY FILE IN THE SELECTED FOLDER
             * INSTEAD SEND THE FOLDER TO THE ICOMP PROCESS
             */

            progressStatus_SetStatus(icomp.OpenedFileName, "Adding Folder", fbdOpen.SelectedPath, 1, 1);
            Application.DoEvents();
            if (icomp.addDirectory(fbdOpen.SelectedPath) == false)
            {
                return;
            }

            refreshListFiles();
            updateGrid();
            MessageBox.Show("Process Finished Successfully.", "Process Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return;
        }
        private void tsbExtractTo_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowsSelection = dgvFiles.SelectedRows;
            if (rowsSelection.Count > 0)
            {
                FolderBrowserDialog fbdOpen = new FolderBrowserDialog();
                fbdOpen.Description = "Select destination folder.";
                fbdOpen.RootFolder = Environment.SpecialFolder.MyComputer;
                fbdOpen.ShowNewFolderButton = true;

                if (fbdOpen.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                for(int i=0; i<rowsSelection.Count; i++)
                {
                    progressStatus_SetStatus(icomp.OpenedFileName, "Extracting Files", rowsSelection[i].Cells[5].Value.ToString(), i+1, rowsSelection.Count);
                    Application.DoEvents();
                    if (icomp.extractFile(rowsSelection[i].Cells[5].Value.ToString(), fbdOpen.SelectedPath) == false)
                    {
                        return;
                    }
                }
                MessageBox.Show("Process Finished Successfully.", "Process Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select at least one file to extract.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return;
        }
        private void tsbView_Click(object sender, EventArgs e)
        {
            // IS THE SAME AS OPEN OR GRID_2CLICK
            openSelectedFile();
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            // EXECUTE COMAND TO DELETE FILE
            DataGridViewSelectedRowCollection rowsSelection = dgvFiles.SelectedRows;
            if (rowsSelection.Count > 0)
            {
                if (MessageBox.Show("Are you sure to delete this files?.", "Delete files.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                for(int i=0; i<rowsSelection.Count; i++)
                {
                    progressStatus_SetStatus(icomp.OpenedFileName, "Deleting Files", rowsSelection[i].Cells[5].Value.ToString(), i+1, rowsSelection.Count);
                    Application.DoEvents();
                    if (icomp.delFile(rowsSelection[i].Cells[5].Value.ToString()) == false)
                    {
                        return;
                    }
                }
                refreshListFiles();
                updateGrid();
                MessageBox.Show("Process Finished Successfully.", "Process Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select at least one file to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return;
        }
        private void tsbInfo_Click(object sender, EventArgs e)
        {
            // SHOW SUMMARY INFO
            if (icomp.OpenedFileName != null)
            {
                FrmInfo fi = new FrmInfo();
                fi.setFileData(icomp.OpenedFileName, totalFileSize, totalFileSizePacked, totalNumFiles);
                fi.ShowDialog();
            }
        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //
        #endregion

        #region " GRID FUNCTIONS"
        //
        private void dgvFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openSelectedFile();
        }
        private void dgvFiles_SelectionChanged(object sender, EventArgs e)
        {
            updateStatusBar();
        }
        //
        #endregion
    }
}