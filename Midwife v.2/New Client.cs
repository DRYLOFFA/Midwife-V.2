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
    public partial class New_Client : Form
    {

        MidwifeEntities db = new MidwifeEntities();
        private bool _exiting;

        public New_Client()
        {
            InitializeComponent();
        }

        private void refreshGrids()
        {
            // Set Datagrid Font and size different from perent group \\
            this.dgUpdateCustomer.DefaultCellStyle.Font = new Font("Tahoma", 8);
            this.dgUpdateCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);

            // Add Clients to Datagrid \\
            var Client = from c in db.Clients
                         select new { c.Client_ID, c.First_Name, c.Last_Name, c.Street_NO_, c.Street_Name, c.Land_Line, c.Cell_Phone };
            dgUpdateCustomer.DataSource = Client.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close this Form and open the MainPage \\
            this.Close();
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is MainPage);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_Client_Load(object sender, EventArgs e)
        {
            foreach (var user in db.Users)
            {
                lbLoggedinas.Text = "Currently logged in as " + user.Username;
            }
            this.dgUpdateCustomer.DefaultCellStyle.Font = new Font("Tahoma", 8);
            this.dgUpdateCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
            //dgUpdateCustomer.ClearSelection();
        }

        private void tbLastNameSearchUpdate_TextChanged(object sender, EventArgs e)
        {
            // Text changes search use last name \\
            var Client = from c in db.Clients
                         where c.Last_Name.Contains(tbLastNameSearchUpdate.Text)
                         select new { c.Client_ID, c.First_Name, c.Last_Name, c.Street_NO_, c.Street_Name, c.Land_Line, c.Cell_Phone };
            dgUpdateCustomer.DataSource = Client.ToList();
        }

        private void dgUpdateCustomer_SelectionChanged(object sender, EventArgs e)
        {
            // When a row in DataGrid is selected, Update all text boxes to that cliets details \\
            if (dgUpdateCustomer.SelectedRows.Count > 0)
            {
                string ClientID = dgUpdateCustomer.SelectedRows[0].Cells[0].Value + string.Empty;

                int id = Convert.ToInt16(ClientID);

                var Client = (from c in db.Clients
                             where c.Client_ID == id
                             select c).First();

                // Client \\
                string FirstName = Client.First_Name;
                string LastName = Client.Last_Name;
                string DOB = Client.DOB.ToString();
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

                tbCClientno.Text = ClientID;
                tbCFirstName.Text = FirstName;
                tbCLastName.Text = LastName;
                tbCDOB.Text = DOB;
                tbCStreetNo.Text = Street_NO;
                tbCStreetName.Text = StreetName;
                tbCEthnicity.Text = Ethnicity;
                tbCSubburb.Text = Subburb;
                tbCCity.Text = City;
                tbCChildren.Text = Children;
                tbCState.Text = State;
                tbCPostCode.Text = PostCode;
                tbCEmail.Text = Email;
                tbCLandLine.Text = LandLine;
                tbCCellPhone.Text = Cell;

                // Partner \\
                string FirstNameP = Client.First_Name_P;
                string LastNameP = Client.Last_Name_P;
                string Street_NOP = Client.Street_NO__P;
                string StreetNameP = Client.Street_Name_P;
                string SubburbP = Client.Subburb_P;
                string CityP = Client.City_P;
                string StateP = Client.State_P;
                string PostCodeP = Client.Post_Code_P;
                string LandLineP = Client.Land_Line_P;
                string CellP = Client.Cell_Phone_P;

                tbPFirstName.Text = FirstNameP;
                tbPLastName.Text = LastNameP;
                tbPStreetNo.Text = Street_NOP;
                tbPStreetName.Text = StreetNameP;
                tbPSubburb.Text = SubburbP;
                tbPCity.Text = CityP;
                tbPState.Text = StateP;
                tbPPost.Text = PostCodeP;
                tbPLandLine.Text = LandLineP;
                tbPCellPhone.Text = CellP;

                // Emergency Contact \\
                string FirstNameE = Client.First_Name_E;
                string LastNameE = Client.Last_Name_E;
                string Street_NOE = Client.Street_NO__E;
                string StreetNameE = Client.Street_Name_E;
                string SubburbE = Client.Subburb_E;
                string CityE = Client.City_E;
                string StateE = Client.State_E;
                string PostCodeE = Client.Post_Code_E;
                string LandLineE = Client.Land_Line_E;
                string CellE = Client.Cell_Phone_E;

                tbEFirstName.Text = FirstNameE;
                tbELastName.Text = LastNameE;
                tbEStreetNo.Text = Street_NOE;
                tbEStreetName.Text = StreetNameE;
                tbESubburb.Text = SubburbE;
                tbECity.Text = CityE;
                tbEState.Text = StateE;
                tbEPost.Text = PostCodeE;
                tbELandLine.Text = LandLineE;
                tbECellPhone.Text = CellE;
            }
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            // Create new client and confirm you want to create new client \\
            Client newClientdb = new Client();

            if (!_exiting && MessageBox.Show(" Are you sure you want to create this profile?",  "My First Application",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;

                // Client \\
                newClientdb.First_Name = tbCFirstName.Text;
                newClientdb.Last_Name = tbCLastName.Text;
                newClientdb.DOB = Convert.ToDateTime(tbCDOB.Text);
                newClientdb.Street_NO_ = tbCStreetNo.Text;
                newClientdb.Street_Name = tbCStreetName.Text;
                newClientdb.Ethnicity = tbCEthnicity.Text;
                newClientdb.Subburb = tbCSubburb.Text;
                newClientdb.City = tbCCity.Text;
                newClientdb.Children = tbCChildren.Text;
                newClientdb.State = tbCState.Text;
                newClientdb.Post_Code = tbCPostCode.Text;
                newClientdb.Email = tbCEmail.Text;
                newClientdb.Land_Line = tbCLandLine.Text;
                newClientdb.Cell_Phone = tbCCellPhone.Text;

                // Partner \\
                newClientdb.First_Name_P = tbPFirstName.Text;
                newClientdb.Last_Name_P = tbPLastName.Text;
                newClientdb.Street_NO__P = tbPStreetNo.Text;
                newClientdb.Street_Name_P = tbPStreetName.Text;
                newClientdb.Subburb_P = tbPSubburb.Text;
                newClientdb.City_P = tbPCity.Text;
                newClientdb.State_P = tbPState.Text;
                newClientdb.Post_Code_P = tbPPost.Text;
                newClientdb.Land_Line_P = tbPLandLine.Text;
                newClientdb.Cell_Phone_P = tbPCellPhone.Text;

                // Emergency Contact \\
                newClientdb.First_Name_E = tbEFirstName.Text;
                newClientdb.Last_Name_E = tbELastName.Text;
                newClientdb.Street_NO__E = tbEStreetNo.Text;
                newClientdb.Street_Name_E = tbEStreetName.Text;
                newClientdb.Subburb_E = tbESubburb.Text;
                newClientdb.City_E = tbECity.Text;
                newClientdb.State_E = tbEState.Text;
                newClientdb.Post_Code_E = tbEPost.Text;
                newClientdb.Land_Line_E = tbELandLine.Text;
                newClientdb.Cell_Phone_E = tbECellPhone.Text;

                // Updates \\
                db.Clients.Add(newClientdb);
                db.SaveChanges();
                MessageBox.Show("New Client Profile has been created");
                refreshGrids();
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            // Confirms you actually want to update details, if YES updates relevent details \\
            if (!_exiting && MessageBox.Show(" Are you sure you want to update this profiles details?", "My First Application",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;

                int id = Convert.ToInt16(tbCClientno.Text);

                var Client = (from c in db.Clients
                              where c.Client_ID == id
                              select c).First();

                // Client \\
                Client.First_Name = tbCFirstName.Text;
                Client.Last_Name = tbCLastName.Text;
                Client.DOB = Convert.ToDateTime(tbCDOB.Text);
                Client.Street_NO_ = tbCStreetNo.Text;
                Client.Street_Name = tbCStreetName.Text;
                Client.Ethnicity = tbCEthnicity.Text;
                Client.Subburb = tbCSubburb.Text;
                Client.City = tbCCity.Text;
                Client.Children = tbCChildren.Text;
                Client.State = tbCState.Text;
                Client.Post_Code = tbCPostCode.Text;
                Client.Email = tbCEmail.Text;
                Client.Land_Line = tbCLandLine.Text;
                Client.Cell_Phone = tbCCellPhone.Text;

                // Partner \\
                Client.First_Name_P = tbPFirstName.Text;
                Client.Last_Name_P = tbPLastName.Text;
                Client.Street_NO__P = tbPStreetNo.Text;
                Client.Street_Name_P = tbPStreetName.Text;
                Client.Subburb_P = tbPSubburb.Text;
                Client.City_P = tbPCity.Text;
                Client.State_P = tbPState.Text;
                Client.Post_Code_P = tbPPost.Text;
                Client.Land_Line_P = tbPLandLine.Text;
                Client.Cell_Phone_P = tbPCellPhone.Text;

                // Emergency Contact \\
                Client.First_Name_E = tbEFirstName.Text;
                Client.Last_Name_E = tbELastName.Text;
                Client.Street_NO__E = tbEStreetNo.Text;
                Client.Street_Name_E = tbEStreetName.Text;
                Client.Subburb_E = tbESubburb.Text;
                Client.City_E = tbECity.Text;
                Client.State_E = tbEState.Text;
                Client.Post_Code_E = tbEPost.Text;
                Client.Land_Line_E = tbELandLine.Text;
                Client.Cell_Phone_E = tbECellPhone.Text;

                db.SaveChanges();
                dgUpdateCustomer.DataSource = null;
            }
            _exiting = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!_exiting && MessageBox.Show(" Are you sure you want to clear all fields?", "My First Application",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;

                // Update Boxes \\
                tbLastNameSearchUpdate.Clear();
                dgUpdateCustomer.DataSource = null;

                // Client Boxes \\
                tbCFirstName.Clear();
                tbCLastName.Clear();
                tbCDOB.ResetText();
                tbCStreetNo.Clear();
                tbCStreetName.Clear();
                tbCEthnicity.Clear();
                tbCSubburb.Clear();
                tbCCity.Clear();
                tbCChildren.Clear();
                tbCState.Clear();
                tbCPostCode.Clear();
                tbCEmail.Clear();
                tbCLandLine.Clear();
                tbCCellPhone.Clear();
                tbCClientno.Clear();

                // Partner Boxes \\
                tbPFirstName.Clear();
                tbPLastName.Clear();
                tbPStreetNo.Clear();
                tbPStreetName.Clear();
                tbPSubburb.Clear();
                tbPCity.Clear();
                tbPState.Clear();
                tbPPost.Clear();
                tbPLandLine.Clear();
                tbPCellPhone.Clear();

                // Emergency Contact Boxes \\
                tbEFirstName.Clear();
                tbELastName.Clear();
                tbEStreetNo.Clear();
                tbEStreetName.Clear();
                tbESubburb.Clear();
                tbECity.Clear();
                tbEState.Clear();
                tbEPost.Clear();
                tbELandLine.Clear();
                tbECellPhone.Clear();
            }
            _exiting = false;
        }
    }
}
