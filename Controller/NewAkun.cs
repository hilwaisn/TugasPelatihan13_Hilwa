using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TugasPelatihan13_Hilwa.Model;

namespace TugasPelatihan13_Hilwa.Controller
{
    internal class NewAkun : Model.Connection
    {
        Connection conn = new Connection();
        public void AddAkun(string user, string password)
        {
            string add = "INSERT INTO Admin VALUES (" + "@username,@pass)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@username", MySqlConnector.MySqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("@pass", MySqlConnector.MySqlDbType.VarChar).Value = password;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Data Failed" + ex.Message);
            }
        }
    }
}

