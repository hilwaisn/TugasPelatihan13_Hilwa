﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPelatihan13_Hilwa.Controller
{
    internal class Validasi
    {
        public bool valName(string name)
        {
            for (int a = 0; a < name.Length; a++)
            {
                if ((name[a] >= '0' && name[a] <= '9') || name[0] == ' ' || name[name.Length - 1] == ' ' || name[a] == ':' ||
                    name[a] == ',' | name[0] == '-' || name[name.Length - 1] == '-' || name[a] == '/' || name[a] == '\\' ||
                    name[a] == '?')
                {
                    MessageBox.Show("Input Name field", "Add Peserta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}
