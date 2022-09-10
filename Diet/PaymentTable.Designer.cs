namespace Diet
{
    partial class PaymentTable
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
            this.tblPatientData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeetingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCome = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientData)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPatientData
            // 
            this.tblPatientData.AllowUserToAddRows = false;
            this.tblPatientData.AllowUserToDeleteRows = false;
            this.tblPatientData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPatientData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MeetingNumber,
            this.date,
            this.IsCome,
            this.IsPaid});
            this.tblPatientData.Location = new System.Drawing.Point(75, 72);
            this.tblPatientData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblPatientData.Name = "tblPatientData";
            this.tblPatientData.Size = new System.Drawing.Size(465, 558);
            this.tblPatientData.TabIndex = 0;
            this.tblPatientData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPatientData_CellEndEdit);
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // MeetingNumber
            // 
            this.MeetingNumber.Frozen = true;
            this.MeetingNumber.HeaderText = "שיעור מספר";
            this.MeetingNumber.Name = "MeetingNumber";
            this.MeetingNumber.ReadOnly = true;
            this.MeetingNumber.Width = 120;
            // 
            // date
            // 
            this.date.Frozen = true;
            this.date.HeaderText = "תאריך";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // IsCome
            // 
            this.IsCome.Frozen = true;
            this.IsCome.HeaderText = "הייתה נוכחת";
            this.IsCome.Name = "IsCome";
            this.IsCome.ReadOnly = true;
            // 
            // IsPaid
            // 
            this.IsPaid.HeaderText = "שולם";
            this.IsPaid.Name = "IsPaid";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(284, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 25);
            this.lblName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "פרטי תשלומים של:";
            // 
            // PaymentTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tblPatientData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentTable";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentTable_FormClosing);
            this.Load += new System.EventHandler(this.PaymentTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblPatientData;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeetingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsCome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPaid;
        private System.Windows.Forms.Label label1;
    }
}