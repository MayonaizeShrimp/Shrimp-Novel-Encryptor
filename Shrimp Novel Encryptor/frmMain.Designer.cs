namespace Shrimp_Novel_Encryptor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stripMenuMain = new System.Windows.Forms.MenuStrip();
            this.menuGeneralMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChoose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowKey = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarMain = new System.Windows.Forms.StatusStrip();
            this.lblEncryptType = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProgressBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.btnClearLeft = new System.Windows.Forms.Button();
            this.txtInputLeft = new System.Windows.Forms.TextBox();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnCopyToClipboardLeft = new System.Windows.Forms.Button();
            this.btnClearRight = new System.Windows.Forms.Button();
            this.txtInputRight = new System.Windows.Forms.TextBox();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnCopyToClipboardRight = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuMain.SuspendLayout();
            this.statusBarMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripMenuMain
            // 
            this.stripMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGeneralMain,
            this.menuShowKey,
            this.mnuAbout,
            this.mnuHelp});
            this.stripMenuMain.Location = new System.Drawing.Point(0, 0);
            this.stripMenuMain.Name = "stripMenuMain";
            this.stripMenuMain.Size = new System.Drawing.Size(384, 24);
            this.stripMenuMain.TabIndex = 0;
            this.stripMenuMain.Text = "menuStrip1";
            // 
            // menuGeneralMain
            // 
            this.menuGeneralMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuChoose,
            this.menuExit});
            this.menuGeneralMain.Name = "menuGeneralMain";
            this.menuGeneralMain.Size = new System.Drawing.Size(37, 20);
            this.menuGeneralMain.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(144, 22);
            this.menuNew.Text = "New Pattern";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuChoose
            // 
            this.menuChoose.Name = "menuChoose";
            this.menuChoose.Size = new System.Drawing.Size(144, 22);
            this.menuChoose.Text = "Open Pattern";
            this.menuChoose.Click += new System.EventHandler(this.menuCreateCrypt_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(144, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuShowKey
            // 
            this.menuShowKey.Name = "menuShowKey";
            this.menuShowKey.Size = new System.Drawing.Size(89, 20);
            this.menuShowKey.Text = "Show Pattern";
            this.menuShowKey.Click += new System.EventHandler(this.menuShowKey_Click);
            // 
            // statusBarMain
            // 
            this.statusBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEncryptType,
            this.lblProgressBar});
            this.statusBarMain.Location = new System.Drawing.Point(0, 239);
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.Size = new System.Drawing.Size(384, 22);
            this.statusBarMain.TabIndex = 1;
            this.statusBarMain.Text = "statusStrip1";
            // 
            // lblEncryptType
            // 
            this.lblEncryptType.Name = "lblEncryptType";
            this.lblEncryptType.Size = new System.Drawing.Size(94, 17);
            this.lblEncryptType.Text = "Enc Type: NONE";
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.btnClearLeft);
            this.splitContainerMain.Panel1.Controls.Add(this.txtInputLeft);
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.btnClearRight);
            this.splitContainerMain.Panel2.Controls.Add(this.txtInputRight);
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerRight);
            this.splitContainerMain.Size = new System.Drawing.Size(384, 215);
            this.splitContainerMain.SplitterDistance = 192;
            this.splitContainerMain.TabIndex = 2;
            // 
            // btnClearLeft
            // 
            this.btnClearLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearLeft.Location = new System.Drawing.Point(0, 192);
            this.btnClearLeft.Name = "btnClearLeft";
            this.btnClearLeft.Size = new System.Drawing.Size(192, 23);
            this.btnClearLeft.TabIndex = 2;
            this.btnClearLeft.Text = "Clear";
            this.btnClearLeft.UseVisualStyleBackColor = true;
            this.btnClearLeft.Click += new System.EventHandler(this.btnClearLeft_Click);
            // 
            // txtInputLeft
            // 
            this.txtInputLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputLeft.Location = new System.Drawing.Point(0, 31);
            this.txtInputLeft.Multiline = true;
            this.txtInputLeft.Name = "txtInputLeft";
            this.txtInputLeft.Size = new System.Drawing.Size(192, 184);
            this.txtInputLeft.TabIndex = 1;
            this.txtInputLeft.Text = "(Insert the original text here)";
            this.txtInputLeft.Click += new System.EventHandler(this.txtInputLeft_Click);
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.btnEncrypt);
            this.splitContainerLeft.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.btnCopyToClipboardLeft);
            this.splitContainerLeft.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerLeft.Size = new System.Drawing.Size(192, 31);
            this.splitContainerLeft.SplitterDistance = 95;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEncrypt.Location = new System.Drawing.Point(0, 0);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(95, 31);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnCopyToClipboardLeft
            // 
            this.btnCopyToClipboardLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyToClipboardLeft.Location = new System.Drawing.Point(0, 0);
            this.btnCopyToClipboardLeft.Name = "btnCopyToClipboardLeft";
            this.btnCopyToClipboardLeft.Size = new System.Drawing.Size(93, 31);
            this.btnCopyToClipboardLeft.TabIndex = 0;
            this.btnCopyToClipboardLeft.Text = "Clipboard";
            this.btnCopyToClipboardLeft.UseVisualStyleBackColor = true;
            this.btnCopyToClipboardLeft.Click += new System.EventHandler(this.btnCopyToClipboardLeft_Click);
            // 
            // btnClearRight
            // 
            this.btnClearRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearRight.Location = new System.Drawing.Point(0, 192);
            this.btnClearRight.Name = "btnClearRight";
            this.btnClearRight.Size = new System.Drawing.Size(188, 23);
            this.btnClearRight.TabIndex = 3;
            this.btnClearRight.Text = "Clear";
            this.btnClearRight.UseVisualStyleBackColor = true;
            this.btnClearRight.Click += new System.EventHandler(this.btnClearRight_Click);
            // 
            // txtInputRight
            // 
            this.txtInputRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputRight.Location = new System.Drawing.Point(0, 31);
            this.txtInputRight.Multiline = true;
            this.txtInputRight.Name = "txtInputRight";
            this.txtInputRight.Size = new System.Drawing.Size(188, 184);
            this.txtInputRight.TabIndex = 2;
            this.txtInputRight.Text = "(Insert the encrypted text here)";
            this.txtInputRight.Click += new System.EventHandler(this.txtInputRight_Click);
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.btnDecrypt);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.btnCopyToClipboardRight);
            this.splitContainerRight.Size = new System.Drawing.Size(188, 31);
            this.splitContainerRight.SplitterDistance = 93;
            this.splitContainerRight.TabIndex = 0;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecrypt.Location = new System.Drawing.Point(0, 0);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(93, 31);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnCopyToClipboardRight
            // 
            this.btnCopyToClipboardRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyToClipboardRight.Location = new System.Drawing.Point(0, 0);
            this.btnCopyToClipboardRight.Name = "btnCopyToClipboardRight";
            this.btnCopyToClipboardRight.Size = new System.Drawing.Size(91, 31);
            this.btnCopyToClipboardRight.TabIndex = 1;
            this.btnCopyToClipboardRight.Text = "Clipboard";
            this.btnCopyToClipboardRight.UseVisualStyleBackColor = true;
            this.btnCopyToClipboardRight.Click += new System.EventHandler(this.btnCopyToClipboardRight_Click);
            // 
            // openFile
            // 
            this.openFile.Filter = "Text File|*.dat";
            this.openFile.Title = "Open Pattern File";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusBarMain);
            this.Controls.Add(this.stripMenuMain);
            this.MainMenuStrip = this.stripMenuMain;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApplicationName + VersionNum";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.stripMenuMain.ResumeLayout(false);
            this.stripMenuMain.PerformLayout();
            this.statusBarMain.ResumeLayout(false);
            this.statusBarMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip stripMenuMain;
        private System.Windows.Forms.ToolStripMenuItem menuGeneralMain;
        private System.Windows.Forms.StatusStrip statusBarMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TextBox txtInputLeft;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnCopyToClipboardLeft;
        private System.Windows.Forms.TextBox txtInputRight;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnCopyToClipboardRight;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Button btnClearLeft;
        private System.Windows.Forms.Button btnClearRight;
        private System.Windows.Forms.ToolStripMenuItem menuChoose;
        private System.Windows.Forms.ToolStripStatusLabel lblEncryptType;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ToolStripMenuItem menuShowKey;
        private System.Windows.Forms.ToolStripStatusLabel lblProgressBar;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
    }
}

