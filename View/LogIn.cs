using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPelatihan13_Hilwa.Controller;

namespace TugasPelatihan13_Hilwa.View
{

    public partial class LogIn : Form
    {
        GetListController studentControl = new GetListController();
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Beranda ber = new Beranda();
            this.Hide();
            ber.Show();
        }

        private void MataTertutup_Click(object sender, EventArgs e)
        {
            if (MataTertutup.Visible == true)
            {
                MataTertutup.Visible = false;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void MataTerbuka_Click(object sender, EventArgs e)
        {
            if (MataTertutup.Visible == false)
            {
                MataTertutup.Visible = true;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtAdmin.Text == "") || (txtPassword.Text == ""))
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtAdmin.Text;
                string password = txtPassword.Text;
                DataTable table = studentControl.getList(new MySqlConnector.MySqlCommand
                    ("SELECT * FROM Admin WHERE username = '" + name + "' AND pass ='" + password + "'"));

                if (table.Rows.Count > 0)
                {
                    Mahasiswa main = new Mahasiswa();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Your admin and password are not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    } 
}
