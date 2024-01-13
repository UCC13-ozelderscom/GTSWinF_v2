namespace GTSWinF_v2
{
    partial class frmUniv
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
            this.tabcUniversity = new System.Windows.Forms.TabControl();
            this.tabpData = new System.Windows.Forms.TabPage();
            this.btonDelete = new System.Windows.Forms.Button();
            this.btonUpdate = new System.Windows.Forms.Button();
            this.btonAdd = new System.Windows.Forms.Button();
            this.dgrdUniversity = new System.Windows.Forms.DataGridView();
            this.tabpDetail = new System.Windows.Forms.TabPage();
            this.btonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxUnivName = new System.Windows.Forms.TextBox();
            this.tabcUniversity.SuspendLayout();
            this.tabpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdUniversity)).BeginInit();
            this.tabpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Location = new System.Drawing.Point(317, 393);
            this.btonClose.Margin = new System.Windows.Forms.Padding(4);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(93, 45);
            this.btonClose.TabIndex = 0;
            this.btonClose.Text = "Close";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // tabcUniversity
            // 
            this.tabcUniversity.Controls.Add(this.tabpData);
            this.tabcUniversity.Controls.Add(this.tabpDetail);
            this.tabcUniversity.Location = new System.Drawing.Point(12, 12);
            this.tabcUniversity.Name = "tabcUniversity";
            this.tabcUniversity.SelectedIndex = 0;
            this.tabcUniversity.Size = new System.Drawing.Size(399, 373);
            this.tabcUniversity.TabIndex = 1;
            // 
            // tabpData
            // 
            this.tabpData.Controls.Add(this.btonDelete);
            this.tabpData.Controls.Add(this.btonUpdate);
            this.tabpData.Controls.Add(this.btonAdd);
            this.tabpData.Controls.Add(this.dgrdUniversity);
            this.tabpData.Location = new System.Drawing.Point(4, 28);
            this.tabpData.Name = "tabpData";
            this.tabpData.Padding = new System.Windows.Forms.Padding(3);
            this.tabpData.Size = new System.Drawing.Size(391, 341);
            this.tabpData.TabIndex = 0;
            this.tabpData.Text = "General";
            this.tabpData.UseVisualStyleBackColor = true;
            // 
            // btonDelete
            // 
            this.btonDelete.Location = new System.Drawing.Point(180, 289);
            this.btonDelete.Name = "btonDelete";
            this.btonDelete.Size = new System.Drawing.Size(81, 35);
            this.btonDelete.TabIndex = 4;
            this.btonDelete.Text = "Delete";
            this.btonDelete.UseVisualStyleBackColor = true;
            this.btonDelete.Click += new System.EventHandler(this.btonDelete_Click);
            // 
            // btonUpdate
            // 
            this.btonUpdate.Location = new System.Drawing.Point(93, 289);
            this.btonUpdate.Name = "btonUpdate";
            this.btonUpdate.Size = new System.Drawing.Size(81, 35);
            this.btonUpdate.TabIndex = 3;
            this.btonUpdate.Text = "Update";
            this.btonUpdate.UseVisualStyleBackColor = true;
            this.btonUpdate.Click += new System.EventHandler(this.btonUpdate_Click);
            // 
            // btonAdd
            // 
            this.btonAdd.Location = new System.Drawing.Point(6, 289);
            this.btonAdd.Name = "btonAdd";
            this.btonAdd.Size = new System.Drawing.Size(81, 35);
            this.btonAdd.TabIndex = 2;
            this.btonAdd.Text = "Add";
            this.btonAdd.UseVisualStyleBackColor = true;
            this.btonAdd.Click += new System.EventHandler(this.btonAdd_Click);
            // 
            // dgrdUniversity
            // 
            this.dgrdUniversity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdUniversity.Location = new System.Drawing.Point(6, 6);
            this.dgrdUniversity.Name = "dgrdUniversity";
            this.dgrdUniversity.Size = new System.Drawing.Size(379, 265);
            this.dgrdUniversity.TabIndex = 1;
            this.dgrdUniversity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdUniversity_CellContentClick);
            this.dgrdUniversity.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdUniversity_CellDoubleClick);
            // 
            // tabpDetail
            // 
            this.tabpDetail.Controls.Add(this.btonSave);
            this.tabpDetail.Controls.Add(this.label5);
            this.tabpDetail.Controls.Add(this.tboxUnivName);
            this.tabpDetail.Location = new System.Drawing.Point(4, 28);
            this.tabpDetail.Name = "tabpDetail";
            this.tabpDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDetail.Size = new System.Drawing.Size(391, 341);
            this.tabpDetail.TabIndex = 1;
            this.tabpDetail.Text = "Detail";
            this.tabpDetail.UseVisualStyleBackColor = true;
            // 
            // btonSave
            // 
            this.btonSave.Location = new System.Drawing.Point(68, 101);
            this.btonSave.Name = "btonSave";
            this.btonSave.Size = new System.Drawing.Size(90, 41);
            this.btonSave.TabIndex = 12;
            this.btonSave.Text = "Save";
            this.btonSave.UseVisualStyleBackColor = true;
            this.btonSave.Click += new System.EventHandler(this.btonSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "University Name";
            // 
            // tboxUnivName
            // 
            this.tboxUnivName.Location = new System.Drawing.Point(68, 43);
            this.tboxUnivName.Name = "tboxUnivName";
            this.tboxUnivName.Size = new System.Drawing.Size(197, 26);
            this.tboxUnivName.TabIndex = 0;
            // 
            // frmUniv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 451);
            this.ControlBox = false;
            this.Controls.Add(this.tabcUniversity);
            this.Controls.Add(this.btonClose);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUniv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graduate Thesis System v2.0 - University";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.tabcUniversity.ResumeLayout(false);
            this.tabpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdUniversity)).EndInit();
            this.tabpDetail.ResumeLayout(false);
            this.tabpDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.TabControl tabcUniversity;
        private System.Windows.Forms.TabPage tabpData;
        private System.Windows.Forms.DataGridView dgrdUniversity;
        private System.Windows.Forms.TabPage tabpDetail;
        private System.Windows.Forms.Button btonDelete;
        private System.Windows.Forms.Button btonUpdate;
        private System.Windows.Forms.Button btonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxUnivName;
        private System.Windows.Forms.Button btonSave;
    }
}