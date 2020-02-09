using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPLauncher
{
    class CClothLists
    {

        public enum ClothType
        {
            ctCasual = 0,
            ctSport = 1,
            ctWork = 2
        }

        private string m_sPath;
        private string m_sErrorMessage;
        private string m_sFemaleList = "";
        private string m_sMaleList = "";
        private ClothType m_ClothType = ClothType.ctCasual;

        public static bool hasCustomClothLists(string sGamePath, ClothType ct)
        {
            string sPath = sGamePath + @".LPLauncher\" + getListName(ct);

            if (!File.Exists(sPath))
                return false;

            return true;
        }

        private static string getListName(ClothType ct)
        {
            string sPath = "clothList";

            switch (ct)
            {
                case ClothType.ctCasual:
                    sPath += "_Casual";
                    break;

                case ClothType.ctSport:
                    sPath += "_Sport";
                    break;

                case ClothType.ctWork:
                    sPath += "_Work";
                    break;
            }

            sPath += ".txt";

            return sPath;
        }

        public CClothLists(string sGamePath, ClothType ct)
        {
            m_sPath = sGamePath;
            m_ClothType = ct;
        }

        public bool saveClothList()
        {
            string sPath = m_sPath + @".LPLauncher";

            if (!Directory.Exists(sPath))
                Directory.CreateDirectory(sPath);

            sPath += "\\" + getListName(m_ClothType);
            try
            {
                if (File.Exists(sPath))
                    File.Delete(sPath);

                using (StreamWriter sw = new StreamWriter(File.OpenWrite(sPath)))
                {
                    sw.WriteLine("#LifePlay Launcher cloth list");

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

        public bool loadClothList()
        {
            string sPath = m_sPath + @".LPLauncher\" + getListName(m_ClothType);

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

                            if (male)
                                m_sMaleList += kvp[1] + "\r\n";
                            else
                                m_sFemaleList += kvp[1] + "\r\n";
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
        
        public void setListData( string male, string female )
        {
            char[] charsToTrim = { '\r', '\n', ' ' };
            m_sMaleList = male.TrimEnd(charsToTrim);
            m_sFemaleList = female.TrimEnd(charsToTrim); 
        }


        public bool readLPClothList()
        {
            string listPrefix = "";
            switch (m_ClothType)
            {
                case ClothType.ctSport:
                    listPrefix = "_sports";
                    break;
                case ClothType.ctWork:
                    listPrefix = "_work";
                    break;
            }

            string sPath = m_sPath + @"LifePlay\Content\Modules\outfits_M" + listPrefix + ".txt";
            bool ret = true;
            
            if (File.Exists(sPath))
            {
                ret = readLPList(sPath, true);
            }

            sPath = m_sPath + @"LifePlay\Content\Modules\outfits_F" + listPrefix + ".txt";
            

            if (ret && File.Exists(sPath))
            {
                ret = readLPList(sPath, false);
            }
            else
                ret = false;

            return ret;
        }

        public bool readLPList(string sPath, bool asMale)
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

        public void writeLifePlayClothList(string sGamePath)
        {
            if (!Directory.Exists(sGamePath))
                return;

            string listPrefix = "";
            switch (m_ClothType)
            {
                case ClothType.ctSport:
                    listPrefix = "_sports";
                    break;
                case ClothType.ctWork:
                    listPrefix = "_work";
                    break;
            }
            
            string filename = sGamePath + @"LifePlay\Content\Modules\outfits_M" + listPrefix + ".txt";
            if (File.Exists(filename))
                File.Delete(filename);

            using (StreamWriter sw = new StreamWriter(File.OpenWrite(filename)))
            {
                sw.Write(m_sMaleList);
            }

            
            filename = sGamePath + @"LifePlay\Content\Modules\outfits_F" + listPrefix + ".txt";
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
                // Contrary to name lists we allow empty lines here...
                sw.WriteLine(prefix + ":" + line);
            }
        }
    }
}
