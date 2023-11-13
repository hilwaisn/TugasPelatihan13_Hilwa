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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            MataTerbuka.Visible = true;
            MataTertutup.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                NewAkun tambah = new NewAkun();
                tambah.AddAkun(txtAdmin.Text, txtPassword.Text);
                MessageBox.Show("New Pelatihan added", "add Pelatihan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                txtAdmin.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Beranda fo = new Beranda();
            this.Hide();
            fo.Show();
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            NewAkun akunBaru = new NewAkun();
            Validasi val = new Validasi();
            if (val.valName(txtAdmin.Text))
            {
                try
                {
                    akunBaru.AddAkun(txtAdmin.Text, txtPassword.Text);
                    MessageBox.Show("New Account added", "add Account",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Show();
                    txtAdmin.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty field", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Beranda ber = new Beranda();
            this.Hide();
            ber.Show();
        }
    }
}
