namespace hobson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFolders = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabTrash = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabFolders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFolders);
            this.tabControl1.Controls.Add(this.tabTrash);
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 922);
            this.tabControl1.TabIndex = 0;
            // 
            // tabFolders
            // 
            this.tabFolders.Controls.Add(this.groupBox1);
            this.tabFolders.Location = new System.Drawing.Point(8, 39);
            this.tabFolders.Name = "tabFolders";
            this.tabFolders.Padding = new System.Windows.Forms.Padding(3);
            this.tabFolders.Size = new System.Drawing.Size(1246, 875);
            this.tabFolders.TabIndex = 0;
            this.tabFolders.Text = "Folders";
            this.tabFolders.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(27, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 716);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folders";
            // 
            // tabTrash
            // 
            this.tabTrash.Location = new System.Drawing.Point(8, 39);
            this.tabTrash.Name = "tabTrash";
            this.tabTrash.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrash.Size = new System.Drawing.Size(1246, 875);
            this.tabTrash.TabIndex = 1;
            this.tabTrash.Text = "Trash";
            this.tabTrash.UseVisualStyleBackColor = true;
            // 
            // tabInfo
            // 
            this.tabInfo.Location = new System.Drawing.Point(8, 39);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(1246, 875);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 981);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Hobson";
            this.tabControl1.ResumeLayout(false);
            this.tabFolders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFolders;
        private System.Windows.Forms.TabPage tabTrash;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}