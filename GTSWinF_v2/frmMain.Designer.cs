namespace GTSWinF_v2
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
            this.btonExit = new System.Windows.Forms.Button();
            this.menuGTS = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thesisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonExit.Location = new System.Drawing.Point(714, 404);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(74, 34);
            this.btonExit.TabIndex = 0;
            this.btonExit.Text = "Exit";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // menuGTS
            // 
            this.menuGTS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuGTS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuGTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.thesisToolStripMenuItem});
            this.menuGTS.Location = new System.Drawing.Point(0, 0);
            this.menuGTS.Name = "menuGTS";
            this.menuGTS.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuGTS.Size = new System.Drawing.Size(800, 27);
            this.menuGTS.TabIndex = 1;
            this.menuGTS.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.exitToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(99, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.universityToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // thesisToolStripMenuItem
            // 
            this.thesisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.queryToolStripMenuItem});
            this.thesisToolStripMenuItem.Name = "thesisToolStripMenuItem";
            this.thesisToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.thesisToolStripMenuItem.Text = "Thesis";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // universityToolStripMenuItem
            // 
            this.universityToolStripMenuItem.Name = "universityToolStripMenuItem";
            this.universityToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.universityToolStripMenuItem.Text = "University";
            this.universityToolStripMenuItem.Click += new System.EventHandler(this.universityToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btonExit);
            this.Controls.Add(this.menuGTS);
            this.MainMenuStrip = this.menuGTS;
            this.Name = "frmMain";
            this.Text = "Graduate Thesis System v2.0 - Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuGTS.ResumeLayout(false);
            this.menuGTS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thesisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universityToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuGTS;
    }
}