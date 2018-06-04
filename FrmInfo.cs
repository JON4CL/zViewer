using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace zViewer
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void setFileData(string fileName, long sizeTotal, long sizePacked, long totalFiles)
        {
            this.txtFileName.Text = fileName.Substring(fileName.LastIndexOf(char.Parse("\\"))+1);
            this.txtFilePath.Text = fileName.Substring(0, fileName.LastIndexOf(char.Parse("\\")));
            this.txtTotalLenght.Text = sizeTotal.ToString("N0") + " bytes";
            this.txtPackedLenght.Text = sizePacked.ToString("N0") + " bytes";
            try
            {
                this.txtRatio.Text = (100 - ((sizePacked * 100) / sizeTotal)).ToString() + "%";
            }
            catch (Exception ex)
            {
                this.txtRatio.Text = "0%";
            }
            this.txtTotalFiles.Text = totalFiles.ToString("N0");
        }
    }
}