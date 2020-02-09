using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPLauncher
{
    class CNameLists
    {

        private string m_sPath;
        private string m_sErrorMessage;
        private string m_sFemaleList = "";
        private string m_sMaleList = "";

        public static bool hasCustomNameList(string sGamePath)
        {
            string sPath = sGamePath + @".LPLauncher\nameList.txt";

            if (!File.Exists(sPath))
                return false;

            return true;
        }

        public CNameLists(string sGamePath)
        {
            m_sPath = sGamePath;
        }

        public bool saveNameLists()
        {
            string sPath = m_sPath + @".LPLauncher";

            if (!Directory.Exists(sPath))
                Directory.CreateDirectory(sPath);

            sPath += "\\nameList.txt";
            try
            {
                if (File.Exists(sPath))
                    File.Delete(sPath);

                using (StreamWriter sw = new StreamWriter(File.OpenWrite(sPath)))
                {
                    sw.WriteLine("#LifePlay Launcher name list");

                    writeDataToFile(sw, m_sMaleList, "male");
                    writeDataToFile(sw, m_sFemaleList, "female");

                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                m_sErrorMessage = ex.Message;
                return false;
            }

            return true;

        }

        public bool loadNameLists()
        {
            string sPath = m_sPath + @".LPLauncher\nameList.txt";

            if (!File.Exists(sPath))
                return false;
            try
            {
                using (StreamReader sr = File.OpenText(sPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        if (!line.StartsWith("#") && line.IndexOf(':') > 1)
                        {
                            string[] kvp = line.Split(':');

                            string sId = kvp[0];
                            bool male = (kvp[0].ToLower() == "male");

                            string d = kvp[1].Trim();
                            if (d.Length > 0)
                            {
                                if (male)
                                    m_sMaleList += d + "\r\n";
                                else
                                    m_sFemaleList += d + "\r\n";
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                m_sErrorMessage = ex.Message;
                return false;
            }

            return true;
        }
        
        public void setNameLists( string male, string female )
        {
            char[] charsToTrim = { '\r', '\n', ' ' };
            m_sMaleList = male.TrimEnd(charsToTrim);
            m_sFemaleList = female.TrimEnd(charsToTrim); 
        }


        public bool readLPNameLists()
        {
            string sPath = m_sPath + @"LifePlay\Content\Modules\names_M.txt";
            bool ret = true;
            
            if (File.Exists(sPath))
            {
                ret = readLPNameLists(sPath, true);
            }

            sPath = m_sPath + @"LifePlay\Content\Modules\names_F.txt";

            if (ret && File.Exists(sPath))
            {
                ret = readLPNameLists(sPath, false);
            }
            else
                ret = false;

            return ret;
        }

        public bool readLPNameLists(string sPath, bool asMale)
        {
            try
            {
                using (StreamReader sr = File.OpenText(sPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        if (asMale)
                            m_sMaleList += line + "\r\n";
                        else
                            m_sFemaleList += line + "\r\n";
                    }
                }
            }
            catch (Exception ex)
            {
                m_sErrorMessage = ex.Message;
                return false;
            }

            return true;
        }


        public string getFemaleList()
        {
            return m_sFemaleList;
        }

        public string getMaleList()
        {
            return m_sMaleList;
        }

        public void writeLifePlayNameLists(string sGamePath)
        {
            if (!Directory.Exists(sGamePath))
                return;

            string filename = sGamePath + @"LifePlay\Content\Modules\names_M.txt";
            if (File.Exists(filename))
                File.Delete(filename);

            using (StreamWriter sw = new StreamWriter(File.OpenWrite(filename)))
            {
                sw.Write(m_sMaleList);
            }

            filename = sGamePath + @"LifePlay\Content\Modules\names_F.txt";
            if (File.Exists(filename))
                File.Delete(filename);

            using (StreamWriter sw = new StreamWriter(File.OpenWrite(filename)))
            {
                sw.Write(m_sFemaleList);
            }

        }

        public void clearLists()
        {
            m_sFemaleList = "";
            m_sMaleList = "";
        }



        /**
         * PRIVATE  
         * 
         */

        private void writeDataToFile(StreamWriter sw, string data, string prefix)
        {
            data = data.Replace("\r\n", "\n");
            string[] items = data.Split('\n');
            foreach (string line in items)
            {
                string l = line.Trim();
                if (l.Length > 0)
                    sw.WriteLine(prefix + ":" + l);
            }
        }
    }
}
