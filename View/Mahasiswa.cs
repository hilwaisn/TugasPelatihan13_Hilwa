using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPelatihan13_Hilwa.Controller;

namespace TugasPelatihan13_Hilwa.View
{
    public partial class Mahasiswa : Form
    {
        private MahasiswaController mahasiswaController = new MahasiswaController();
        public Mahasiswa()
        {
            InitializeComponent();
        }
        bool showStudent()
        {
            dataGridView1.DataSource = mahasiswaController.selectStudent
                (new MySqlConnector.MySqlCommand("SELECT * FROM mahasiswa"));
            dataGridView1.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[3];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            return true;
        }
        bool verify()
        {
            if ((txtNIM.Text == "") || (txtNama.Text == "") || (pictureBoxMahasiswa.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Mahasiswa_Load(object sender, EventArgs e)
        {
            txtNIM.MaxLength = 10;
            txtNama.MaxLength = 25;
            showStudent();
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            txtNIM.Clear();
            txtNama.Clear();
            dateTimePicker1.Value = DateTime.Now;
            pictureBoxMahasiswa.Image = null;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            mahasiswaController = new MahasiswaController();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year = born_year) <= 17 || (this_year - born_year) >= 25)
            {
                MessageBox.Show("Umur harus iantara 17 s/d 25", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    MemoryStream memori = new MemoryStream();
                    pictureBoxMahasiswa.Image.Save(memori, pictureBoxMahasiswa.Image.RawFormat);
                    byte[] img = memori.ToArray();
                    mahasiswaController.insertStudent(txtNIM.Text, txtNama.Text,
                        dateTimePicker1.Value, img);
                    MessageBox.Show("Penambahan data baru berhasil", "Simpan data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showStudent();
                    txtNIM.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Inputan kosong", "Tambah data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif;";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBoxMahasiswa.Image = Image.FromFile(opf.FileName);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtNIM.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[3].Value;
            MemoryStream gambar = new MemoryStream(img);
            pictureBoxMahasiswa.Image = Image.FromStream(gambar);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    mahasiswaController.deleteStudent(txtNIM.Text);
                    showStudent();
                    btnBersih.PerformClick();
                    MessageBox.Show("Hapus data berhasil", "Hapus data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNIM.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hapus data error", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
