namespace LPLauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAvail = new System.Windows.Forms.ListBox();
            this.lbInst = new System.Windows.Forms.ListBox();
            this.lblModHint = new System.Windows.Forms.Label();
            this.lblModInfo = new System.Windows.Forms.Label();
            this.splitContainerContent = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottomLeft = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottomRight = new System.Windows.Forms.TableLayoutPanel();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnDelMod = new System.Windows.Forms.Button();
            this.splitContainerHeader = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).BeginInit();
            this.splitContainerContent.Panel1.SuspendLayout();
            this.splitContainerContent.Panel2.SuspendLayout();
            this.splitContainerContent.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelBottomLeft.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            this.tableLayoutPanelBottomRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).BeginInit();
            this.splitContainerHeader.Panel1.SuspendLayout();
            this.splitContainerHeader.Panel2.SuspendLayout();
            this.splitContainerHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available modules:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Installed modules:";
            // 
            // lbAvail
            // 
            this.lbAvail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAvail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAvail.ForeColor = System.Drawing.Color.White;
            this.lbAvail.FormattingEnabled = true;
            this.lbAvail.Location = new System.Drawing.Point(3, 23);
            this.lbAvail.Name = "lbAvail";
            this.lbAvail.Size = new System.Drawing.Size(448, 386);
            this.lbAvail.TabIndex = 2;
            this.lbAvail.SelectedIndexChanged += new System.EventHandler(this.lbAvail_SelectedIndexChanged);
            this.lbAvail.DoubleClick += new System.EventHandler(this.lbAvail_DoubleClick);
            // 
            // lbInst
            // 
            this.lbInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbInst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInst.ForeColor = System.Drawing.Color.White;
            this.lbInst.FormattingEnabled = true;
            this.lbInst.Location = new System.Drawing.Point(3, 23);
            this.lbInst.Name = "lbInst";
            this.lbInst.Size = new System.Drawing.Size(469, 386);
            this.lbInst.Sorted = true;
            this.lbInst.TabIndex = 3;
            this.lbInst.SelectedIndexChanged += new System.EventHandler(this.lbInst_SelectedIndexChanged);
            this.lbInst.DoubleClick += new System.EventHandler(this.lbInst_DoubleClick);
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
            this.tableLayoutPanelLeft.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelLeft.Controls.Add(this.lbAvail, 0, 1);
            this.tableLayoutPanelLeft.Controls.Add(this.lblModInfo, 0, 2);
            this.tableLayoutPanelLeft.Controls.Add(this.tableLayoutPanelBottomLeft, 0, 3);
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
            this.tableLayoutPanelBottomLeft.Controls.Add(this.btnUpdateAll, 0, 0);
            this.tableLayoutPanelBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottomLeft.Location = new System.Drawing.Point(3, 435);
            this.tableLayoutPanelBottomLeft.Name = "tableLayoutPanelBottomLeft";
            this.tableLayoutPanelBottomLeft.RowCount = 1;
            this.tableLayoutPanelBottomLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottomLeft.Size = new System.Drawing.Size(448, 34);
            this.tableLayoutPanelBottomLeft.TabIndex = 8;
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
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.ColumnCount = 1;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanelRight.Controls.Add(this.lbInst, 0, 1);
            this.tableLayoutPanelRight.Controls.Add(this.lblModHint, 0, 2);
            this.tableLayoutPanelRight.Controls.Add(this.tableLayoutPanelBottomRight, 0, 3);
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
            this.btnLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LPLauncher.Properties.Resources.header;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(933, 596);
            this.Controls.Add(this.splitContainerHeader);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LifePlay ModManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerContent.Panel1.ResumeLayout(false);
            this.splitContainerContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).EndInit();
            this.splitContainerContent.ResumeLayout(false);
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.tableLayoutPanelLeft.PerformLayout();
            this.tableLayoutPanelBottomLeft.ResumeLayout(false);
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.tableLayoutPanelRight.PerformLayout();
            this.tableLayoutPanelBottomRight.ResumeLayout(false);
            this.splitContainerHeader.Panel1.ResumeLayout(false);
            this.splitContainerHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).EndInit();
            this.splitContainerHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
    }
}

