namespace GTSWinF_v2
{
    partial class frmThesis
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
            this.btonClose = new System.Windows.Forms.Button();
            this.tboxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxSummary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlsThesisType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlsUniversity = new System.Windows.Forms.ComboBox();
            this.ddlsInstitute = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nuudPageCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btonSend = new System.Windows.Forms.Button();
            this.ddlsAuthor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlsLanguage = new System.Windows.Forms.ComboBox();
            this.ddlsAdvisor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ddlsPAdvisor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuudPageCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Location = new System.Drawing.Point(299, 545);
            this.btonClose.Margin = new System.Windows.Forms.Padding(4);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(88, 30);
            this.btonClose.TabIndex = 0;
            this.btonClose.Text = "Close";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // tboxTitle
            // 
            this.tboxTitle.Location = new System.Drawing.Point(95, 19);
            this.tboxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tboxTitle.Multiline = true;
            this.tboxTitle.Name = "tboxTitle";
            this.tboxTitle.Size = new System.Drawing.Size(289, 68);
            this.tboxTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // tboxSummary
            // 
            this.tboxSummary.Location = new System.Drawing.Point(95, 95);
            this.tboxSummary.Margin = new System.Windows.Forms.Padding(4);
            this.tboxSummary.Multiline = true;
            this.tboxSummary.Name = "tboxSummary";
            this.tboxSummary.Size = new System.Drawing.Size(289, 126);
            this.tboxSummary.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Summary";
            // 
            // ddlsThesisType
            // 
            this.ddlsThesisType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsThesisType.FormattingEnabled = true;
            this.ddlsThesisType.Location = new System.Drawing.Point(95, 262);
            this.ddlsThesisType.Margin = new System.Windows.Forms.Padding(4);
            this.ddlsThesisType.Name = "ddlsThesisType";
            this.ddlsThesisType.Size = new System.Drawing.Size(236, 25);
            this.ddlsThesisType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            // 
            // ddlsUniversity
            // 
            this.ddlsUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsUniversity.FormattingEnabled = true;
            this.ddlsUniversity.Location = new System.Drawing.Point(95, 295);
            this.ddlsUniversity.Margin = new System.Windows.Forms.Padding(4);
            this.ddlsUniversity.Name = "ddlsUniversity";
            this.ddlsUniversity.Size = new System.Drawing.Size(236, 25);
            this.ddlsUniversity.TabIndex = 7;
            this.ddlsUniversity.SelectedIndexChanged += new System.EventHandler(this.ddlsUniversity_SelectedIndexChanged);
            // 
            // ddlsInstitute
            // 
            this.ddlsInstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsInstitute.FormattingEnabled = true;
            this.ddlsInstitute.Location = new System.Drawing.Point(95, 328);
            this.ddlsInstitute.Margin = new System.Windows.Forms.Padding(4);
            this.ddlsInstitute.Name = "ddlsInstitute";
            this.ddlsInstitute.Size = new System.Drawing.Size(236, 25);
            this.ddlsInstitute.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "University";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Institute";
            // 
            // nuudPageCount
            // 
            this.nuudPageCount.Location = new System.Drawing.Point(95, 361);
            this.nuudPageCount.Margin = new System.Windows.Forms.Padding(4);
            this.nuudPageCount.Name = "nuudPageCount";
            this.nuudPageCount.Size = new System.Drawing.Size(74, 25);
            this.nuudPageCount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 361);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Page Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 394);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Language";
            // 
            // btonSend
            // 
            this.btonSend.Location = new System.Drawing.Point(95, 514);
            this.btonSend.Margin = new System.Windows.Forms.Padding(4);
            this.btonSend.Name = "btonSend";
            this.btonSend.Size = new System.Drawing.Size(88, 30);
            this.btonSend.TabIndex = 16;
            this.btonSend.Text = "Send";
            this.btonSend.UseVisualStyleBackColor = true;
            this.btonSend.Click += new System.EventHandler(this.btonSend_Click);
            // 
            // ddlsAuthor
            // 
            this.ddlsAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsAuthor.FormattingEnabled = true;
            this.ddlsAuthor.Location = new System.Drawing.Point(95, 229);
            this.ddlsAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.ddlsAuthor.Name = "ddlsAuthor";
            this.ddlsAuthor.Size = new System.Drawing.Size(236, 25);
            this.ddlsAuthor.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Author";
            // 
            // ddlsLanguage
            // 
            this.ddlsLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsLanguage.FormattingEnabled = true;
            this.ddlsLanguage.Location = new System.Drawing.Point(95, 394);
            this.ddlsLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.ddlsLanguage.Name = "ddlsLanguage";
            this.ddlsLanguage.Size = new System.Drawing.Size(236, 25);
            this.ddlsLanguage.TabIndex = 19;
            // 
            // ddlsAdvisor
            // 
            this.ddlsAdvisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsAdvisor.FormattingEnabled = true;
            this.ddlsAdvisor.Location = new System.Drawing.Point(95, 427);
            this.ddlsAdvisor.Margin = new System.Windows.Forms.Padding(4);
            this.ddlsAdvisor.Name = "ddlsAdvisor";
            this.ddlsAdvisor.Size = new System.Drawing.Size(236, 25);
            this.ddlsAdvisor.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 427);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Advisor";
            // 
            // ddlsPAdvisor
            // 
            this.ddlsPAdvisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsPAdvisor.FormattingEnabled = true;
            this.ddlsPAdvisor.Location = new System.Drawing.Point(95, 460);
            this.ddlsPAdvisor.Margin = new System.Windows.Forms.Padding(4);
            this.ddlsPAdvisor.Name = "ddlsPAdvisor";
            this.ddlsPAdvisor.Size = new System.Drawing.Size(236, 25);
            this.ddlsPAdvisor.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 460);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "PAdvisor";
            // 
            // frmThesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 588);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ddlsPAdvisor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ddlsAdvisor);
            this.Controls.Add(this.ddlsLanguage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ddlsAuthor);
            this.Controls.Add(this.btonSend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nuudPageCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddlsInstitute);
            this.Controls.Add(this.ddlsUniversity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlsThesisType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxTitle);
            this.Controls.Add(this.btonClose);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThesis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graduate Thesis System v2.0 - New Thesis";
            this.Load += new System.EventHandler(this.frmThesis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuudPageCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.TextBox tboxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlsThesisType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlsUniversity;
        private System.Windows.Forms.ComboBox ddlsInstitute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nuudPageCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btonSend;
        private System.Windows.Forms.ComboBox ddlsAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlsLanguage;
        private System.Windows.Forms.ComboBox ddlsAdvisor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddlsPAdvisor;
        private System.Windows.Forms.Label label10;
    }
}