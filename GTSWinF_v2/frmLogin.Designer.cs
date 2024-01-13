namespace GTSWinF_v2
{
    partial class frmLogin
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
            this.tboxUserName = new System.Windows.Forms.TextBox();
            this.tboxUserPassw = new System.Windows.Forms.TextBox();
            this.btonLogin = new System.Windows.Forms.Button();
            this.btonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxUserName
            // 
            this.tboxUserName.Location = new System.Drawing.Point(130, 29);
            this.tboxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.Size = new System.Drawing.Size(116, 25);
            this.tboxUserName.TabIndex = 0;
            // 
            // tboxUserPassw
            // 
            this.tboxUserPassw.Location = new System.Drawing.Point(130, 65);
            this.tboxUserPassw.Margin = new System.Windows.Forms.Padding(4);
            this.tboxUserPassw.Name = "tboxUserPassw";
            this.tboxUserPassw.PasswordChar = '*';
            this.tboxUserPassw.Size = new System.Drawing.Size(116, 25);
            this.tboxUserPassw.TabIndex = 1;
            // 
            // btonLogin
            // 
            this.btonLogin.Location = new System.Drawing.Point(130, 112);
            this.btonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btonLogin.Name = "btonLogin";
            this.btonLogin.Size = new System.Drawing.Size(88, 30);
            this.btonLogin.TabIndex = 2;
            this.btonLogin.Text = "Login";
            this.btonLogin.UseVisualStyleBackColor = true;
            this.btonLogin.Click += new System.EventHandler(this.btonLogin_Click);
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(180, 169);
            this.btonExit.Margin = new System.Windows.Forms.Padding(4);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(88, 30);
            this.btonExit.TabIndex = 3;
            this.btonExit.Text = "Exit";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Password";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 215);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonExit);
            this.Controls.Add(this.btonLogin);
            this.Controls.Add(this.tboxUserPassw);
            this.Controls.Add(this.tboxUserName);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graduate Thesis System v2.0 - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.TextBox tboxUserPassw;
        private System.Windows.Forms.Button btonLogin;
        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}