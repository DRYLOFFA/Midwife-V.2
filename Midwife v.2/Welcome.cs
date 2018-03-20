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
    public partial class Welcome : Form
    {
        MidwifeEntities db = new MidwifeEntities();
        private bool _exiting;

        public Welcome()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (!_exiting && MessageBox.Show(" Are you sure want to exit?" +
                                 "\n This will close the program!", "My First Application",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (var user in db.Users)
            {
                if (user.Username == tbUsernameLogin.Text && user.Password == tbPasswordLogin.Text)
                {
                    MessageBox.Show("Welcome " + tbUsernameLogin.Text);
                    this.Hide();
                    MainPage g = new MainPage();
                    g.ShowDialog();
                    tbPasswordLogin.Clear();
                    tbUsernameLogin.Clear();
                    return;
                }
                if (user.Username != tbUsernameLogin.Text)
                {
                    MessageBox.Show("Wrong Username sorry" +
                        "\n       Please try again");
                    return;
                }
                if (user.Password != tbPasswordLogin.Text)
                {
                    MessageBox.Show("Wrong Password sorry" +
                        "\n       Please try again");
                    return;
                }
            }
        }

        private void btnExistingUser_Click(object sender, EventArgs e)
        {
            gbLogIn.Visible = true;
            gbCreateUser.Visible = false;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            gbLogIn.Hide();
            gbCreateUser.Visible = true;
            gbLogIn.Visible = false;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            gbLogIn.Visible = false;
            gbCreateUser.Visible = false;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are unable to create a new user until you purchase another" +
                "\n product key. Please Contact you nearest BlueCat software supplier ");
        }
    }
}
