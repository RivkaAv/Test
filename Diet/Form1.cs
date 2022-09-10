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
    public partial class Form1 : Form
    {
        public static Meeting CurrentMeeting;
        public static int GroupId = 1;
        public static string GroupName = "אופקים נשים";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dietDataSet2.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.dietDataSet2.Groups);
            DietEntities dietEntities = new DietEntities();
            ShowPageHeader();
            LoadDataToTable();
            SetDefaultTextBox();
            //dietEntities.WeightDatas.
        }

        private void SetDefaultTextBox()
        {
            txtSearch.Text = "שם לחיפוש...";
            txtSearch.ForeColor = Color.Gray;
        }

        public void LoadDataToTable()
        {
            tblMeetingData.Rows.Clear();
            using (var dietEntities = new DietEntities())
            {
                IOrderedQueryable<WeightData> meetingData;
                if (string.IsNullOrEmpty(txtSearch.Text) || txtSearch.Text == "שם לחיפוש...")
                    meetingData = dietEntities.WeightDatas.Where(w => w.Patient.IsDeleted == false && w.Patient.IsCancelled == false && w.Patient.GroupId == GroupId && w.MeetingId == CurrentMeeting.Id).OrderBy(w => w.Patient.FullName);
                else
                    meetingData = dietEntities.WeightDatas.Where(w => w.Patient.IsDeleted == false && w.Patient.IsCancelled == false && w.Patient.GroupId == GroupId && w.Patient.FullName.StartsWith(txtSearch.Text) && w.MeetingId == CurrentMeeting.Id).OrderBy(w => w.Patient.FullName);

                foreach (var item in meetingData)
                {
                    if (item.Weight == null)
                    {
                        tblMeetingData.Rows.Add(item.Id, item.PatientId, item.Patient.FullName, null, null, null, item.IsPaid);
                    }
                    else
                    {
                        var first = item.Patient.WeightDatas.OrderBy(x => x.Id).FirstOrDefault(d => d.Weight != null);
                        if (first.Id == item.Id)
                            tblMeetingData.Rows.Add(item.Id, item.PatientId, item.Patient.FullName, item.Weight, null, null, item.IsPaid);
                        else
                        {
                            var last = item.Patient.WeightDatas.OrderBy(x => x.Id).LastOrDefault(d => d.MeetingId < item.MeetingId && d.Weight != null);
                            double? difFromFirst = null;
                            double? diffFromLast = null;
                            string diffFirst = "", diffLast = "";

                            if (first != null)
                            {
                                difFromFirst = Math.Round((double)item.Weight - (double)first.Weight, 1);
                                diffFirst = GetDiffWithMinusOrPlus(difFromFirst);
                            }
                            if (last != null)
                            {
                                diffFromLast = Math.Round((double)item.Weight - (double)last.Weight, 1);
                                diffLast = GetDiffWithMinusOrPlus(diffFromLast);
                            }
                            tblMeetingData.Rows.Add(item.Id, item.PatientId, item.Patient.FullName, item.Weight, diffLast, diffFirst, item.IsPaid);
                        }
                    }
                }
            }
        }

        private static string GetDiffWithMinusOrPlus(double? difFromFirst)
        {
            string diffFirst = Math.Abs((double)difFromFirst).ToString();
            if (difFromFirst == 0)
                return diffFirst;
            if (difFromFirst < 0)
                diffFirst += " -";
            else
                diffFirst += " +";

            return diffFirst;
        }

        private void LastMeetingBtn_Click(object sender, EventArgs e)
        {
            MoveToMeeting((int)CurrentMeeting.MeetingNumber-1);
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateMeetingBtn_Click(object sender, EventArgs e)
        {
            AddMeeting();
        }

        private void AddMeeting()
        {
            using (var dietEntities = new DietEntities())
            {
                int MeetingId = createNewMeeting(dietEntities);
                createMeetingForPatient(MeetingId, dietEntities);
                MoveToMeeting((int)CurrentMeeting.MeetingNumber);
                LoadDataToTable();
            }
        }

        private void createMeetingForPatient(int meetingId, DietEntities dietEntities)
        {
            var activePatient = dietEntities.Patients.Where(p => p.IsDeleted == false && p.IsCancelled == false && p.GroupId == GroupId);
            foreach (var item in activePatient)
            {
                dietEntities.WeightDatas.Add(new WeightData() {
                    PatientId = item.Id,
                    MeetingId = meetingId
                });
            }
            dietEntities.SaveChanges();
        }

        private int createNewMeeting(DietEntities dietEntities)
        {
            var currentGroup = dietEntities.Groups.First(g => g.Id == GroupId);

            var NewMeeting = dietEntities.Meetings.Add(new Meeting() {
                GroupId = GroupId,
                MeetingNumber = currentGroup.MeetingCount
            });

            currentGroup.MeetingCount++;
            dietEntities.SaveChanges();
            meetingNumberLbl.Text = NewMeeting.MeetingNumber.ToString();
            chbDone.Checked = false;
            //meetingDateDtp.Value = DateTime.Now;
            CurrentMeeting = NewMeeting;
            return NewMeeting.Id;
        }

        private void meetingDateDtp_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentMeeting != null && CurrentMeeting.MeetingDate == null && chbDone.Checked)
            {
                var UpdatedDate = (sender as DateTimePicker).Value;
                var MeetingNumber = CurrentMeeting.MeetingNumber;
                if (MeetingNumber != 0)
                {
                    using (var db = new DietEntities())
                    {
                        var MeetingToUpdate = db.Meetings.FirstOrDefault(m => m.Id == CurrentMeeting.Id);
                        MeetingToUpdate.MeetingDate = UpdatedDate;
                        db.SaveChanges();
                    }
                }
            }
        }

        private void NextMeetingBtn_Click(object sender, EventArgs e)
        {
            MoveToMeeting((int)CurrentMeeting.MeetingNumber+1);
        }


        //-------------------
        private void ShowPageHeader()
        {
            using (var dietEntities = new DietEntities())
            {
                if (dietEntities.Meetings.Count() > 0)
                {
                    var filterMeetings = dietEntities.Meetings.Where(m => m.GroupId == GroupId);
                    Meeting meeting = null;
                    if (filterMeetings != null)
                    {
                        var aaa = filterMeetings.Where(m => m.IsDone == true);
                        if (aaa == null || aaa.Count() == 0)
                            aaa = filterMeetings;
                        if (aaa.Count() > 1)
                        {
                            meeting = aaa.OrderByDescending(m => m.MeetingNumber).Take(1).ToList()[0];
                        }
                        else if (aaa.Count() == 1)
                        {
                            meeting = filterMeetings.ToList()[0];
                        }
                    }

                    if (meeting != null)
                    {
                        CurrentMeeting = meeting;
                        meetingNumberLbl.Text = meeting.MeetingNumber.ToString();
                        if (meeting.MeetingDate != null)
                            lblMeetingDate.Text = ((DateTime)meeting.MeetingDate).ToShortDateString();
                        else
                            lblMeetingDate.Text = "";
                        if (meeting.IsDone == true)
                            chbDone.Checked = true;
                        else
                            chbDone.Checked = false;
                    }
                    else
                    {
                        AddMeeting();
                    }
                }
            }
        }

        private void MoveToMeeting(int GoToMeetingNumber)
        {
            using (var dietEntities = new DietEntities())
            {
                if (GoToMeetingNumber != 0)
                {
                    Meeting lastMeeting = dietEntities.Meetings.FirstOrDefault(m => m.GroupId == GroupId && m.MeetingNumber == GoToMeetingNumber);
                    if (lastMeeting != null)
                    {
                        CurrentMeeting = lastMeeting;
                        meetingNumberLbl.Text = GoToMeetingNumber.ToString();
                        if (lastMeeting.MeetingDate != null)
                            lblMeetingDate.Text = ((DateTime)lastMeeting.MeetingDate).ToShortDateString();
                        else
                            lblMeetingDate.Text = "";
                        chbDone.Checked = lastMeeting.IsDone == true;
                    }
                    else
                    {
                        var x = MessageBox.Show("?אין מפגשים נוספים, האם להוסיף מפגש", "הוספת מפגש", MessageBoxButtons.YesNo);
                        if (x == DialogResult.Yes)
                        {
                            AddMeeting();
                        }
                    }
                }
               
            }
            LoadDataToTable();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberData memberData = new MemberData(this);
            memberData.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Members members = new Members(this, true);
            members.Show();
            this.Hide();
        }

        public void RefreshTbl()
        {
            LoadDataToTable();
        }

        private void tblMeetingData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var TypeOfCellToUpdate = (sender as DataGridView).CurrentCell.GetType();
            var WeightDataId = (int)tblMeetingData.CurrentRow.Cells[0].Value;

            using (var dietEntities = new DietEntities())
            {
                var rowToUpdate = dietEntities.WeightDatas.FirstOrDefault(w => w.Id == WeightDataId);
                if (rowToUpdate != null)
                    if (TypeOfCellToUpdate == typeof(DataGridViewTextBoxCell))
                    {
                        var success = double.TryParse((sender as DataGridView).CurrentCell.Value.ToString(), out double res);
                        if (!success)
                        {
                            (sender as DataGridView).CurrentRow.Cells[3].Value = "";
                            (sender as DataGridView).CurrentRow.Cells[4].Value = "";
                            (sender as DataGridView).CurrentRow.Cells[5].Value = "";
                            MessageBox.Show("נא להכניס מספרים בלבד!!");
                            return;
                        }

                        double weight = res;
                        rowToUpdate.Weight = weight;
                        dietEntities.SaveChanges();


                        var first = rowToUpdate.Patient.WeightDatas.OrderBy(x => x.Id).FirstOrDefault(d => d.Weight != null);
                        var last = rowToUpdate.Patient.WeightDatas.OrderBy(x => x.Id).LastOrDefault(d => d.MeetingId < rowToUpdate.MeetingId && d.Weight != null);
                        double? difFromFirst = null;
                        double? diffFromLast = null;
                        string diffFirst = "", diffLast = "";

                        if (first != null && first.Id != WeightDataId)
                        {
                            difFromFirst = Math.Round(weight - (double)first.Weight, 1);
                            diffFirst = GetDiffWithMinusOrPlus(difFromFirst);
                        }
                        if (last != null)
                        {
                            diffFromLast = Math.Round(weight - (double)last.Weight, 1);
                            diffLast = GetDiffWithMinusOrPlus(diffFromLast);
                        }


                        (sender as DataGridView).CurrentRow.Cells[4].Value = diffLast;
                        (sender as DataGridView).CurrentRow.Cells[5].Value = diffFirst;

                        // LoadDataToTable();
                    }
                    else if (TypeOfCellToUpdate == typeof(DataGridViewCheckBoxCell))
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupId = (int)cmbGroups.SelectedValue;
            GroupName = cmbGroups.Text;
            ShowPageHeader();
            LoadDataToTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new DietEntities())
            {
                if (chbDone.Checked == true && CurrentMeeting.IsDone != true)
                {
                    lblMeetingDate.Text = DateTime.Now.ToShortDateString();
                    var MeetingToUpdate = db.Meetings.FirstOrDefault(m => m.Id == CurrentMeeting.Id);
                    MeetingToUpdate.MeetingDate = DateTime.Now;
                    MeetingToUpdate.IsDone = true;
                    db.SaveChanges();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var patientId = (int)tblMeetingData.CurrentRow.Cells[1].Value;
            var patientName = tblMeetingData.CurrentRow.Cells[2].Value;
            var x = MessageBox.Show("?האם את בטוחה שאת רוצה למחוק את " + patientName , "מחיקת חברה", MessageBoxButtons.YesNo);
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

        private void button5_Click(object sender, EventArgs e)
        {
            var patientId = (int)tblMeetingData.CurrentRow.Cells[1].Value;
            var patientName = tblMeetingData.CurrentRow.Cells[2].Value;
            var x = MessageBox.Show("?האם את בטוחה שאת רוצה לבטל ולהעביר לטבלת חובות את " + patientName, "העברה לטבלת חובות", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                using (var db = new DietEntities())
                {

                    var patient = db.Patients.FirstOrDefault(p => p.Id == patientId);
                    if (patient != null)
                    {
                        patient.IsCancelled = true;
                        db.SaveChanges();
                    }
                }
                LoadDataToTable();
            }
        }

        private void tblMeetingData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var TypeOfCellToUpdate = (sender as DataGridView).CurrentCell.GetType();

            if (TypeOfCellToUpdate == typeof(DataGridViewLinkCell))
            {
                var patientId = (int)(sender as DataGridView).CurrentRow.Cells[1].Value;
                var patientName = (sender as DataGridView).CurrentRow.Cells[2].Value.ToString();
                PaymentTable paymentTable = new PaymentTable(this, patientId, patientName);
                paymentTable.Show();
                Hide();

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = tblMeetingData.DataSource;
            //bs.Filter = PatientName + " like '%" + txtSearch.Text + "%'";
            //tblMeetingData.DataSource = bs;
            //var currnetRows = tblMeetingData.Rows;
            LoadDataToTable();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetDefaultTextBox();
            LoadDataToTable();
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            //txtSearch.Text = "";
            //txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "שם לחיפוש...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                SetDefaultTextBox();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Members members = new Members(this, false);
            members.Show();
            this.Hide();
        }
    }
}
