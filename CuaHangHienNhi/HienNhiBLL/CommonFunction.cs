using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HienNhiDTOs;
using System.Xml;
using System.IO;

namespace HienNhiBLL
{
    public static class CommonFunction
    {
        // Get connectionString stored in the config file (/AppData/)
        public static string getConnectionString()
        {
            try
            {
                //XmlReader reader = XmlReader.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HienNhi\\config.xml");
                //while (reader.Read())
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HienNhi\\config.xml");
                XmlNodeList nodeList = xDoc.GetElementsByTagName("connectionString");
                return nodeList.Item(0).InnerText.ToString();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        //Get the path of the log folder
        public static string getLogPath()
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HienNhi\\config.xml");
                XmlNodeList nodeList = xDoc.GetElementsByTagName("logPath");
                return nodeList.Item(0).InnerText.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }

        //Write error message to log file. If the file was not created yet, then create it
        //The pattern for the log file name: log_ddmmyyyy.txt
        public static void writeLog(MyExceptionNS.MyException ex)
        {
            try
            {
                if (!Directory.Exists(getLogPath()))
                {
                    Directory.CreateDirectory(getLogPath());
                }
                string path = getLogPath() + "\\" + generateFileName();
                if (!File.Exists(path))     //if the file was not created yet, then create the file and add the header to it
                {
                    string header = "Log file " + DateTime.Today.ToShortDateString() + Environment.NewLine + "----------------------------------" + Environment.NewLine;
                    File.WriteAllText(path, header);
                }
                
                StringBuilder sb = new StringBuilder();
                sb.Append(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                sb.AppendLine(" - Error at class: " + ex.className);
                sb.Append("\t\t");
                sb.AppendLine("Error: " + ex.errMsg);
                File.AppendAllText(path, sb.ToString());

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static string generateFileName()
        {
            string day = DateTime.Today.Day < 10 ? "0" + DateTime.Today.Day.ToString() : DateTime.Today.Day.ToString();
            string month = DateTime.Today.Month < 10 ? "0" + DateTime.Today.Month.ToString() : DateTime.Today.Month.ToString();
            string year = DateTime.Today.Year.ToString();
            return "log_" + day + month + year + ".txt";
            
        }
    }
}
