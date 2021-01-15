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
        private string m_sDescription;
        private string m_sDepends;
        private string m_sDevMsg;
        private bool m_bIsPatch = false;
        private int m_index = -1;

        private bool m_bIsEnabled = true;

        private string m_sFileName;

        private bool m_bIsUpdated = false;


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

            if (!isRepoMod())
            {
                if (id == "vin_Base")
                    m_index = 0;
                else if (id.StartsWith("vin_"))
                    m_index = 1;
            }
        }

        public string getName() { return m_sName; }
        public string getId() { return m_sModId; }
        
        public string getVersion() { return m_sVersion; }
        public string getPath() { return m_sPath; }


        public string getFileName() { return (m_sFileName == null ? m_sPath : m_sFileName); }
        public void setFileName(string s) { m_sFileName = s; }
        
        public void setDevMessage(string s) { m_sDevMsg = s; }
        public string getDevMessage() { return m_sDevMsg; }
        
        public void setDescription(string s) { m_sDescription = s; }
        public string getDescription() { return m_sDescription; }

        public void setDependencies(string s) { m_sDepends = s; }
        public string getDependencies() { return m_sDepends; }

        public void setUpdated(bool state) { m_bIsUpdated = state; }

        public void setIsPatch(bool p) { m_bIsPatch = p; }
        public bool isPatch() { return m_bIsPatch; }

        public bool isEnabled()
        {
            return m_bIsEnabled;
        }

        public void setEnabled(bool state)
        {
            m_bIsEnabled = state;
        }

        public bool isAddon()
        {
            if (m_sFileName != null)
                return m_sFileName.Contains(".lpaddon");
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
                return (m_bIsUpdated ? "[Updated] " : "") + m_sName + " (" + m_sVersion + ")";
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

            m_bIsEnabled = !m_bIsEnabled;

            return m_bIsEnabled;
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
                                    case "MODULE_DESCRIPTION":
                                        m_sDescription = value;
                                        break;
                                    case "MODULE_REQUIREMENTS":
                                        m_sDepends = value;
                                        break;
                                }
                            }
                        }

                        sr.Close();
                    }

                    if (!isRepoMod() && m_index == -1 )
                    {
                        if (m_sModId == "vin_Base")
                            m_index = 0;
                        else if (m_sModId.StartsWith("vin_"))
                            m_index = 1;
                        else
                            m_index = 9999999;
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

        internal void setIndex(int p)
        {
            m_index = p;
        }

        internal int getIndex()
        {
            return m_index;
        }
    }
}
