using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midwife_v._2
{
    public partial class ExistingClients : Form
    {
        MidwifeEntities db = new MidwifeEntities();

        private bool _exiting;

        public ExistingClients()
        {
            InitializeComponent();
        }

        private void refreshnotes()
        {
            string ClientID = dgClients.SelectedRows[0].Cells[6].Value + string.Empty;

            int id = Convert.ToInt16(ClientID);

            var Visit = from c in db.Visits
                        where c.Client_ID == id
                        select c;

            foreach (var visit in Visit)
            {
                tbExistingNotes.Text = tbExistingNotes.Text + "\r\n" + visit.VisitDate;
                tbExistingNotes.Text = tbExistingNotes.Text + "\r\n" + visit.Notes;
                tbExistingNotes.Text = tbExistingNotes.Text + "\r\n" + "----------------------------------" +
                 "----------------------------------------------------------------------------------------" +
                 "----------------------------------------------------------------------------------------";
            }
        }

        private void refreshGrids()
        {
            // Set Datagrid Font and size different from perent group \\
            this.dgClients.DefaultCellStyle.Font = new Font("Tahoma", 8);
            this.dgClients.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);

            // Add Clients to Datagrid \\
            var Client = from c in db.Clients
                         select new { c.First_Name, c.Last_Name, c.Street_NO_, c.Street_Name, c.Land_Line, c.Cell_Phone, c.Client_ID };
            dgClients.DataSource = Client.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close this Form and re-open MainPage form \\
            this.Close();
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is MainPage);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void lbStreetName_Click(object sender, EventArgs e)
        {

        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            // Change color of group box depending on sex of Baby \\
            gbSex.BackColor = Color.Fuchsia;
            rbBoy.Enabled = false;
            rbGirl.Enabled = false;
            // Add Babys Sex to Database \\
            int id = Convert.ToInt16(lbCID.Text);

            var Client = (from c in db.Clients
                          where c.Client_ID == id
                          select c).First();

            Client.Sex = rbGirl.Text;
            db.SaveChanges();
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            // Change color of group box depending on sex of Baby \\
            gbSex.BackColor = Color.DodgerBlue;
            rbBoy.Enabled = false;
            rbGirl.Enabled = false;
            // Add Babys Sex to Database \\
            int id = Convert.ToInt16(lbCID.Text);

            var Client = (from c in db.Clients
                          where c.Client_ID == id
                          select c).First();

            Client.Sex = rbBoy.Text;
            db.SaveChanges();
        }

        private void ExistingClients_Load(object sender, EventArgs e)
        {
            foreach (var user in db.Users)
            {
                lbLoggedinas.Text = "Currently logged in as " + user.Username;
            }
            rbBoy.Checked = false;
            rbGirl.Checked = false;
            refreshGrids();
        }

        private void btnChangeSex_Click(object sender, EventArgs e)
        {
            // Enables and disables radio buttons to stop accedential click \\
            rbBoy.Checked = false;
            rbGirl.Checked = false;
            rbBoy.Enabled = true;
            rbGirl.Enabled = true;
            gbSex.BackColor = Color.Silver;

            string ClientID = dgClients.SelectedRows[0].Cells[6].Value + string.Empty;

            int id = Convert.ToInt16(ClientID);
            var Client = (from c in db.Clients
                          where c.Client_ID == id
                          select c).First();

            string NULL = Client.Sex;
            if ((rbBoy.Checked == false) && (rbGirl.Checked == false))
            {
                Client.Sex = "Null";
            }
            db.SaveChanges();
        }

        private void btnSex_Click(object sender, EventArgs e)
        {
            // Is a Client selected? \\
            if (dgClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Client");
                return;
            }
            // Questiones if you actually want to show babys sex \\
            if (!_exiting && MessageBox.Show(" Are you sure want to Show the baby's Sex?", "My First Application",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information) == DialogResult.OK)
                {
                _exiting = true;
                timer1.Interval = 6000;
                timer1.Tick += timer1_Tick;
                timer1.Start();
                btnSex.Visible = false;
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Timer used to hide sex unless button clicked \\
            btnSex.Visible = true;
            timer1.Stop();
            _exiting = false;
        }

        private void tbNameSearch_TextChanged(object sender, EventArgs e)
        {
            // Search for client you are seeing \\
            var Client = from c in db.Clients
                         where c.Last_Name.Contains(tbNameSearch.Text)
                         select new { c.First_Name, c.Last_Name, c.Street_NO_, c.Street_Name, c.Land_Line, c.Cell_Phone, c.Client_ID };
            dgClients.DataSource = Client.ToList();
        }

        private void dgClients_SelectionChanged(object sender, EventArgs e)
        {
            // Clear Radio buttons in case u change client selection, otherwise sex changes \\
            rbBoy.Checked = false;
            rbGirl.Checked = false;
            // Updated all lables to selected clients details \\
            if (dgClients.SelectedRows.Count > 0)
            {
                string ClientID = dgClients.SelectedRows[0].Cells[6].Value + string.Empty;

                int id = Convert.ToInt16(ClientID);

                var Client = (from c in db.Clients
                              where c.Client_ID == id
                              select c).First();
                // Clients Details \\
                string FirstName = Client.First_Name;
                string LastName = Client.Last_Name;
                string Street_NO = Client.Street_NO_;
                string StreetName = Client.Street_Name;
                string Ethnicity = Client.Ethnicity;
                string Subburb = Client.Subburb;
                string City = Client.City;
                string Children = Client.Children;
                string State = Client.State;
                string PostCode = Client.Post_Code;
                string Email = Client.Email;
                string LandLine = Client.Land_Line;
                string Cell = Client.Cell_Phone;

                lbCID.Text = ClientID;
                lbFirstName.Text = FirstName;
                lbLastName.Text = LastName;
                lbStreetNumber.Text = Street_NO;
                lbStreetName.Text = StreetName;
                lbSubburb.Text = Subburb;
                lbCity.Text = City;
                lbState.Text = State;
                lbPostCode.Text = PostCode;
                lbLandLine.Text = LandLine;
                lbCellPhone.Text = Cell;

                // Partners details \\
                string FirstNameP = Client.First_Name_P;
                string LastNameP = Client.Last_Name_P;
                string LandLineP = Client.Land_Line_P;
                string CellP = Client.Cell_Phone_P;

                lbPFirstName.Text = FirstNameP;
                lbPLastName.Text = LastNameP;
                lbPLandLine.Text = LandLineP;
                lbPCellPhone.Text = CellP;

                // Emergency Contacts details \\
                string FirstNameE = Client.First_Name_E;
                string LastNameE = Client.Last_Name_E;
                string LandLineE = Client.Land_Line_E;
                string CellE = Client.Cell_Phone_E;

                lbEFirstName.Text = FirstNameE;
                lbELastName.Text = LastNameE;
                lbELandLine.Text = LandLineE;
                lbECellPhone.Text = CellE;

                // Baby Sex details \\
                string Boy = Client.Sex;
                string Girl = Client.Sex;

                if (Client.Sex == "Boy")
                {
                    rbBoy.Checked = true;
                    gbSex.BackColor = Color.DodgerBlue;
                }
                if (Client.Sex == "Girl")
                {
                    rbGirl.Checked = true;
                    gbSex.BackColor = Color.Fuchsia;
                }
                if (Client.Sex == "Null")
                {
                    rbBoy.Checked = false;
                    rbGirl.Checked = false;
                    gbSex.BackColor = Color.Silver;
                }

                tbExistingNotes.Clear();
                refreshnotes();
                _exiting = false;
            }
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            // Confirms you actually want to Create Notes, if YES updates relevent details \\
            if (!_exiting && MessageBox.Show(" Are you sure you want to Save these Notes?", "My First Application",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;

                Visit newVisit = new Visit();

                int id = Convert.ToInt16(lbCID.Text);

                // Notes to be saved \\
                newVisit.VisitDate = DateTime.Today.Date;
                newVisit.Notes = tbTodaysNotes.Text;
                newVisit.Client_ID = id;

                db.Visits.Add(newVisit);
                db.SaveChanges();
                tbExistingNotes.Clear();
                refreshnotes();
                tbTodaysNotes.Clear();
                _exiting = false;
            }
        }

        private void dgClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
