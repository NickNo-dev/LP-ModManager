using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LPLauncher
{
    class CMod
    {
        private string m_sName;
        private string m_sVersion;
        private string m_sPath;
        private string m_sModId;
        
        private string m_sDevMsg;

        private string m_sFileName;


        public CMod(string name, string path)
        {
            m_sName = name;
            m_sPath = path;
        }

        public CMod(string id, string name, string version, string path)
        {
            m_sName = name;
            m_sVersion = version;
            m_sPath = path;
            m_sModId = id;
        }

        public string getName() { return m_sName; }
        public string getId() { return m_sModId; }
        
        public string getVersion() { return m_sVersion; }
        public string getPath() { return m_sPath; }

        public string getFileName() { return (m_sFileName == null ? m_sPath : m_sFileName); }
        public void setFileName(string s) { m_sFileName = s; }
        public void setDevMessage(string s) { m_sDevMsg = s; }
        public string getDevMessage() { return m_sDevMsg; }

        public bool isEnabled()
        {
            if (m_sFileName != null)
                return !m_sFileName.EndsWith(".disabled");
            else
                return true;
        }

        public bool isRepoMod()
        {
            return m_sPath.StartsWith("https://");
        }

        public string getDisplayName() 
        {
            if (isRepoMod())
                return m_sName + " " + m_sVersion;
            else
                return m_sName + (m_sVersion!=null ? " (" + m_sVersion + ") " : "" ) + (isEnabled() ? "" : " [disabled]");
        }

        public override string ToString()
        {
            return getDisplayName();
        }

        public bool toggleActive()
        {
            if (isRepoMod())
                return false;

            string newName = "";

            if (!isEnabled())
            {
                newName = m_sFileName.Substring(0,m_sFileName.Length - 9);
            }
            else
            {
                newName = m_sFileName + ".disabled";
            }

            File.Move(m_sFileName, newName);

            m_sFileName = newName;

            return isEnabled();
        }

        internal bool delete()
        {
            if (!isRepoMod())
            {
                try
                {
                    Directory.Delete(m_sPath, true);
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        internal bool isBaseMod()
        {
            return m_sFileName.Contains("vin_Base");
        }

        internal bool readModInfo()
        {
            if( !isRepoMod() )
            {
                try
                {
                    using( StreamReader sr = new StreamReader(File.OpenRead(m_sFileName)))
                    {
                        while (!sr.EndOfStream)
                        {
                            string l = sr.ReadLine();
                            if (l.Contains(':'))
                            {
                                string[] itms = l.Split(':');
                                string key = itms[0];
                                string value = itms[1];
                                key = key.Trim();
                                value = value.Trim();

                                switch (key.ToUpper())
                                {
                                    case "MODULE_NAME":
                                        m_sName = value;
                                        break;
                                    case "MODULE_VERSION":
                                        m_sVersion = value;
                                        break;
                                    case "MODULE_UNIQUEID":
                                        m_sModId = value;
                                        break;
                                }
                            }
                        }

                        sr.Close();
                    }
                }
                catch(Exception ex)
                {
                    return false;
                }

                return true;
            }

            return false;
        }
    }
}
