using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace zViewer
{
    class CommonFunctions
    {
        private CommonFunctions()
        {
            // STATIC CLASS
        }
        //
        public static string getTimeStamp()
        {
            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = DateTime.UtcNow;
            TimeSpan ts = new TimeSpan(d2.Ticks - d1.Ticks);
            return ts.TotalMilliseconds.ToString();
        }
        //
        public static void runApp(string app, string arguments)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo(app, arguments);
            processStartInfo.UseShellExecute = false;
            processStartInfo.ErrorDialog = false;
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processStartInfo.CreateNoWindow = true;
            //
            Process process = new Process();
            process.StartInfo = processStartInfo;
            //
            bool processStarted;
            //
            try
            {
                processStarted = process.Start();
                //process.WaitForExit();
            }
            catch (Exception ex)
            {
                // NO CONTROL
            }
        }
        //
        public static void saveLogFile(string fileName, string dataStream)
        {
            System.IO.FileStream file = new System.IO.FileStream(fileName, System.IO.FileMode.Append, System.IO.FileAccess.Write);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(file);
            sw.Write(CommonFunctions.getTimeStamp() + ":" + dataStream);
            sw.Close();
        }
    }
}
