namespace SpringDesk
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxTaskList = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxSpAuth = new System.Windows.Forms.GroupBox();
            this.linkLabelAuth = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxWorkbook = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxTaskList.SuspendLayout();
            this.groupBoxSpAuth.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 64);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 298);
            this.panel2.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(494, 298);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxTaskList);
            this.tabPage1.Controls.Add(this.groupBoxSpAuth);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxTaskList
            // 
            this.groupBoxTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTaskList.Controls.Add(this.label2);
            this.groupBoxTaskList.Controls.Add(this.comboBoxWorkbook);
            this.groupBoxTaskList.Controls.Add(this.buttonRefresh);
            this.groupBoxTaskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTaskList.Location = new System.Drawing.Point(8, 91);
            this.groupBoxTaskList.Name = "groupBoxTaskList";
            this.groupBoxTaskList.Size = new System.Drawing.Size(470, 173);
            this.groupBoxTaskList.TabIndex = 4;
            this.groupBoxTaskList.TabStop = false;
            this.groupBoxTaskList.Text = "Task List Setting";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(388, 137);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(76, 30);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBoxSpAuth
            // 
            this.groupBoxSpAuth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSpAuth.Controls.Add(this.linkLabelAuth);
            this.groupBoxSpAuth.Controls.Add(this.label1);
            this.groupBoxSpAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSpAuth.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSpAuth.Name = "groupBoxSpAuth";
            this.groupBoxSpAuth.Size = new System.Drawing.Size(470, 79);
            this.groupBoxSpAuth.TabIndex = 3;
            this.groupBoxSpAuth.TabStop = false;
            this.groupBoxSpAuth.Text = "Springpad Authorization";
            // 
            // linkLabelAuth
            // 
            this.linkLabelAuth.AutoSize = true;
            this.linkLabelAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAuth.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelAuth.Location = new System.Drawing.Point(159, 32);
            this.linkLabelAuth.Name = "linkLabelAuth";
            this.linkLabelAuth.Size = new System.Drawing.Size(105, 16);
            this.linkLabelAuth.TabIndex = 4;
            this.linkLabelAuth.TabStop = true;
            this.linkLabelAuth.Text = "Un-Authorized";
            this.linkLabelAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAuth_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Authorization Status :";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About Springdesk";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Right click to access Springdesk menu";
            this.notifyIcon.Text = "Springdesk Notification";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemConfigure});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 26);
            // 
            // toolStripMenuItemConfigure
            // 
            this.toolStripMenuItemConfigure.Name = "toolStripMenuItemConfigure";
            this.toolStripMenuItemConfigure.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemConfigure.Text = "Configuration";
            // 
            // comboBoxWorkbook
            // 
            this.comboBoxWorkbook.FormattingEnabled = true;
            this.comboBoxWorkbook.Location = new System.Drawing.Point(162, 39);
            this.comboBoxWorkbook.Name = "comboBoxWorkbook";
            this.comboBoxWorkbook.Size = new System.Drawing.Size(283, 21);
            this.comboBoxWorkbook.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notebook :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "SpringDesk";
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxTaskList.ResumeLayout(false);
            this.groupBoxTaskList.PerformLayout();
            this.groupBoxSpAuth.ResumeLayout(false);
            this.groupBoxSpAuth.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConfigure;
        private System.Windows.Forms.GroupBox groupBoxSpAuth;
        private System.Windows.Forms.LinkLabel linkLabelAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTaskList;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxWorkbook;
    }
}

