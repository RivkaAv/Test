namespace Diet
{
    partial class Form1
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
            this.tblMeetingData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrneWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewLinkColumn();
            this.NextMeetingBtn = new System.Windows.Forms.Button();
            this.LastMeetingBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.meetingNumberLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMeetingDate = new System.Windows.Forms.Label();
            this.chbDone = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dietDataSet2 = new Diet.DietDataSet2();
            this.dietDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dietDataSet1 = new Diet.DietDataSet1();
            this.dietDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new Diet.DietDataSet2TableAdapters.GroupsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblMeetingData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMeetingData
            // 
            this.tblMeetingData.AllowUserToAddRows = false;
            this.tblMeetingData.AllowUserToDeleteRows = false;
            this.tblMeetingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMeetingData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PatientId,
            this.PatientName,
            this.CurrneWeight,
            this.Difference,
            this.TotalDiff,
            this.IsPaid,
            this.Details});
            this.tblMeetingData.Location = new System.Drawing.Point(55, 107);
            this.tblMeetingData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblMeetingData.Name = "tblMeetingData";
            this.tblMeetingData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tblMeetingData.Size = new System.Drawing.Size(670, 618);
            this.tblMeetingData.TabIndex = 0;
            this.tblMeetingData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblMeetingData_CellContentClick);
            this.tblMeetingData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblMeetingData_CellEndEdit);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // PatientId
            // 
            this.PatientId.HeaderText = "קוד לקוח";
            this.PatientId.Name = "PatientId";
            this.PatientId.Visible = false;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "שם";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 150;
            // 
            // CurrneWeight
            // 
            this.CurrneWeight.HeaderText = "משקל";
            this.CurrneWeight.Name = "CurrneWeight";
            // 
            // Difference
            // 
            this.Difference.HeaderText = "עליה/ירידה";
            this.Difference.Name = "Difference";
            this.Difference.ReadOnly = true;
            // 
            // TotalDiff
            // 
            this.TotalDiff.HeaderText = "סך עליה/ירידה";
            this.TotalDiff.Name = "TotalDiff";
            this.TotalDiff.ReadOnly = true;
            this.TotalDiff.Width = 130;
            // 
            // IsPaid
            // 
            this.IsPaid.HeaderText = "שולם";
            this.IsPaid.Name = "IsPaid";
            this.IsPaid.Width = 50;
            // 
            // Details
            // 
            this.Details.HeaderText = "פרטי תשלום";
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.Text = "לחצי כאן";
            this.Details.UseColumnTextForLinkValue = true;
            // 
            // NextMeetingBtn
            // 
            this.NextMeetingBtn.Location = new System.Drawing.Point(55, 63);
            this.NextMeetingBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NextMeetingBtn.Name = "NextMeetingBtn";
            this.NextMeetingBtn.Size = new System.Drawing.Size(67, 36);
            this.NextMeetingBtn.TabIndex = 1;
            this.NextMeetingBtn.Text = "<< הבא";
            this.NextMeetingBtn.UseVisualStyleBackColor = true;
            this.NextMeetingBtn.Click += new System.EventHandler(this.NextMeetingBtn_Click);
            // 
            // LastMeetingBtn
            // 
            this.LastMeetingBtn.Location = new System.Drawing.Point(645, 63);
            this.LastMeetingBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastMeetingBtn.Name = "LastMeetingBtn";
            this.LastMeetingBtn.Size = new System.Drawing.Size(80, 36);
            this.LastMeetingBtn.TabIndex = 2;
            this.LastMeetingBtn.Text = "קודם >>";
            this.LastMeetingBtn.UseVisualStyleBackColor = true;
            this.LastMeetingBtn.Click += new System.EventHandler(this.LastMeetingBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "מפגש מספר-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // meetingNumberLbl
            // 
            this.meetingNumberLbl.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.meetingNumberLbl.Location = new System.Drawing.Point(245, 17);
            this.meetingNumberLbl.Name = "meetingNumberLbl";
            this.meetingNumberLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.meetingNumberLbl.Size = new System.Drawing.Size(64, 25);
            this.meetingNumberLbl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "בתאריך:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "צפיה בכל החברות";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 165);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "הוספת חברה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lblMeetingDate);
            this.panel1.Controls.Add(this.chbDone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.meetingNumberLbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(129, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 53);
            this.panel1.TabIndex = 10;
            // 
            // lblMeetingDate
            // 
            this.lblMeetingDate.AutoSize = true;
            this.lblMeetingDate.Location = new System.Drawing.Point(28, 17);
            this.lblMeetingDate.Name = "lblMeetingDate";
            this.lblMeetingDate.Size = new System.Drawing.Size(0, 25);
            this.lblMeetingDate.TabIndex = 9;
            // 
            // chbDone
            // 
            this.chbDone.AutoSize = true;
            this.chbDone.Location = new System.Drawing.Point(445, 23);
            this.chbDone.Name = "chbDone";
            this.chbDone.Size = new System.Drawing.Size(15, 14);
            this.chbDone.TabIndex = 8;
            this.chbDone.UseVisualStyleBackColor = true;
            this.chbDone.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "קבוצת: ";
            // 
            // cmbGroups
            // 
            this.cmbGroups.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupsBindingSource, "Name", true));
            this.cmbGroups.DataSource = this.dietDataSet2;
            this.cmbGroups.DisplayMember = "Groups.Name";
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(310, 6);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(121, 28);
            this.cmbGroups.TabIndex = 14;
            this.cmbGroups.ValueMember = "Groups.Id";
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.dietDataSet2;
            // 
            // dietDataSet2
            // 
            this.dietDataSet2.DataSetName = "DietDataSet2";
            this.dietDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietDataSet2BindingSource
            // 
            this.dietDataSet2BindingSource.DataSource = this.dietDataSet2;
            this.dietDataSet2BindingSource.Position = 0;
            // 
            // dietDataSet1
            // 
            this.dietDataSet1.DataSetName = "DietDataSet1";
            this.dietDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietDataSet1BindingSource
            // 
            this.dietDataSet1BindingSource.DataSource = this.dietDataSet1;
            this.dietDataSet1BindingSource.Position = 0;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(741, 210);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "מחיקת חברה";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(742, 255);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 35);
            this.button5.TabIndex = 16;
            this.button5.Text = "העברה לטבלת חובות";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearch.Location = new System.Drawing.Point(778, 109);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(182, 31);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            // 
            // button4
            // 
            this.button4.Image = global::Diet.Properties.Resources.icons8_search_24;
            this.button4.Location = new System.Drawing.Point(741, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 31);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button6
            // 
            this.button6.Image = global::Diet.Properties.Resources.icons8_cancel_24;
            this.button6.Location = new System.Drawing.Point(966, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 31);
            this.button6.TabIndex = 19;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(742, 407);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(257, 35);
            this.button7.TabIndex = 20;
            this.button7.Text = "צפיה בטבלת חובות";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 748);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LastMeetingBtn);
            this.Controls.Add(this.NextMeetingBtn);
            this.Controls.Add(this.tblMeetingData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.tblMeetingData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblMeetingData;
        private System.Windows.Forms.Button NextMeetingBtn;
        private System.Windows.Forms.Button LastMeetingBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label meetingNumberLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGroups;
        private DietDataSet2 dietDataSet2;
        private System.Windows.Forms.BindingSource dietDataSet2BindingSource;
        private DietDataSet1 dietDataSet1;
        private System.Windows.Forms.BindingSource dietDataSet1BindingSource;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private DietDataSet2TableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.CheckBox chbDone;
        private System.Windows.Forms.Label lblMeetingDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrneWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difference;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiff;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPaid;
        private System.Windows.Forms.DataGridViewLinkColumn Details;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

