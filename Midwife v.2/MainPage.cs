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
    public partial class MainPage : Form
    {
        MidwifeEntities db = new MidwifeEntities();
        private bool _exiting;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!_exiting && MessageBox.Show(" Are you sure want to Log Out?" , "My First Application",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;
                this.Close();
                var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Welcome);
                if (formToShow != null)
                {
                    formToShow.Show();
                }
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            foreach (var user in db.Users)
            {
                lbLoggedinas.Text = "Currently logged in as " + user.Username;
            }
        }

        private void pbNewClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Client g = new New_Client();
            g.ShowDialog();
        }

        private void pbExistingClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExistingClients g = new ExistingClients();
            g.ShowDialog();
        }

        private void pbCalander_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Click Cancel on the next pop up box" +
                "\n or the calander will be read only");
            this.Hide();
            Calander g = new Calander();
            g.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
