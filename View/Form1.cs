using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPelatihan13_Hilwa.View;

namespace TugasPelatihan13_Hilwa
{
    public partial class Beranda : Form
    {
        public Beranda()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp main = new SignUp();
            this.Hide();
            main.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
        }
    }
}
