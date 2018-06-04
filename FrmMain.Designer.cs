namespace zViewer
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.tsslFilesSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotalFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.tsbIconBar = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiAddFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbExtractTo = new System.Windows.Forms.ToolStripButton();
            this.tsbView = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbInfo = new System.Windows.Forms.ToolStripButton();
            this.tssSeparadorIcon = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.spcDataProcess = new System.Windows.Forms.SplitContainer();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOriSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbMain = new System.Windows.Forms.GroupBox();
            this.btnHiddeStatus = new System.Windows.Forms.Button();
            this.grbProgres = new System.Windows.Forms.GroupBox();
            this.txtProgressOverview = new System.Windows.Forms.TextBox();
            this.txtFileInProgress = new System.Windows.Forms.TextBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.txtArchive = new System.Windows.Forms.TextBox();
            this.lblProgresOverview = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblFileInProgress = new System.Windows.Forms.Label();
            this.lblArchive = new System.Windows.Forms.Label();
            this.pgbTotal = new System.Windows.Forms.ProgressBar();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.stsStatusBar.SuspendLayout();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.tsbIconBar.SuspendLayout();
            this.spcDataProcess.Panel1.SuspendLayout();
            this.spcDataProcess.Panel2.SuspendLayout();
            this.spcDataProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.grbMain.SuspendLayout();
            this.grbProgres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFilesSelected,
            this.tsslTotalFiles});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 431);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(632, 22);
            this.stsStatusBar.TabIndex = 0;
            // 
            // tsslFilesSelected
            // 
            this.tsslFilesSelected.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslFilesSelected.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslFilesSelected.Name = "tsslFilesSelected";
            this.tsslFilesSelected.Size = new System.Drawing.Size(308, 17);
            this.tsslFilesSelected.Spring = true;
            this.tsslFilesSelected.Text = "Selected [TAMAÑO] bytes in [NUMFILES] files";
            this.tsslFilesSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslTotalFiles
            // 
            this.tsslTotalFiles.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslTotalFiles.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslTotalFiles.Name = "tsslTotalFiles";
            this.tsslTotalFiles.Size = new System.Drawing.Size(308, 17);
            this.tsslTotalFiles.Spring = true;
            this.tsslTotalFiles.Text = "Total [TOTALTAMAÑOS] bytes in [NUMFILES] files ";
            this.tsslTotalFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            this.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.tsbIconBar);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.spcDataProcess);
            this.spcMain.Size = new System.Drawing.Size(632, 431);
            this.spcMain.SplitterDistance = 87;
            this.spcMain.TabIndex = 6;
            this.spcMain.TabStop = false;
            // 
            // tsbIconBar
            // 
            this.tsbIconBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbAdd,
            this.tsbExtractTo,
            this.tsbView,
            this.tsbDelete,
            this.tsbInfo,
            this.tssSeparadorIcon,
            this.tsbExit});
            this.tsbIconBar.Location = new System.Drawing.Point(0, 0);
            this.tsbIconBar.Name = "tsbIconBar";
            this.tsbIconBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsbIconBar.Size = new System.Drawing.Size(632, 87);
            this.tsbIconBar.TabIndex = 6;
            // 
            // tsbOpen
            // 
            this.tsbOpen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbOpen.Image = global::zViewer.Properties.Resources.Find;
            this.tsbOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(68, 84);
            this.tsbOpen.Text = "&Open";
            this.tsbOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddFiles,
            this.toolStripSeparator1,
            this.tsmiAddFolder});
            this.tsbAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAdd.Image = global::zViewer.Properties.Resources.Add;
            this.tsbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbAdd.Size = new System.Drawing.Size(77, 84);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiAddFiles
            // 
            this.tsmiAddFiles.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddFiles.Image")));
            this.tsmiAddFiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddFiles.Name = "tsmiAddFiles";
            this.tsmiAddFiles.Size = new System.Drawing.Size(142, 36);
            this.tsmiAddFiles.Text = "&Files";
            this.tsmiAddFiles.Click += new System.EventHandler(this.tsmiAddFiles_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // tsmiAddFolder
            // 
            this.tsmiAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddFolder.Image")));
            this.tsmiAddFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddFolder.Name = "tsmiAddFolder";
            this.tsmiAddFolder.Size = new System.Drawing.Size(142, 36);
            this.tsmiAddFolder.Text = "F&older";
            this.tsmiAddFolder.Click += new System.EventHandler(this.tsmiAddFolder_Click);
            // 
            // tsbExtractTo
            // 
            this.tsbExtractTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbExtractTo.Image = global::zViewer.Properties.Resources.ExtractTo;
            this.tsbExtractTo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExtractTo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExtractTo.Name = "tsbExtractTo";
            this.tsbExtractTo.Size = new System.Drawing.Size(78, 84);
            this.tsbExtractTo.Text = "Extract &To";
            this.tsbExtractTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExtractTo.Click += new System.EventHandler(this.tsbExtractTo_Click);
            // 
            // tsbView
            // 
            this.tsbView.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbView.Image = global::zViewer.Properties.Resources.View;
            this.tsbView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbView.Name = "tsbView";
            this.tsbView.Size = new System.Drawing.Size(68, 84);
            this.tsbView.Text = "&View";
            this.tsbView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbView.Click += new System.EventHandler(this.tsbView_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDelete.Image = global::zViewer.Properties.Resources.Delete;
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(68, 84);
            this.tsbDelete.Text = "&Delete";
            this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbInfo
            // 
            this.tsbInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbInfo.Image = global::zViewer.Properties.Resources.Info;
            this.tsbInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfo.Name = "tsbInfo";
            this.tsbInfo.Size = new System.Drawing.Size(68, 84);
            this.tsbInfo.Text = "&Info";
            this.tsbInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInfo.Click += new System.EventHandler(this.tsbInfo_Click);
            // 
            // tssSeparadorIcon
            // 
            this.tssSeparadorIcon.Name = "tssSeparadorIcon";
            this.tssSeparadorIcon.Size = new System.Drawing.Size(6, 87);
            // 
            // tsbExit
            // 
            this.tsbExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbExit.Image = global::zViewer.Properties.Resources.Exit;
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(68, 84);
            this.tsbExit.Text = "&Exit";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // spcDataProcess
            // 
            this.spcDataProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcDataProcess.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcDataProcess.IsSplitterFixed = true;
            this.spcDataProcess.Location = new System.Drawing.Point(0, 0);
            this.spcDataProcess.Margin = new System.Windows.Forms.Padding(0);
            this.spcDataProcess.Name = "spcDataProcess";
            this.spcDataProcess.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcDataProcess.Panel1
            // 
            this.spcDataProcess.Panel1.Controls.Add(this.dgvFiles);
            this.spcDataProcess.Panel1MinSize = 0;
            // 
            // spcDataProcess.Panel2
            // 
            this.spcDataProcess.Panel2.Controls.Add(this.grbMain);
            this.spcDataProcess.Panel2MinSize = 0;
            this.spcDataProcess.Size = new System.Drawing.Size(632, 340);
            this.spcDataProcess.SplitterDistance = 203;
            this.spcDataProcess.SplitterWidth = 1;
            this.spcDataProcess.TabIndex = 0;
            this.spcDataProcess.TabStop = false;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AllowUserToResizeRows = false;
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFiles.BackgroundColor = System.Drawing.Color.White;
            this.dgvFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colTime,
            this.colAtributes,
            this.colOriSize,
            this.colCompSize,
            this.colFileName});
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiles.Location = new System.Drawing.Point(0, 0);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowHeadersVisible = false;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(632, 203);
            this.dgvFiles.TabIndex = 6;
            this.dgvFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFiles_MouseDoubleClick);
            this.dgvFiles.SelectionChanged += new System.EventHandler(this.dgvFiles_SelectionChanged);
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDate.Width = 54;
            // 
            // colTime
            // 
            this.colTime.DataPropertyName = "Time";
            this.colTime.HeaderText = "Time";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTime.Width = 53;
            // 
            // colAtributes
            // 
            this.colAtributes.DataPropertyName = "Atributes";
            this.colAtributes.HeaderText = "Atributes";
            this.colAtributes.Name = "colAtributes";
            this.colAtributes.ReadOnly = true;
            this.colAtributes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAtributes.Width = 75;
            // 
            // colOriSize
            // 
            this.colOriSize.DataPropertyName = "OriSize";
            this.colOriSize.HeaderText = "Original Size";
            this.colOriSize.Name = "colOriSize";
            this.colOriSize.ReadOnly = true;
            this.colOriSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOriSize.Width = 89;
            // 
            // colCompSize
            // 
            this.colCompSize.DataPropertyName = "CompSize";
            this.colCompSize.HeaderText = "Compressed Size";
            this.colCompSize.Name = "colCompSize";
            this.colCompSize.ReadOnly = true;
            this.colCompSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCompSize.Width = 112;
            // 
            // colFileName
            // 
            this.colFileName.DataPropertyName = "FileName";
            this.colFileName.HeaderText = "File Name";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFileName.Width = 77;
            // 
            // grbMain
            // 
            this.grbMain.AutoSize = true;
            this.grbMain.Controls.Add(this.btnHiddeStatus);
            this.grbMain.Controls.Add(this.grbProgres);
            this.grbMain.Controls.Add(this.pcbLogo);
            this.grbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMain.Location = new System.Drawing.Point(0, 0);
            this.grbMain.Margin = new System.Windows.Forms.Padding(0);
            this.grbMain.Name = "grbMain";
            this.grbMain.Padding = new System.Windows.Forms.Padding(0);
            this.grbMain.Size = new System.Drawing.Size(632, 136);
            this.grbMain.TabIndex = 2;
            this.grbMain.TabStop = false;
            // 
            // btnHiddeStatus
            // 
            this.btnHiddeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHiddeStatus.Location = new System.Drawing.Point(554, 12);
            this.btnHiddeStatus.Name = "btnHiddeStatus";
            this.btnHiddeStatus.Size = new System.Drawing.Size(75, 23);
            this.btnHiddeStatus.TabIndex = 4;
            this.btnHiddeStatus.Text = "&Hide";
            this.btnHiddeStatus.UseVisualStyleBackColor = true;
            this.btnHiddeStatus.Click += new System.EventHandler(this.btnHiddeStatus_Click);
            // 
            // grbProgres
            // 
            this.grbProgres.Controls.Add(this.txtProgressOverview);
            this.grbProgres.Controls.Add(this.txtFileInProgress);
            this.grbProgres.Controls.Add(this.txtAction);
            this.grbProgres.Controls.Add(this.txtArchive);
            this.grbProgres.Controls.Add(this.lblProgresOverview);
            this.grbProgres.Controls.Add(this.lblAction);
            this.grbProgres.Controls.Add(this.lblFileInProgress);
            this.grbProgres.Controls.Add(this.lblArchive);
            this.grbProgres.Controls.Add(this.pgbTotal);
            this.grbProgres.Location = new System.Drawing.Point(132, 8);
            this.grbProgres.Name = "grbProgres";
            this.grbProgres.Size = new System.Drawing.Size(416, 120);
            this.grbProgres.TabIndex = 3;
            this.grbProgres.TabStop = false;
            // 
            // txtProgressOverview
            // 
            this.txtProgressOverview.BackColor = System.Drawing.SystemColors.Control;
            this.txtProgressOverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProgressOverview.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtProgressOverview.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgressOverview.Location = new System.Drawing.Point(106, 78);
            this.txtProgressOverview.Name = "txtProgressOverview";
            this.txtProgressOverview.Size = new System.Drawing.Size(304, 14);
            this.txtProgressOverview.TabIndex = 9;
            this.txtProgressOverview.Text = "0/100";
            this.txtProgressOverview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFileInProgress
            // 
            this.txtFileInProgress.BackColor = System.Drawing.SystemColors.Control;
            this.txtFileInProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileInProgress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFileInProgress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileInProgress.Location = new System.Drawing.Point(105, 59);
            this.txtFileInProgress.Name = "txtFileInProgress";
            this.txtFileInProgress.Size = new System.Drawing.Size(304, 14);
            this.txtFileInProgress.TabIndex = 8;
            this.txtFileInProgress.Text = "FILE_WITH_PATH";
            this.txtFileInProgress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAction
            // 
            this.txtAction.BackColor = System.Drawing.SystemColors.Control;
            this.txtAction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAction.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAction.Location = new System.Drawing.Point(105, 40);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(304, 14);
            this.txtAction.TabIndex = 7;
            this.txtAction.Text = "COMPRESS";
            this.txtAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtArchive
            // 
            this.txtArchive.BackColor = System.Drawing.SystemColors.Control;
            this.txtArchive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArchive.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtArchive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchive.Location = new System.Drawing.Point(105, 21);
            this.txtArchive.Name = "txtArchive";
            this.txtArchive.Size = new System.Drawing.Size(304, 14);
            this.txtArchive.TabIndex = 6;
            this.txtArchive.Text = "FILE_NAME.Z";
            this.txtArchive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProgresOverview
            // 
            this.lblProgresOverview.AutoSize = true;
            this.lblProgresOverview.Location = new System.Drawing.Point(7, 76);
            this.lblProgresOverview.Name = "lblProgresOverview";
            this.lblProgresOverview.Size = new System.Drawing.Size(98, 13);
            this.lblProgresOverview.TabIndex = 5;
            this.lblProgresOverview.Text = "Progress Overview";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(6, 38);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(37, 13);
            this.lblAction.TabIndex = 4;
            this.lblAction.Text = "Action";
            // 
            // lblFileInProgress
            // 
            this.lblFileInProgress.AutoSize = true;
            this.lblFileInProgress.Location = new System.Drawing.Point(6, 57);
            this.lblFileInProgress.Name = "lblFileInProgress";
            this.lblFileInProgress.Size = new System.Drawing.Size(79, 13);
            this.lblFileInProgress.TabIndex = 3;
            this.lblFileInProgress.Text = "File in Progress";
            // 
            // lblArchive
            // 
            this.lblArchive.AutoSize = true;
            this.lblArchive.Location = new System.Drawing.Point(6, 19);
            this.lblArchive.Name = "lblArchive";
            this.lblArchive.Size = new System.Drawing.Size(23, 13);
            this.lblArchive.TabIndex = 2;
            this.lblArchive.Text = "File";
            // 
            // pgbTotal
            // 
            this.pgbTotal.BackColor = System.Drawing.Color.White;
            this.pgbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pgbTotal.Location = new System.Drawing.Point(9, 96);
            this.pgbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.pgbTotal.Name = "pgbTotal";
            this.pgbTotal.Size = new System.Drawing.Size(400, 18);
            this.pgbTotal.Step = 1;
            this.pgbTotal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbTotal.TabIndex = 1;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(5, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(128, 117);
            this.pcbLogo.TabIndex = 2;
            this.pcbLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.stsStatusBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zViewer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel1.PerformLayout();
            this.spcMain.Panel2.ResumeLayout(false);
            this.spcMain.ResumeLayout(false);
            this.tsbIconBar.ResumeLayout(false);
            this.tsbIconBar.PerformLayout();
            this.spcDataProcess.Panel1.ResumeLayout(false);
            this.spcDataProcess.Panel2.ResumeLayout(false);
            this.spcDataProcess.Panel2.PerformLayout();
            this.spcDataProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.grbMain.ResumeLayout(false);
            this.grbProgres.ResumeLayout(false);
            this.grbProgres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslFilesSelected;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalFiles;
        private System.Windows.Forms.ToolStrip tsbIconBar;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripDropDownButton tsbAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddFolder;
        private System.Windows.Forms.ToolStripButton tsbExtractTo;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbInfo;
        private System.Windows.Forms.ToolStripSeparator tssSeparadorIcon;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.SplitContainer spcDataProcess;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOriSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.GroupBox grbMain;
        private System.Windows.Forms.GroupBox grbProgres;
        private System.Windows.Forms.TextBox txtProgressOverview;
        private System.Windows.Forms.TextBox txtFileInProgress;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.TextBox txtArchive;
        private System.Windows.Forms.Label lblProgresOverview;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblFileInProgress;
        private System.Windows.Forms.Label lblArchive;
        private System.Windows.Forms.ProgressBar pgbTotal;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Button btnHiddeStatus;
        // COLUMNS
    }
}

