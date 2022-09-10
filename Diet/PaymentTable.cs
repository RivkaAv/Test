using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diet
{
    public partial class PaymentTable : Form
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public PaymentTable(Form owner, int patientId, string patientName)
        {
            Owner = owner;
            PatientId = patientId;
            InitializeComponent();
            lblName.Text = patientName;

        }

        private void PaymentTable_Load(object sender, EventArgs e)
        {
            using (var dietEntities = new DietEntities())
            {
                var patientData = dietEntities.WeightDatas.Where(d => d.PatientId == PatientId && d.Meeting.GroupId == Form1.GroupId && d.Meeting.IsDone == true);
                foreach (var item in patientData)
                {
                    if(item.Meeting.MeetingDate != null)
                        tblPatientData.Rows.Add(item.Id, item.Meeting.MeetingNumber,((DateTime)item.Meeting.MeetingDate).ToShortDateString(), item.Weight != null, item.IsPaid);
                    else
                        tblPatientData.Rows.Add(item.Id, item.Meeting.MeetingNumber, null, item.Weight != null, item.IsPaid);

                }
            }
        }

        private void PaymentTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner is Form1)
            {
                (Owner as Form1).LoadDataToTable();
            }
            Owner.Show();
        }

        private void tblPatientData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using (var dietEntities = new DietEntities())
            {
                var WeightDataId = tblPatientData.CurrentRow.Cells[0].Value;
                var rowToUpdate = dietEntities.WeightDatas.FirstOrDefault(w => w.Id == (int)WeightDataId);
                var TypeOfCellToUpdate = (sender as DataGridView).CurrentCell.GetType();
                if (TypeOfCellToUpdate == typeof(DataGridViewCheckBoxCell))
                {
                    var paid = (sender as DataGridView).CurrentCell.Value;
                    if (paid != null)
                    {
                        rowToUpdate.IsPaid = (bool)paid;
                        dietEntities.SaveChanges();
                    }
                }
            }
        }
    }
}
