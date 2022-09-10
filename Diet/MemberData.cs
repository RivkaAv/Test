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
    public partial class MemberData : Form
    {
        public MemberData(Form1 weightData)
        {
            Owner = weightData;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dietEntities = new DietEntities())
            {
                var patient = dietEntities.Patients.Add(new Patient()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    GroupId = (int)cmbCity.SelectedValue
                });


                var createdMeetings = dietEntities.Meetings.Where(d => d.GroupId == (int)cmbCity.SelectedValue && d.Id >= Form1.CurrentMeeting.Id);
                foreach (var item in createdMeetings)
                {
                    dietEntities.WeightDatas.Add(new WeightData()
                    {
                        Patient = patient,
                        MeetingId = item.Id
                    });

                };

                dietEntities.SaveChanges();
            }
            Owner.Show();
            (Owner as Form1).RefreshTbl();
            Close();
        }

        private void MemberData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dietDataSet2.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.dietDataSet2.Groups);
            cmbCity.SelectedIndex = cmbCity.FindStringExact(Form1.GroupName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void MemberData_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }
    }
}
