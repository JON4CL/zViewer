using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace zViewer
{
    class Icomp
    {
        private string icompPath;
        private string tempPath;
        private string openedFile;
        //
        public Icomp()
        {
            // BASE PATH FOR ICOMP
            icompPath = '"' + Application.StartupPath + @"\bin\icomp.exe" + '"';
            tempPath = Path.GetTempPath() + "z" + CommonFunctions.getTimeStamp() + "\\";
        }
        //
        public void createTempDirectory()
        {
            Directory.CreateDirectory(tempPath);
        }
        //
        public void deleteTempDirectory()
        {
            if (Directory.Exists(tempPath))
            {
                Directory.Delete(tempPath, true);
            }
        }
        //
        public string OpenedFileName
        {
            get { return this.openedFile; }
        }
        //
        public string TempPath
        {
            get { return this.tempPath; }
        }
        //
        private string[] getRunBuffer(string arguments)
        {
            string[] buffers = new string[2];
            buffers[0] = "";
            buffers[1] = "";
            // WRITE LOG FILE
            string writeLogFile = IniManager.IniGet(IniManager.iniFilePath, "DEFAULT", "writeLogFile", "NO");
            if (writeLogFile.ToUpper() == "YES")
            {
                string defaultLogFileName = Application.StartupPath + @"\log.txt";
                string logFileName = IniManager.IniGet(IniManager.iniFilePath, "DEFAULT", "fileName", defaultLogFileName);
                CommonFunctions.saveLogFile(logFileName, icompPath + "|"+ arguments);
            }
            //
            ProcessStartInfo processStartInfo = new ProcessStartInfo(icompPath, arguments);
            processStartInfo.UseShellExecute = false;
            processStartInfo.ErrorDialog = false;
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.RedirectStandardError = true;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            //
            Process process = new Process();
            process.StartInfo = processStartInfo;
            //
            bool processStarted;
            StreamWriter inputWriter;
            StreamReader outputReader;
            StreamReader errorReader;
            //
            try
            {
                processStarted = process.Start();
                inputWriter = process.StandardInput;
                outputReader = process.StandardOutput;
                errorReader = process.StandardError;

                //Display the result
                buffers[0] = outputReader.ReadToEnd();
                buffers[1] = errorReader.ReadToEnd();

                process.WaitForExit();
            }
            catch (Exception ex)
            {
                buffers[1] = "MESSAGE: " + ex.Message.ToString() + Environment.NewLine + 
                            "ICOMP PATH: " + icompPath + Environment.NewLine + 
                            "ARGUMENTS: " + arguments;
            }
            //
            return buffers;
        }
        //
        public List<ZFile> listFiles(string filePath)
        {
            openedFile = filePath;
            string baseCommand = "\"[FILE]\" -l";
            baseCommand = baseCommand.Replace("[FILE]", openedFile);
            List<ZFile> internalList = new List<ZFile>();
            //
            string[] buffers = getRunBuffer(baseCommand);
            //
            if (buffers[1].Length > 0)
            {
                MessageBox.Show("ERROR:\n" + buffers[1]);
                return internalList;
            }
            //
            string[] lines = Regex.Split(buffers[0], "\r\n");
            for (int i = 7; i < lines.Length - 5; i++)
            {
                internalList.Add(new ZFile(lines[i]));
            }
            //
            return internalList;
        }
        //
        public bool extractFile(string file, string destFolder)
        {
            // EXTRACT THE FILE IN DESTINATION FOLDER
            string internalFilePath = "";
            if (file.LastIndexOf("\\") > 0)
            {
                internalFilePath = file.Substring(0, file.LastIndexOf("\\")).ToString();
            }
            string baseCommand = "\"[ZFILE]\" \"[FILE_TO_EXTRACT]\" \"[DEST_PATH]\" -i -d";
            baseCommand = baseCommand.Replace("[ZFILE]", openedFile);
            baseCommand = baseCommand.Replace("[FILE_TO_EXTRACT]", destFolder + "\\" + file);
            baseCommand = baseCommand.Replace("[DEST_PATH]", internalFilePath);
            string[] buffers = getRunBuffer(baseCommand);
            if (buffers[1].Length > 0)
            {
                MessageBox.Show("ERROR:\n" + buffers[1]);
                return false;
            }
            return true;
        }
        //
        public bool openFile()
        {
            /*
            string arguments = openedFile + " " + '"' + destFolder + "\\" + file + '"' + " " + '"' + internalFilePath + '"' + " -i -d";
            string[] buffers = getRunBuffer(arguments);
            if (buffers[1].Length > 0)
            {
                MessageBox.Show("ERROR:\n" + buffers[1]);
                return false;
            }
            ^*/
            // OPEN FILE WITH WINDOWS SHELL
            //System.Diagnostics.Process.Start("http://www.microsoft.com");
            return true;
        }
        //
        public bool addFile(string file)
        {
            // EXTRACT TEMP FILE
            // "[FILE_TO_ADD]" "[ZFILE]" "[DEST_PATH]" -o -h
            string baseCommand = "\"[FILE_TO_ADD]\" \"[ZFILE]\" \"[DEST_PATH]\" -o -h";
            baseCommand = baseCommand.Replace("[FILE_TO_ADD]", file);
            baseCommand = baseCommand.Replace("[ZFILE]", openedFile);
            baseCommand = baseCommand.Replace("[DEST_PATH]", "");
            string[] buffers = getRunBuffer(baseCommand);
            if (buffers[1].Length > 0)
            {
                MessageBox.Show("ERROR:\n" + buffers[1]);
                return false;
            }
            return true;
        }
        //
        public bool addDirectory(string path)
        {
            // EXTRACT TEMP FILE
            // "[PATH]\\*.*" "[ZFILE]" "[DIRNAME]" -i -o -h
            string dirName = "";
            if (path.LastIndexOf("\\") > 0)
            {
                string[] splitPath = path.Split(char.Parse("\\"));
                dirName = splitPath[splitPath.Length-1];
            }

            string baseCommand = "\"[PATH]\\*.*\" \"[ZFILE]\" \"[DIRNAME]\" -i -o -h";
            baseCommand = baseCommand.Replace("[PATH]", path);
            baseCommand = baseCommand.Replace("[ZFILE]", openedFile);
            baseCommand = baseCommand.Replace("[DIRNAME]", dirName);
            string[] buffers = getRunBuffer(baseCommand);
            if (buffers[1].Length > 0)
            {
                MessageBox.Show("ERROR:\n" + buffers[1]);
                return false;
            }

            return true;
        }
        //
        public bool delFile(string file)
        {
            // EXTRACT TEMP FILE
            // \"[FILE_TO_TEMOVE]\" \"[ZFILE]\" -r
            string baseCommand = "\"[FILE_TO_TEMOVE]\" \"[ZFILE]\" -r";
            baseCommand = baseCommand.Replace("[FILE_TO_TEMOVE]", file);
            baseCommand = baseCommand.Replace("[ZFILE]", openedFile);
            string[] buffers = getRunBuffer(baseCommand);
            if (buffers[1].Length > 0)
            {
                MessageBox.Show("ERROR:\n" + buffers[1]);
                return false;
            }
            return true;
        }
        //
    }
}
