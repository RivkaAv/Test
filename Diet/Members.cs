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
    public partial class Members : Form
    {
        public bool IsMembersData { get; set; }
        public Members(Form owner, bool members)
        {
            Owner = owner;
            IsMembersData = members;
            this.Text = members == true ? "חברות" : "חובות";
            InitializeComponent();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dietDataSet3.Patient' table. You can move, or remove it, as needed.

            LoadDataToTable();
            SetDefaultTextBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var TypeOfCellToUpdate = (sender as DataGridView).CurrentCell.GetType();

            if (TypeOfCellToUpdate == typeof(DataGridViewLinkCell))
            {
                var patientId = (int)(sender as DataGridView).CurrentRow.Cells[0].Value;
                var patientName = (sender as DataGridView).CurrentRow.Cells[1].Value.ToString();
                PaymentTable paymentTable = new PaymentTable(this, patientId, patientName);
                paymentTable.Show();
                Hide();
            }
        }

        private void Members_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            SetDefaultTextBox();
            LoadDataToTable();
        }

        private void SetDefaultTextBox()
        {
            txtSearch.Text = "שם לחיפוש...";
            txtSearch.ForeColor = Color.Gray;
        }

        private void LoadDataToTable()
        {
            using (var db = new DietEntities())
            {
                tbMembers.Rows.Clear();
                IOrderedQueryable<Patient> data;
                if (string.IsNullOrEmpty(txtSearch.Text) || txtSearch.Text == "שם לחיפוש...")
                {
                    if (IsMembersData)
                    {
                        data = db.Patients.Where(p => p.IsDeleted == false && p.IsCancelled == false).OrderBy(p => p.FullName);

                    }
                    else
                    {
                        data = db.Patients.Where(p => p.IsDeleted == false && p.IsCancelled == true).OrderBy(p => p.FullName);
                    }
                }
                else
                {
                    if (IsMembersData)
                    {
                        data = db.Patients.Where(p => p.IsDeleted == false && p.IsCancelled == false && p.FullName.StartsWith(txtSearch.Text)).OrderBy(p => p.FullName);

                    }
                    else
                    {
                        data = db.Patients.Where(p => p.IsDeleted == false && p.IsCancelled == true && p.FullName.StartsWith(txtSearch.Text)).OrderBy(p => p.FullName);
                    }
                }

                foreach (var item in data)
                {
                    tbMembers.Rows.Add(item.Id, item.FullName, item.Phone, item.Group.Name);
                }
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadDataToTable();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var patientId = (int)tbMembers.CurrentRow.Cells[0].Value;
            var patientName = tbMembers.CurrentRow.Cells[1].Value;
            var x = MessageBox.Show("?האם את בטוחה שאת רוצה למחוק את " + patientName, "מחיקת חברה", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                using (var db = new DietEntities())
                {

                    var patient = db.Patients.FirstOrDefault(p => p.Id == patientId);
                    if (patient != null)
                    {
                        patient.IsDeleted = true;
                        db.SaveChanges();
                    }
                }
                LoadDataToTable();
            }
        }
        

        private void Members_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                SetDefaultTextBox();
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "שם לחיפוש...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
    }
}
