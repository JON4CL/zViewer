namespace zViewer
{
    partial class FrmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfo));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbMain = new System.Windows.Forms.GroupBox();
            this.grbCompression = new System.Windows.Forms.GroupBox();
            this.txtTotalFiles = new System.Windows.Forms.TextBox();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.txtPackedLenght = new System.Windows.Forms.TextBox();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.txtTotalLenght = new System.Windows.Forms.TextBox();
            this.lblCompresion = new System.Windows.Forms.Label();
            this.lblTamComprimido = new System.Windows.Forms.Label();
            this.lblTamTotal = new System.Windows.Forms.Label();
            this.grbFile = new System.Windows.Forms.GroupBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.pbZLogo = new System.Windows.Forms.PictureBox();
            this.grbMain.SuspendLayout();
            this.grbCompression.SuspendLayout();
            this.grbFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(278, 334);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Ok";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grbMain
            // 
            this.grbMain.Controls.Add(this.grbCompression);
            this.grbMain.Controls.Add(this.grbFile);
            this.grbMain.Controls.Add(this.pbZLogo);
            this.grbMain.Location = new System.Drawing.Point(12, 12);
            this.grbMain.Name = "grbMain";
            this.grbMain.Size = new System.Drawing.Size(341, 316);
            this.grbMain.TabIndex = 2;
            this.grbMain.TabStop = false;
            // 
            // grbCompression
            // 
            this.grbCompression.Controls.Add(this.txtTotalFiles);
            this.grbCompression.Controls.Add(this.lblTotalFiles);
            this.grbCompression.Controls.Add(this.txtPackedLenght);
            this.grbCompression.Controls.Add(this.txtRatio);
            this.grbCompression.Controls.Add(this.txtTotalLenght);
            this.grbCompression.Controls.Add(this.lblCompresion);
            this.grbCompression.Controls.Add(this.lblTamComprimido);
            this.grbCompression.Controls.Add(this.lblTamTotal);
            this.grbCompression.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCompression.Location = new System.Drawing.Point(6, 217);
            this.grbCompression.Name = "grbCompression";
            this.grbCompression.Size = new System.Drawing.Size(329, 93);
            this.grbCompression.TabIndex = 6;
            this.grbCompression.TabStop = false;
            this.grbCompression.Text = "Compression";
            // 
            // txtTotalFiles
            // 
            this.txtTotalFiles.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalFiles.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalFiles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFiles.Location = new System.Drawing.Point(108, 69);
            this.txtTotalFiles.Name = "txtTotalFiles";
            this.txtTotalFiles.Size = new System.Drawing.Size(215, 14);
            this.txtTotalFiles.TabIndex = 7;
            this.txtTotalFiles.Text = "TOTAL DE ARCHIVOS";
            this.txtTotalFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFiles.Location = new System.Drawing.Point(6, 67);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(71, 16);
            this.lblTotalFiles.TabIndex = 6;
            this.lblTotalFiles.Text = "Total Files";
            // 
            // txtPackedLenght
            // 
            this.txtPackedLenght.BackColor = System.Drawing.SystemColors.Control;
            this.txtPackedLenght.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPackedLenght.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPackedLenght.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackedLenght.Location = new System.Drawing.Point(108, 35);
            this.txtPackedLenght.Name = "txtPackedLenght";
            this.txtPackedLenght.Size = new System.Drawing.Size(215, 14);
            this.txtPackedLenght.TabIndex = 5;
            this.txtPackedLenght.Text = "TAMAÑO COMPRIMIDO";
            this.txtPackedLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRatio
            // 
            this.txtRatio.BackColor = System.Drawing.SystemColors.Control;
            this.txtRatio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRatio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRatio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRatio.Location = new System.Drawing.Point(108, 51);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(215, 14);
            this.txtRatio.TabIndex = 4;
            this.txtRatio.Text = "COMPRESSION";
            this.txtRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalLenght
            // 
            this.txtTotalLenght.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalLenght.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalLenght.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalLenght.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLenght.Location = new System.Drawing.Point(108, 19);
            this.txtTotalLenght.Name = "txtTotalLenght";
            this.txtTotalLenght.Size = new System.Drawing.Size(215, 14);
            this.txtTotalLenght.TabIndex = 3;
            this.txtTotalLenght.Text = "TAMAÑO TOTAL";
            this.txtTotalLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCompresion
            // 
            this.lblCompresion.AutoSize = true;
            this.lblCompresion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompresion.Location = new System.Drawing.Point(6, 51);
            this.lblCompresion.Name = "lblCompresion";
            this.lblCompresion.Size = new System.Drawing.Size(42, 16);
            this.lblCompresion.TabIndex = 2;
            this.lblCompresion.Text = "Ratio";
            // 
            // lblTamComprimido
            // 
            this.lblTamComprimido.AutoSize = true;
            this.lblTamComprimido.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamComprimido.Location = new System.Drawing.Point(6, 35);
            this.lblTamComprimido.Name = "lblTamComprimido";
            this.lblTamComprimido.Size = new System.Drawing.Size(99, 16);
            this.lblTamComprimido.TabIndex = 1;
            this.lblTamComprimido.Text = "Packed lenght";
            // 
            // lblTamTotal
            // 
            this.lblTamTotal.AutoSize = true;
            this.lblTamTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamTotal.Location = new System.Drawing.Point(6, 19);
            this.lblTamTotal.Name = "lblTamTotal";
            this.lblTamTotal.Size = new System.Drawing.Size(85, 16);
            this.lblTamTotal.TabIndex = 0;
            this.lblTamTotal.Text = "Total lenght";
            // 
            // grbFile
            // 
            this.grbFile.Controls.Add(this.txtFilePath);
            this.grbFile.Controls.Add(this.txtFileName);
            this.grbFile.Controls.Add(this.lblFilePath);
            this.grbFile.Controls.Add(this.lblFileName);
            this.grbFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFile.Location = new System.Drawing.Point(6, 154);
            this.grbFile.Name = "grbFile";
            this.grbFile.Size = new System.Drawing.Size(329, 57);
            this.grbFile.TabIndex = 3;
            this.grbFile.TabStop = false;
            this.grbFile.Text = "File";
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFilePath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(50, 35);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(273, 14);
            this.txtFilePath.TabIndex = 5;
            this.txtFilePath.Text = "UBICACION DEL ARCHIVO";
            this.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFileName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(50, 19);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(273, 14);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.Text = "NOMBRE DEL ARCHIVO";
            this.txtFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(6, 35);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(38, 16);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "Path";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(6, 19);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(43, 16);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "Name";
            // 
            // pbZLogo
            // 
            this.pbZLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbZLogo.Image")));
            this.pbZLogo.Location = new System.Drawing.Point(6, 20);
            this.pbZLogo.Name = "pbZLogo";
            this.pbZLogo.Size = new System.Drawing.Size(128, 128);
            this.pbZLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbZLogo.TabIndex = 2;
            this.pbZLogo.TabStop = false;
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 365);
            this.ControlBox = false;
            this.Controls.Add(this.grbMain);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Information";
            this.grbMain.ResumeLayout(false);
            this.grbMain.PerformLayout();
            this.grbCompression.ResumeLayout(false);
            this.grbCompression.PerformLayout();
            this.grbFile.ResumeLayout(false);
            this.grbFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grbMain;
        private System.Windows.Forms.PictureBox pbZLogo;
        private System.Windows.Forms.GroupBox grbFile;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox grbCompression;
        private System.Windows.Forms.TextBox txtPackedLenght;
        private System.Windows.Forms.TextBox txtRatio;
        private System.Windows.Forms.TextBox txtTotalLenght;
        private System.Windows.Forms.Label lblCompresion;
        private System.Windows.Forms.Label lblTamComprimido;
        private System.Windows.Forms.Label lblTamTotal;
        private System.Windows.Forms.TextBox txtTotalFiles;
        private System.Windows.Forms.Label lblTotalFiles;
    }
}