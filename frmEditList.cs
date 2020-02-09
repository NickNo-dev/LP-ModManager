using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPLauncher
{
    public partial class frmEditList : Form
    {
        public enum EditorType
        {
            editNames = 0,
            editClothesCasual = 1,
            editClothesSport = 2,
            editClothesWork = 3
        }

        private CNameLists nameLists;
        private CClothLists clothLists;

        private EditorType m_EditWhat = EditorType.editNames;
        private string m_sPath;

        public frmEditList( EditorType t, string gamePath )
        {
            InitializeComponent();
            m_EditWhat = t;
            m_sPath = gamePath;

            switch( m_EditWhat )
            {
                case EditorType.editNames:
                    nameLists = new CNameLists(m_sPath);
                    bool success = nameLists.loadNameLists();
                    if (!success)
                        success = nameLists.readLPNameLists();

                    if (success)
                    {
                        txtFemale.Text = nameLists.getFemaleList();
                        txtMale.Text = nameLists.getMaleList();
                    }
                    break;

                case EditorType.editClothesWork:
                case EditorType.editClothesSport:
                case EditorType.editClothesCasual:
                    lblLeft.Text = "Male clothing";
                    lblRight.Text = "Female clothing";

                    CClothLists.ClothType ct = CClothLists.ClothType.ctCasual;
                    switch(t)
                    { 
                        case EditorType.editClothesSport:
                            ct = CClothLists.ClothType.ctSport;
                            break;

                        case EditorType.editClothesWork:
                            ct = CClothLists.ClothType.ctWork;
                            break;
                    }

                    clothLists = new CClothLists(m_sPath, ct);
                    bool successCl = clothLists.loadClothList();
                    if (!successCl)
                        successCl = clothLists.readLPClothList();

                    if (successCl)
                    {
                        txtFemale.Text = clothLists.getFemaleList();
                        txtMale.Text = clothLists.getMaleList();
                    }
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_EditWhat == EditorType.editNames)
            {
                nameLists.setNameLists(txtMale.Text, txtFemale.Text);
                nameLists.saveNameLists();
            }
            else
            {
                clothLists.setListData(txtMale.Text, txtFemale.Text);
                clothLists.saveClothList();
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnImportDefaults_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This will clear the current list and load the file from the LifePlay modules folder.\n\nContinue?", "Clear current list?", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No)
                return;

            if (m_EditWhat == EditorType.editNames)
            {
                nameLists.clearLists();
                bool success = nameLists.readLPNameLists();
                if (success)
                {
                    txtFemale.Text = nameLists.getFemaleList();
                    txtMale.Text = nameLists.getMaleList();
                }
            }
            else
            {
                clothLists.clearLists();
                bool success = clothLists.readLPClothList();
                if (success)
                {
                    txtFemale.Text = clothLists.getFemaleList();
                    txtMale.Text = clothLists.getMaleList();
                }
            }
        }
    }
}
