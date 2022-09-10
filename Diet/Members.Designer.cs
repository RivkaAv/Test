namespace Diet
{
    partial class Members
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
            this.tbMembers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phonw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsPaing = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dietDataSet3 = new Diet.DietDataSet3();
            this.patientTableAdapter = new Diet.DietDataSet3TableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMembers
            // 
            this.tbMembers.AllowUserToAddRows = false;
            this.tbMembers.AllowUserToDeleteRows = false;
            this.tbMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.Phonw,
            this.GroupName,
            this.DetailsPaing});
            this.tbMembers.Location = new System.Drawing.Point(226, 14);
            this.tbMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMembers.Name = "tbMembers";
            this.tbMembers.ReadOnly = true;
            this.tbMembers.Size = new System.Drawing.Size(465, 520);
            this.tbMembers.TabIndex = 0;
            this.tbMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "שם מלא";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Phonw
            // 
            this.Phonw.HeaderText = "פלאפון";
            this.Phonw.Name = "Phonw";
            this.Phonw.ReadOnly = true;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "קבוצה";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // DetailsPaing
            // 
            this.DetailsPaing.HeaderText = "פרטי תשלום";
            this.DetailsPaing.Name = "DetailsPaing";
            this.DetailsPaing.ReadOnly = true;
            this.DetailsPaing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailsPaing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DetailsPaing.Text = "לחצי כאן";
            this.DetailsPaing.UseColumnTextForLinkValue = true;
            this.DetailsPaing.Width = 120;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 69);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 35);
            this.button3.TabIndex = 16;
            this.button3.Text = "מחיקת חברה";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Image = global::Diet.Properties.Resources.icons8_cancel_24;
            this.button6.Location = new System.Drawing.Point(3, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 31);
            this.button6.TabIndex = 22;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Image = global::Diet.Properties.Resources.icons8_search_24;
            this.button4.Location = new System.Drawing.Point(188, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 31);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearch.Location = new System.Drawing.Point(40, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(144, 31);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dietDataSet3;
            // 
            // dietDataSet3
            // 
            this.dietDataSet3.DataSetName = "DietDataSet3";
            this.dietDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 554);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbMembers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Members";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Members_FormClosing);
            this.Load += new System.EventHandler(this.Members_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Members_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.tbMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tbMembers;
        private DietDataSet3 dietDataSet3;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DietDataSet3TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonw;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewLinkColumn DetailsPaing;
    }
}