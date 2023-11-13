using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPelatihan13_Hilwa.Model;

namespace TugasPelatihan13_Hilwa.Controller
{
    internal class GetListController : Model.Connection
    {
        private Connection koneksi = new Connection();
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = koneksi.GetConn();
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}
