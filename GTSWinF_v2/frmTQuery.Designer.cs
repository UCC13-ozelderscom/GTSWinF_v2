namespace GTSWinF_v2
{
    partial class frmTQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btonClose = new System.Windows.Forms.Button();
            this.grpbQueryOptions = new System.Windows.Forms.GroupBox();
            this.ddlsYearEnd = new System.Windows.Forms.ComboBox();
            this.btonRunQuery = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlsAdvisor = new System.Windows.Forms.ComboBox();
            this.tboxThesisNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlsLanguage = new System.Windows.Forms.ComboBox();
            this.ddlsYearBegin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlsAuthor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlsThesisType = new System.Windows.Forms.ComboBox();
            this.ddlsInstitute = new System.Windows.Forms.ComboBox();
            this.ddlsUniversity = new System.Windows.Forms.ComboBox();
            this.dgrdThesis = new System.Windows.Forms.DataGridView();
            this.grpbQueryOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdThesis)).BeginInit();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonClose.Location = new System.Drawing.Point(1164, 657);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(75, 37);
            this.btonClose.TabIndex = 0;
            this.btonClose.Text = "Close";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // grpbQueryOptions
            // 
            this.grpbQueryOptions.Controls.Add(this.ddlsYearEnd);
            this.grpbQueryOptions.Controls.Add(this.btonRunQuery);
            this.grpbQueryOptions.Controls.Add(this.label8);
            this.grpbQueryOptions.Controls.Add(this.ddlsAdvisor);
            this.grpbQueryOptions.Controls.Add(this.tboxThesisNo);
            this.grpbQueryOptions.Controls.Add(this.label7);
            this.grpbQueryOptions.Controls.Add(this.label6);
            this.grpbQueryOptions.Controls.Add(this.ddlsLanguage);
            this.grpbQueryOptions.Controls.Add(this.ddlsYearBegin);
            this.grpbQueryOptions.Controls.Add(this.label5);
            this.grpbQueryOptions.Controls.Add(this.ddlsAuthor);
            this.grpbQueryOptions.Controls.Add(this.label4);
            this.grpbQueryOptions.Controls.Add(this.label3);
            this.grpbQueryOptions.Controls.Add(this.label2);
            this.grpbQueryOptions.Controls.Add(this.label1);
            this.grpbQueryOptions.Controls.Add(this.ddlsThesisType);
            this.grpbQueryOptions.Controls.Add(this.ddlsInstitute);
            this.grpbQueryOptions.Controls.Add(this.ddlsUniversity);
            this.grpbQueryOptions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbQueryOptions.Location = new System.Drawing.Point(12, 12);
            this.grpbQueryOptions.Name = "grpbQueryOptions";
            this.grpbQueryOptions.Size = new System.Drawing.Size(1224, 316);
            this.grpbQueryOptions.TabIndex = 1;
            this.grpbQueryOptions.TabStop = false;
            this.grpbQueryOptions.Text = "Query Options";
            // 
            // ddlsYearEnd
            // 
            this.ddlsYearEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsYearEnd.FormattingEnabled = true;
            this.ddlsYearEnd.Location = new System.Drawing.Point(199, 178);
            this.ddlsYearEnd.Name = "ddlsYearEnd";
            this.ddlsYearEnd.Size = new System.Drawing.Size(86, 25);
            this.ddlsYearEnd.TabIndex = 18;
            // 
            // btonRunQuery
            // 
            this.btonRunQuery.Location = new System.Drawing.Point(108, 268);
            this.btonRunQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btonRunQuery.Name = "btonRunQuery";
            this.btonRunQuery.Size = new System.Drawing.Size(75, 32);
            this.btonRunQuery.TabIndex = 17;
            this.btonRunQuery.Text = "Run Query";
            this.btonRunQuery.UseVisualStyleBackColor = true;
            this.btonRunQuery.Click += new System.EventHandler(this.btonRunQuery_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Advisor";
            // 
            // ddlsAdvisor
            // 
            this.ddlsAdvisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsAdvisor.FormattingEnabled = true;
            this.ddlsAdvisor.Location = new System.Drawing.Point(108, 145);
            this.ddlsAdvisor.Name = "ddlsAdvisor";
            this.ddlsAdvisor.Size = new System.Drawing.Size(177, 25);
            this.ddlsAdvisor.TabIndex = 15;
            // 
            // tboxThesisNo
            // 
            this.tboxThesisNo.Location = new System.Drawing.Point(108, 22);
            this.tboxThesisNo.Margin = new System.Windows.Forms.Padding(2);
            this.tboxThesisNo.Name = "tboxThesisNo";
            this.tboxThesisNo.Size = new System.Drawing.Size(76, 25);
            this.tboxThesisNo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thesis No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Language";
            // 
            // ddlsLanguage
            // 
            this.ddlsLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsLanguage.FormattingEnabled = true;
            this.ddlsLanguage.Location = new System.Drawing.Point(107, 209);
            this.ddlsLanguage.Name = "ddlsLanguage";
            this.ddlsLanguage.Size = new System.Drawing.Size(123, 25);
            this.ddlsLanguage.TabIndex = 11;
            // 
            // ddlsYearBegin
            // 
            this.ddlsYearBegin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsYearBegin.FormattingEnabled = true;
            this.ddlsYearBegin.Location = new System.Drawing.Point(107, 178);
            this.ddlsYearBegin.Name = "ddlsYearBegin";
            this.ddlsYearBegin.Size = new System.Drawing.Size(86, 25);
            this.ddlsYearBegin.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Year";
            // 
            // ddlsAuthor
            // 
            this.ddlsAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsAuthor.FormattingEnabled = true;
            this.ddlsAuthor.Location = new System.Drawing.Point(108, 114);
            this.ddlsAuthor.Name = "ddlsAuthor";
            this.ddlsAuthor.Size = new System.Drawing.Size(177, 25);
            this.ddlsAuthor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thesis Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Institute";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "University";
            // 
            // ddlsThesisType
            // 
            this.ddlsThesisType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsThesisType.FormattingEnabled = true;
            this.ddlsThesisType.Location = new System.Drawing.Point(108, 83);
            this.ddlsThesisType.Name = "ddlsThesisType";
            this.ddlsThesisType.Size = new System.Drawing.Size(177, 25);
            this.ddlsThesisType.TabIndex = 4;
            // 
            // ddlsInstitute
            // 
            this.ddlsInstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsInstitute.FormattingEnabled = true;
            this.ddlsInstitute.Location = new System.Drawing.Point(372, 52);
            this.ddlsInstitute.Name = "ddlsInstitute";
            this.ddlsInstitute.Size = new System.Drawing.Size(177, 25);
            this.ddlsInstitute.TabIndex = 3;
            // 
            // ddlsUniversity
            // 
            this.ddlsUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsUniversity.FormattingEnabled = true;
            this.ddlsUniversity.Location = new System.Drawing.Point(108, 52);
            this.ddlsUniversity.Name = "ddlsUniversity";
            this.ddlsUniversity.Size = new System.Drawing.Size(177, 25);
            this.ddlsUniversity.TabIndex = 2;
            this.ddlsUniversity.SelectedIndexChanged += new System.EventHandler(this.ddlsUniversity_SelectedIndexChanged);
            // 
            // dgrdThesis
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdThesis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrdThesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdThesis.Location = new System.Drawing.Point(12, 334);
            this.dgrdThesis.Name = "dgrdThesis";
            this.dgrdThesis.RowHeadersWidth = 51;
            this.dgrdThesis.Size = new System.Drawing.Size(1224, 317);
            this.dgrdThesis.TabIndex = 0;
            // 
            // frmTQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 704);
            this.ControlBox = false;
            this.Controls.Add(this.dgrdThesis);
            this.Controls.Add(this.grpbQueryOptions);
            this.Controls.Add(this.btonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graduate Thesis System v2.0 - Thesis Querying";
            this.Load += new System.EventHandler(this.frmTQuery_Load);
            this.grpbQueryOptions.ResumeLayout(false);
            this.grpbQueryOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdThesis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.GroupBox grpbQueryOptions;
        private System.Windows.Forms.DataGridView dgrdThesis;
        private System.Windows.Forms.ComboBox ddlsThesisType;
        private System.Windows.Forms.ComboBox ddlsInstitute;
        private System.Windows.Forms.ComboBox ddlsUniversity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlsLanguage;
        private System.Windows.Forms.ComboBox ddlsYearBegin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlsAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlsAdvisor;
        private System.Windows.Forms.TextBox tboxThesisNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btonRunQuery;
        private System.Windows.Forms.ComboBox ddlsYearEnd;
    }
}