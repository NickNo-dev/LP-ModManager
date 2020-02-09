namespace LPLauncher
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbAvail = new System.Windows.Forms.ListBox();
            this.lbInst = new System.Windows.Forms.ListBox();
            this.lblModHint = new System.Windows.Forms.Label();
            this.lblModInfo = new System.Windows.Forms.Label();
            this.splitContainerContent = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottomLeft = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAvailModules = new System.Windows.Forms.Label();
            this.pbRefreshRepo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottomRight = new System.Windows.Forms.TableLayoutPanel();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnDelMod = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInstalledModules = new System.Windows.Forms.Label();
            this.pbRefreshLocal = new System.Windows.Forms.PictureBox();
            this.splitContainerHeader = new System.Windows.Forms.SplitContainer();
            this.lblLPVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmAdvanced = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editLifePlayNameListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLifePlaysportsOutfitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLifePlayworkOutfitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLifePlaycasualOutfitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).BeginInit();
            this.splitContainerContent.Panel1.SuspendLayout();
            this.splitContainerContent.Panel2.SuspendLayout();
            this.splitContainerContent.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelBottomLeft.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefreshRepo)).BeginInit();
            this.tableLayoutPanelRight.SuspendLayout();
            this.tableLayoutPanelBottomRight.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefreshLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).BeginInit();
            this.splitContainerHeader.Panel1.SuspendLayout();
            this.splitContainerHeader.Panel2.SuspendLayout();
            this.splitContainerHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAvail
            // 
            this.lbAvail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAvail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAvail.ForeColor = System.Drawing.Color.White;
            this.lbAvail.Location = new System.Drawing.Point(3, 23);
            this.lbAvail.Name = "lbAvail";
            this.lbAvail.Size = new System.Drawing.Size(448, 386);
            this.lbAvail.TabIndex = 2;
            this.lbAvail.SelectedIndexChanged += new System.EventHandler(this.lbAvail_SelectedIndexChanged);
            this.lbAvail.DoubleClick += new System.EventHandler(this.lbAvail_DoubleClick);
            // 
            // lbInst
            // 
            this.lbInst.AllowDrop = true;
            this.lbInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbInst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInst.ForeColor = System.Drawing.Color.White;
            this.lbInst.Location = new System.Drawing.Point(3, 23);
            this.lbInst.Name = "lbInst";
            this.lbInst.Size = new System.Drawing.Size(469, 386);
            this.lbInst.TabIndex = 3;
            this.lbInst.SelectedIndexChanged += new System.EventHandler(this.lbInst_SelectedIndexChanged);
            this.lbInst.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbInst_DragDrop);
            this.lbInst.DragOver += new System.Windows.Forms.DragEventHandler(this.lbInst_DragOver);
            this.lbInst.DoubleClick += new System.EventHandler(this.lbInst_DoubleClick);
            this.lbInst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbInst_MouseDown);
            this.lbInst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbInst_MouseMove);
            // 
            // lblModHint
            // 
            this.lblModHint.AutoSize = true;
            this.lblModHint.BackColor = System.Drawing.Color.Black;
            this.lblModHint.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModHint.ForeColor = System.Drawing.Color.White;
            this.lblModHint.Location = new System.Drawing.Point(3, 412);
            this.lblModHint.Name = "lblModHint";
            this.lblModHint.Size = new System.Drawing.Size(469, 13);
            this.lblModHint.TabIndex = 6;
            this.lblModHint.Text = "Double click a module to enable / disable it.";
            // 
            // lblModInfo
            // 
            this.lblModInfo.AutoSize = true;
            this.lblModInfo.BackColor = System.Drawing.Color.Black;
            this.lblModInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModInfo.ForeColor = System.Drawing.Color.White;
            this.lblModInfo.Location = new System.Drawing.Point(3, 412);
            this.lblModInfo.Name = "lblModInfo";
            this.lblModInfo.Size = new System.Drawing.Size(448, 13);
            this.lblModInfo.TabIndex = 7;
            this.lblModInfo.Text = "Double click a module to install / update it.";
            // 
            // splitContainerContent
            // 
            this.splitContainerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerContent.Location = new System.Drawing.Point(0, 0);
            this.splitContainerContent.Name = "splitContainerContent";
            // 
            // splitContainerContent.Panel1
            // 
            this.splitContainerContent.Panel1.Controls.Add(this.tableLayoutPanelLeft);
            // 
            // splitContainerContent.Panel2
            // 
            this.splitContainerContent.Panel2.Controls.Add(this.tableLayoutPanelRight);
            this.splitContainerContent.Size = new System.Drawing.Size(933, 472);
            this.splitContainerContent.SplitterDistance = 454;
            this.splitContainerContent.TabIndex = 9;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.Controls.Add(this.lbAvail, 0, 1);
            this.tableLayoutPanelLeft.Controls.Add(this.lblModInfo, 0, 2);
            this.tableLayoutPanelLeft.Controls.Add(this.tableLayoutPanelBottomLeft, 0, 3);
            this.tableLayoutPanelLeft.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 4;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(454, 472);
            this.tableLayoutPanelLeft.TabIndex = 0;
            // 
            // tableLayoutPanelBottomLeft
            // 
            this.tableLayoutPanelBottomLeft.ColumnCount = 2;
            this.tableLayoutPanelBottomLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottomLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottomLeft.Controls.Add(this.btnAdvanced, 0, 0);
            this.tableLayoutPanelBottomLeft.Controls.Add(this.btnUpdateAll, 0, 0);
            this.tableLayoutPanelBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottomLeft.Location = new System.Drawing.Point(3, 435);
            this.tableLayoutPanelBottomLeft.Name = "tableLayoutPanelBottomLeft";
            this.tableLayoutPanelBottomLeft.RowCount = 1;
            this.tableLayoutPanelBottomLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottomLeft.Size = new System.Drawing.Size(448, 34);
            this.tableLayoutPanelBottomLeft.TabIndex = 8;
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvanced.ForeColor = System.Drawing.Color.White;
            this.btnAdvanced.Location = new System.Drawing.Point(227, 3);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(218, 28);
            this.btnAdvanced.TabIndex = 11;
            this.btnAdvanced.Text = "List editor";
            this.btnAdvanced.UseVisualStyleBackColor = false;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateAll.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAll.Location = new System.Drawing.Point(3, 3);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(218, 28);
            this.btnUpdateAll.TabIndex = 10;
            this.btnUpdateAll.Text = "Update all installed modules";
            this.btnUpdateAll.UseVisualStyleBackColor = false;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblAvailModules, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbRefreshRepo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(448, 14);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // lblAvailModules
            // 
            this.lblAvailModules.AutoSize = true;
            this.lblAvailModules.BackColor = System.Drawing.Color.Black;
            this.lblAvailModules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAvailModules.ForeColor = System.Drawing.Color.White;
            this.lblAvailModules.Location = new System.Drawing.Point(3, 1);
            this.lblAvailModules.Name = "lblAvailModules";
            this.lblAvailModules.Size = new System.Drawing.Size(392, 13);
            this.lblAvailModules.TabIndex = 1;
            this.lblAvailModules.Text = "Available modules:";
            // 
            // pbRefreshRepo
            // 
            this.pbRefreshRepo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRefreshRepo.Image = global::LPLauncher.Properties.Resources.arrow_refresh_small;
            this.pbRefreshRepo.Location = new System.Drawing.Point(398, 0);
            this.pbRefreshRepo.Margin = new System.Windows.Forms.Padding(0);
            this.pbRefreshRepo.Name = "pbRefreshRepo";
            this.pbRefreshRepo.Size = new System.Drawing.Size(50, 14);
            this.pbRefreshRepo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRefreshRepo.TabIndex = 2;
            this.pbRefreshRepo.TabStop = false;
            this.pbRefreshRepo.Click += new System.EventHandler(this.pbRefreshRepo_Click);
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.ColumnCount = 1;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.Controls.Add(this.lbInst, 0, 1);
            this.tableLayoutPanelRight.Controls.Add(this.lblModHint, 0, 2);
            this.tableLayoutPanelRight.Controls.Add(this.tableLayoutPanelBottomRight, 0, 3);
            this.tableLayoutPanelRight.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 4;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(475, 472);
            this.tableLayoutPanelRight.TabIndex = 1;
            // 
            // tableLayoutPanelBottomRight
            // 
            this.tableLayoutPanelBottomRight.ColumnCount = 2;
            this.tableLayoutPanelBottomRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottomRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottomRight.Controls.Add(this.btnLaunch, 0, 0);
            this.tableLayoutPanelBottomRight.Controls.Add(this.btnDelMod, 0, 0);
            this.tableLayoutPanelBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottomRight.Location = new System.Drawing.Point(3, 435);
            this.tableLayoutPanelBottomRight.Name = "tableLayoutPanelBottomRight";
            this.tableLayoutPanelBottomRight.RowCount = 1;
            this.tableLayoutPanelBottomRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottomRight.Size = new System.Drawing.Size(469, 34);
            this.tableLayoutPanelBottomRight.TabIndex = 7;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Green;
            this.btnLaunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLaunch.ForeColor = System.Drawing.Color.White;
            this.btnLaunch.Location = new System.Drawing.Point(237, 3);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(229, 28);
            this.btnLaunch.TabIndex = 10;
            this.btnLaunch.Text = "Launch game";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnDelMod
            // 
            this.btnDelMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelMod.ForeColor = System.Drawing.Color.White;
            this.btnDelMod.Location = new System.Drawing.Point(3, 3);
            this.btnDelMod.Name = "btnDelMod";
            this.btnDelMod.Size = new System.Drawing.Size(228, 28);
            this.btnDelMod.TabIndex = 9;
            this.btnDelMod.Text = "Delete selected moule";
            this.btnDelMod.UseVisualStyleBackColor = false;
            this.btnDelMod.Click += new System.EventHandler(this.btnDelMod_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblInstalledModules, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbRefreshLocal, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 14);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblInstalledModules
            // 
            this.lblInstalledModules.AutoSize = true;
            this.lblInstalledModules.BackColor = System.Drawing.Color.Black;
            this.lblInstalledModules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInstalledModules.ForeColor = System.Drawing.Color.White;
            this.lblInstalledModules.Location = new System.Drawing.Point(3, 1);
            this.lblInstalledModules.Name = "lblInstalledModules";
            this.lblInstalledModules.Size = new System.Drawing.Size(413, 13);
            this.lblInstalledModules.TabIndex = 2;
            this.lblInstalledModules.Text = "Installed modules:";
            // 
            // pbRefreshLocal
            // 
            this.pbRefreshLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRefreshLocal.Image = global::LPLauncher.Properties.Resources.arrow_refresh_small;
            this.pbRefreshLocal.Location = new System.Drawing.Point(419, 0);
            this.pbRefreshLocal.Margin = new System.Windows.Forms.Padding(0);
            this.pbRefreshLocal.Name = "pbRefreshLocal";
            this.pbRefreshLocal.Size = new System.Drawing.Size(50, 14);
            this.pbRefreshLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRefreshLocal.TabIndex = 3;
            this.pbRefreshLocal.TabStop = false;
            this.pbRefreshLocal.Click += new System.EventHandler(this.pbRefreshLocal_Click);
            // 
            // splitContainerHeader
            // 
            this.splitContainerHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHeader.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerHeader.IsSplitterFixed = true;
            this.splitContainerHeader.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHeader.Name = "splitContainerHeader";
            this.splitContainerHeader.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHeader.Panel1
            // 
            this.splitContainerHeader.Panel1.Controls.Add(this.lblLPVersion);
            this.splitContainerHeader.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainerHeader.Panel1MinSize = 120;
            // 
            // splitContainerHeader.Panel2
            // 
            this.splitContainerHeader.Panel2.Controls.Add(this.splitContainerContent);
            this.splitContainerHeader.Size = new System.Drawing.Size(933, 596);
            this.splitContainerHeader.SplitterDistance = 120;
            this.splitContainerHeader.TabIndex = 10;
            // 
            // lblLPVersion
            // 
            this.lblLPVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblLPVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLPVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblLPVersion.Location = new System.Drawing.Point(864, 0);
            this.lblLPVersion.Name = "lblLPVersion";
            this.lblLPVersion.Size = new System.Drawing.Size(69, 120);
            this.lblLPVersion.TabIndex = 1;
            this.lblLPVersion.Text = "Version X.XX";
            this.lblLPVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LPLauncher.Properties.Resources.header;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmAdvanced
            // 
            this.cmAdvanced.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editLifePlayNameListsToolStripMenuItem,
            this.editLifePlaysportsOutfitsToolStripMenuItem,
            this.editLifePlayworkOutfitsToolStripMenuItem,
            this.editLifePlaycasualOutfitsToolStripMenuItem});
            this.cmAdvanced.Name = "cmAdvanced";
            this.cmAdvanced.Size = new System.Drawing.Size(212, 114);
            this.cmAdvanced.Opening += new System.ComponentModel.CancelEventHandler(this.cmAdvanced_Opening);
            // 
            // editLifePlayNameListsToolStripMenuItem
            // 
            this.editLifePlayNameListsToolStripMenuItem.Name = "editLifePlayNameListsToolStripMenuItem";
            this.editLifePlayNameListsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.editLifePlayNameListsToolStripMenuItem.Text = "Edit LifePlay &name lists";
            this.editLifePlayNameListsToolStripMenuItem.Click += new System.EventHandler(this.editLifePlayNameListsToolStripMenuItem_Click);
            // 
            // editLifePlaysportsOutfitsToolStripMenuItem
            // 
            this.editLifePlaysportsOutfitsToolStripMenuItem.Name = "editLifePlaysportsOutfitsToolStripMenuItem";
            this.editLifePlaysportsOutfitsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.editLifePlaysportsOutfitsToolStripMenuItem.Text = "Edit LifePlay &sports outfits";
            this.editLifePlaysportsOutfitsToolStripMenuItem.Click += new System.EventHandler(this.editLifePlaysportsOutfitsToolStripMenuItem_Click);
            // 
            // editLifePlayworkOutfitsToolStripMenuItem
            // 
            this.editLifePlayworkOutfitsToolStripMenuItem.Name = "editLifePlayworkOutfitsToolStripMenuItem";
            this.editLifePlayworkOutfitsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.editLifePlayworkOutfitsToolStripMenuItem.Text = "Edit LifePlay &work outfits";
            this.editLifePlayworkOutfitsToolStripMenuItem.Click += new System.EventHandler(this.editLifePlayworkOutfitsToolStripMenuItem_Click);
            // 
            // editLifePlaycasualOutfitsToolStripMenuItem
            // 
            this.editLifePlaycasualOutfitsToolStripMenuItem.Name = "editLifePlaycasualOutfitsToolStripMenuItem";
            this.editLifePlaycasualOutfitsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.editLifePlaycasualOutfitsToolStripMenuItem.Text = "Edit LifePlay &casual outfits";
            this.editLifePlaycasualOutfitsToolStripMenuItem.Click += new System.EventHandler(this.editLifePlaycasualOutfitsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(933, 596);
            this.Controls.Add(this.splitContainerHeader);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LifePlay ModManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerContent.Panel1.ResumeLayout(false);
            this.splitContainerContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).EndInit();
            this.splitContainerContent.ResumeLayout(false);
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.tableLayoutPanelLeft.PerformLayout();
            this.tableLayoutPanelBottomLeft.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefreshRepo)).EndInit();
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.tableLayoutPanelRight.PerformLayout();
            this.tableLayoutPanelBottomRight.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefreshLocal)).EndInit();
            this.splitContainerHeader.Panel1.ResumeLayout(false);
            this.splitContainerHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).EndInit();
            this.splitContainerHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmAdvanced.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAvail;
        private System.Windows.Forms.ListBox lbInst;
        private System.Windows.Forms.Label lblModHint;
        private System.Windows.Forms.Label lblModInfo;
        private System.Windows.Forms.SplitContainer splitContainerContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
        private System.Windows.Forms.SplitContainer splitContainerHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottomLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottomRight;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnDelMod;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAvailModules;
        private System.Windows.Forms.PictureBox pbRefreshRepo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblInstalledModules;
        private System.Windows.Forms.PictureBox pbRefreshLocal;
        private System.Windows.Forms.Label lblLPVersion;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.ContextMenuStrip cmAdvanced;
        private System.Windows.Forms.ToolStripMenuItem editLifePlayNameListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLifePlaysportsOutfitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLifePlayworkOutfitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLifePlaycasualOutfitsToolStripMenuItem;
    }
}

