using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace zViewer
{
    class ZFile
    {
        private string date;
        private string time;
        private ulong oriSize;
        private string atributes;
        private ulong compSize;
        private string fileName;

        public ZFile()
        {
            this.date = "";
            this.time = "";
            this.oriSize = 0;
            this.atributes = "";
            this.compSize = 0;
            this.fileName = "";
        }

        public ZFile(string rawData)
        {
            processRawData(rawData);
        }

        public ZFile(string date, string time, ulong oriSize, string atributes, ulong compSize, string fileName)
        {
            this.date = date;
            this.time = time;
            this.oriSize = oriSize;
            this.atributes = atributes;
            this.compSize = compSize;
            this.fileName = fileName;
        }

        private void processRawData(string rawData)
        {
            this.date = rawData.Substring(1, 9).Trim();
            this.time = rawData.Substring(10, 6).Trim();
            this.oriSize = ulong.Parse(rawData.Substring(16, 9).ToString());
            this.atributes = rawData.Substring(25, 5).Trim();
            this.compSize = ulong.Parse(rawData.Substring(30, 9).ToString());
            this.fileName = rawData.Substring(39).Trim();
        }

        public string Date
        {
            get { return this.date; }
        }
        public string Time
        {
            get { return this.time; }
        }
        public string Atributes
        {
            get { return this.atributes; }
        }
        public ulong OriSize
        {
            get { return this.oriSize; }
        }
        public ulong CompSize
        {
            get { return this.compSize; }
        }
        public string FileName
        {
            get { return this.fileName; }
        }
    }
}
