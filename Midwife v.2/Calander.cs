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
    public partial class Calander : Form
    {
        MidwifeEntities db = new MidwifeEntities();

        public Calander()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is MainPage);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void Calander_Load(object sender, EventArgs e)
        {
            foreach (var user in db.Users)
            {
                lbLoggedinas.Text = "Currently logged in as " + user.Username;
            }
            webBrowser1.Navigate("https://www.google.com/calendar/");
            webBrowser1.Show();
        }
    }
}
