using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace LPLauncher
{
    public partial class Form1 : Form
    {
        private List<CMod> m_ModsAvailable = new List<CMod>();
        private List<CMod> m_ModsInstalled = new List<CMod>();

        private const string MOD_SUBFOLDER = @"LifePlay\Content\Modules\";
        private const string BASE_REPO_URL = "https://raw.githubusercontent.com/NickNo-dev/LP-Mods/master/";

        private string m_sPath = "";
        private string m_sLifePlayVersionInstalled = "";
        private string m_sLifePlayVersionAvailable = "";

        public Form1()
        {
            InitializeComponent();

            int cnt = 0;
            // FileInfo fi = new FileInfo(System.Reflection.Assembly.GetEntryAssembly().Location);
            // m_sPath = fi.DirectoryName;

            foreach (string arg in Environment.GetCommandLineArgs())
            {
                switch(cnt++)
                {
                    case 1: // argument 1 is alternative installation path
                        string path = arg;
                        path = path.Trim('"');
                        if(!path.EndsWith("\\"))
                            path+="\\";

                        if (Directory.Exists(path))
                            m_sPath = path;
                        else
                            MessageBox.Show("The path <" + path + "> does not exist. Sorry for that!", "Erm, sorry!" );
                        
                        break;

                    case 0: // own path
                        m_sPath = Path.GetDirectoryName(arg);
                        m_sPath += "\\";
                        break;
                }
            }  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLifePlayVersion();
            
            RefreshLocalMods();
            RefreshRepoMods();
        }

        private void GetLifePlayVersion()
        {
            try
            {
                /** string pathToExe = m_sPath + "lifeplay.exe";
                if(File.Exists(pathToExe))
                {
                    var versionInfo = FileVersionInfo.GetVersionInfo(pathToExe);
                    m_sLifePlayVersionInstalled = versionInfo.ProductVersion;
                } */

                // Read the change log to get the current version
                string pathToLog = m_sPath + "Docs\\change_logs.txt";
                if (File.Exists(pathToLog))
                {
                    using(StreamReader sr = File.OpenText(pathToLog))
                    {
                        string version = sr.ReadLine();
                        version = version.Trim(); 
                        version = version.TrimEnd(':');
                        int idx = version.LastIndexOf(' ');
                        if( idx > 1)
                            version = version.Substring(idx+1);
                        
                        m_sLifePlayVersionInstalled = version;
                        lblLPVersion.Text = version;
                    }
                }
            }
            catch (Exception) { }
        }

        private void RenderInstModList()
        {
            lbInst.Items.Clear();
            foreach (CMod mod in m_ModsInstalled)
            {
                int idx = lbInst.Items.Add(mod);
            }
        }

        private void RenderRepoModList()
        {
            lbAvail.Items.Clear();

            // We keep two lists for sorting them in the UI
            List<CMod> updatedMods = new List<CMod>();
            List<CMod> normalMods = new List<CMod>();

            foreach (CMod mod in m_ModsAvailable)
            {
                // Check if this module is installed locally
                CMod instMod = findInstalledModWithId(mod.getId());
                if (instMod != null)
                {
                    if (instMod.getVersion() != mod.getVersion())
                    {
                        // Looks updated
                        mod.setUpdated(true);
                        updatedMods.Add(mod);
                    }
                    else
                        normalMods.Add(mod);
                }
                else
                    normalMods.Add(mod);
            }

            normalMods.Sort((x, y) => x.ToString().CompareTo(y.ToString()));
            updatedMods.Sort((x, y) => x.ToString().CompareTo(y.ToString()));

            lbAvail.Items.AddRange(updatedMods.ToArray());
            lbAvail.Items.AddRange(normalMods.ToArray());
        }

        private void GetInstalledMods()
        {
            m_ModsInstalled.Clear();

            try
            {
                DirectoryInfo directory = new DirectoryInfo(m_sPath + MOD_SUBFOLDER);
                DirectoryInfo[] directories = directory.GetDirectories();

                foreach (DirectoryInfo folder in directories)
                {
                    // Test if the folder contains a required info file
                    FileInfo modFileInfo = null;
                    if (folder.GetFiles("*.lpmod").Length>0)
                    {
                        modFileInfo = folder.GetFiles("*.lpmod")[0];
                    }
                    else if (folder.GetFiles("*.lpaddon").Length>0)
                    {
                        modFileInfo = folder.GetFiles("*.lpaddon")[0];
                    }
                    else if (folder.GetFiles("*.disabled").Length > 0)
                    {
                        modFileInfo = folder.GetFiles("*.disabled")[0];
                    }

                    if (modFileInfo != null)
                    {
                        try
                        {
                            string modFile = folder.Name;
                            string modPath = modFileInfo.DirectoryName;

                            CMod instMod = new CMod(modFile, modPath);
                            instMod.setFileName(modFileInfo.FullName);
                            instMod.readModInfo();
                            m_ModsInstalled.Add(instMod);
                        }
                        catch (Exception) { }
                    }
                }

                lblInstalledModules.Text = m_ModsInstalled.Count.ToString() + " modules installed (checked: " + DateTime.Now.ToString() + ")";
            }
            catch(Exception ex)
            {
                lblInstalledModules.Text = "I had problems reading your local installation... :-(";
            }
        }

        private void UpdateRepo()
        {
            bool canContinue = true;

            m_ModsAvailable.Clear();

            try
            {
                using (WebClient c = new WebClient())
                {
                    c.DownloadFile(BASE_REPO_URL + "repo.xml", "lprepo.xml");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Cannot download mod repository. Check your connection and/or if a newer version of the mod manager is avalilable.", "Ooops!");
                canContinue = false;
            }

            XmlDocument repo = new XmlDocument();
            if(canContinue)
            {
                try
                {
                    repo.Load("lprepo.xml");
                    XmlNode root = repo.DocumentElement.SelectSingleNode("/Repo");
                    foreach (XmlNode modXml in root.ChildNodes)
                    {
                        if (modXml.LocalName == "#comment")
                        {
                            string val = modXml.Value;
                            const string searchVer = "#Current LifePlay Version:";
                            if (val.Contains(searchVer))
                            {
                                val = val.Trim();
                                m_sLifePlayVersionAvailable = val.Substring(searchVer.Length + 1);
                            }
                            continue;
                        }

                        string name = modXml.Attributes["Name"].InnerText;
                        string ver = modXml.Attributes["Version"].InnerText;
                        string id = modXml.Attributes["Id"].InnerText;
                        string path = BASE_REPO_URL + modXml.Attributes["Path"].InnerText;

                        CMod curMod = new CMod(id, name, ver, path);

                        // Test for optional message
                        string devMsg = null;
                        if( modXml.Attributes.GetNamedItem("Msg") != null )
                            devMsg = modXml.Attributes["Msg"].InnerText;
                        curMod.setDevMessage(devMsg);

                        // Optional description
                        string descr = null;
                        if (modXml.Attributes.GetNamedItem("Description") != null)
                            descr = modXml.Attributes["Description"].InnerText;
                        curMod.setDescription(descr);

                        // Optional dependencies
                        string deps = null;
                        if (modXml.Attributes.GetNamedItem("Depends") != null)
                            deps = modXml.Attributes["Depends"].InnerText;
                        curMod.setDependencies(deps);
                        
                        m_ModsAvailable.Add(curMod);
                        
                    }

                    lblAvailModules.Text = m_ModsAvailable.Count.ToString() + " modules available (checked: " + DateTime.Now.ToString() + ")";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, "The repo could not be downloaded. Please check if a newer version of the mod manager is avalilable.", "Ooops!");
                    canContinue = false;

                    lblAvailModules.Text = "Unable to fetch the repository. :-(";
                }
            }

            if (File.Exists("lprepo.xml"))
                File.Delete("lprepo.xml");

            if( m_sLifePlayVersionInstalled != m_sLifePlayVersionAvailable )
            {
                DialogResult dr = MessageBox.Show("Looks like you are running an old version of LifePlay.\nShall I open the download site for you?", "LifePlay is out dated", MessageBoxButtons.YesNo);
                if( dr == System.Windows.Forms.DialogResult.Yes )
                {
                    Process.Start("https://f95zone.to/threads/lifeplay-v2-17-vinfamy.11321/");
                }
            }

        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            Process.Start(m_sPath + "lifeplay.exe");
        }

        private void lbInst_DoubleClick(object sender, EventArgs e)
        {
            if (lbInst.SelectedItem != null)
            {
                CMod selMod = (CMod)lbInst.SelectedItem;

                if (!selMod.isBaseMod())
                {
                    selMod.toggleActive();

                    lbInst.Items.Remove(selMod);
                    lbInst.Items.Add(selMod);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelMod_Click(object sender, EventArgs e)
        {
            if (lbInst.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete the mod?","Delete mod",MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    CMod mod = (CMod)lbInst.SelectedItem;
                    if (!mod.isBaseMod())
                    {
                        bool success = mod.delete();

                        if (success)
                        {
                            lbInst.Items.Remove(mod);
                            m_ModsInstalled.Remove(mod);
                        }
                    }
                }
            }
        }

        private void lbInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbInst.SelectedItem != null)
            {
                CMod mod = (CMod)lbInst.SelectedItem;

                if (!mod.isBaseMod())
                    btnDelMod.Enabled = true;
                else
                    btnDelMod.Enabled = false;

                // Select the same module in the repo if available
                int oldSel = lbAvail.SelectedIndex;
                for (int idx = 0; idx < lbAvail.Items.Count; idx++)
                {
                    CMod itm = (CMod)lbAvail.Items[idx];
                    if (itm.getId() == mod.getId())
                    {
                        lbAvail.SelectedIndex = idx;
                        break;
                    }
                }
            }
            else
                btnDelMod.Enabled = false;
        }

        private void lbAvail_DoubleClick(object sender, EventArgs e)
        {
            if (lbAvail.SelectedItem != null)
            {
                CMod mod = (CMod)lbAvail.SelectedItem;
                
                InstallMod(mod, true);

                RefreshLocalMods();
            }
        }

        private void InstallMod(CMod mod, bool askToReplace = false)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    wc.DownloadFile(mod.getFileName(), "lpmgr.tmp");

                    if (Directory.Exists("mmTemp"))
                        Directory.Delete("mmTemp", true);

                    Directory.CreateDirectory("mmTemp");

                    System.IO.Compression.ZipFile.ExtractToDirectory("lpmgr.tmp", "mmTemp");

                    string[] subFolders = Directory.GetDirectories("mmTemp");
                    if (subFolders.Length == 1)    // I do not want to spread junk, mods need to keep to 1 subfolder
                    {
                        string name = Path.GetFileName(subFolders[0]);

                        // Test if already installed
                        bool install = true;
                        string dest = m_sPath + MOD_SUBFOLDER + name;
                        if (Directory.Exists(dest))
                        {
                            DialogResult dr = System.Windows.Forms.DialogResult.Yes;
                            if(askToReplace)
                            {
                                dr = MessageBox.Show("Replace existing mod?", "Already installed!", MessageBoxButtons.YesNo);
                            }

                            if (dr == System.Windows.Forms.DialogResult.Yes)
                                Directory.Delete(dest, true);
                            else
                                install = false;
                        }

                        if (install)
                        {
                            Directory.Move(subFolders[0], dest);

                            if( mod.getDevMessage() != null )
                            {
                                MessageBox.Show(mod.getDevMessage(), "Message from mod " + mod.getName());
                            }
                        }

                    }

                    if (Directory.Exists("mmTemp"))
                        Directory.Delete("mmTemp", true);

                    File.Delete("lpmgr.tmp");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem during installation of mod " + mod.ToString() + ":\n" + ex.Message, "Ooops...");
                }
            }
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            // Compare avail with installed
            List<CMod> modsToUpdate = new List<CMod>();
            string sModsToUpdate = "";

            foreach( CMod modAvail in m_ModsAvailable )
            {
                CMod found = findInstalledModWithId(modAvail.getId());
                if( found != null )
                {
                    if( found.getVersion() != modAvail.getVersion() )
                    {
                        // Looks like changed
                        modsToUpdate.Add(modAvail);
                        sModsToUpdate += modAvail.ToString() + "\n";
                    }
                }
            }

            if (modsToUpdate.Count > 0)
            {
                DialogResult dr = MessageBox.Show("The following updates are available:\n\n"+sModsToUpdate +"\nInstall them now?", "Updates found", MessageBoxButtons.YesNo);
                if( dr == System.Windows.Forms.DialogResult.Yes )
                {
                    foreach(CMod modToUpdate in modsToUpdate)
                    {
                        bool currentState = true;
                        CMod installedVersion = findInstalledModWithId(modToUpdate.getId());
                        currentState = installedVersion.isEnabled();
                    
                        InstallMod(modToUpdate);

                        // After installation all mods are enabled.
                        // Set the previous state
                        if( !currentState )
                        {
                            // Disable again
                            installedVersion = findInstalledModWithId(modToUpdate.getId());
                            installedVersion.toggleActive();
                        }
                    }

                    RefreshLocalMods();
                    RefreshRepoMods();
                }
            }
            else
                MessageBox.Show("All your modules are up to date.", "No updates found");

        }

        private CMod findInstalledModWithId(string id)
        {
            // TODO: If LP sometime has 1000+ mods we could switch this to a dictonary with key = id
            foreach (CMod modInst in m_ModsInstalled)
            {
                if (modInst.getId() == id)
                    return modInst;
            }
            return null;
        }

        private void lbAvail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAvail.SelectedItem != null)
            {
                CMod selMod = (CMod)lbAvail.SelectedItem;

                if (selMod.getDescription() == null)
                {
                    
                    if( selMod.getDependencies() != null )
                        lblModInfo.Text = "Requires: " + selMod.getDependencies();
                    else
                        lblModInfo.Text = "Double click a module to install / update it.";
                }
                else
                {
                    lblModInfo.Text = selMod.getDescription();
                    if (selMod.getDependencies() != null)
                        lblModInfo.Text += " [Requires: " + selMod.getDependencies() + "]";
                }

                // Select the same module in the local repo if installed
                int oldSel = lbInst.SelectedIndex;
                for( int idx = 0; idx < lbInst.Items.Count; idx++ )
                {
                    CMod itm = (CMod)lbInst.Items[idx];
                    if (itm.getId() == selMod.getId())
                    {
                        lbInst.SelectedIndex = idx;
                        break;
                    }
                }
            }
            else
                lblModInfo.Text = "Double click a module to install / update it.";
        }

        private void pbRefreshLocal_Click(object sender, EventArgs e)
        {
            RefreshLocalMods();
        }

        private void RefreshLocalMods()
        {
            GetInstalledMods();
            RenderInstModList();
        }

        private void pbRefreshRepo_Click(object sender, EventArgs e)
        {
            RefreshRepoMods();
        }

        private void RefreshRepoMods()
        {
            UpdateRepo();
            RenderRepoModList();
        }
    }
}
