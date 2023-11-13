namespace TugasPelatihan13_Hilwa.View
{
    partial class Mahasiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mahasiswa));
            this.lblJudul = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNim = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBersih = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBoxMahasiswa = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblJudul.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(260, 22);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(338, 39);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Pendaftaran Mahasiswa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(809, 233);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(48, 373);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(61, 22);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama";
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNim.Location = new System.Drawing.Point(48, 334);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(44, 22);
            this.lblNim.TabIndex = 3;
            this.lblNim.Text = "NIM";
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTL.Location = new System.Drawing.Point(48, 414);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(134, 22);
            this.lblTL.TabIndex = 4;
            this.lblTL.Text = "Tanggal Lahir";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(247, 333);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(218, 26);
            this.txtNIM.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(247, 369);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(294, 26);
            this.txtNama.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 414);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnBersih
            // 
            this.btnBersih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBersih.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBersih.Location = new System.Drawing.Point(512, 528);
            this.btnBersih.Name = "btnBersih";
            this.btnBersih.Size = new System.Drawing.Size(113, 36);
            this.btnBersih.TabIndex = 8;
            this.btnBersih.Text = "Bersihkan";
            this.btnBersih.UseVisualStyleBackColor = false;
            this.btnBersih.Click += new System.EventHandler(this.btnBersih_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHapus.Location = new System.Drawing.Point(643, 528);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(84, 36);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSimpan.Location = new System.Drawing.Point(749, 528);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(93, 36);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpload.Location = new System.Drawing.Point(726, 451);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(138, 36);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBoxMahasiswa
            // 
            this.pictureBoxMahasiswa.Location = new System.Drawing.Point(731, 333);
            this.pictureBoxMahasiswa.Name = "pictureBoxMahasiswa";
            this.pictureBoxMahasiswa.Size = new System.Drawing.Size(130, 121);
            this.pictureBoxMahasiswa.TabIndex = 12;
            this.pictureBoxMahasiswa.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(36, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // Mahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasPelatihan13_Hilwa.Properties.Resources.Dewapoker___Pesan_Ayah_ke_Mahasiswa_ITB_Lulus_3_5_Tahun_Cumlaude__Pendidikan_Kunci_Sukses_di____;
            this.ClientSize = new System.Drawing.Size(915, 588);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBoxMahasiswa);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBersih);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.lblNim);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mahasiswa";
            this.Text = "Mahasiswa";
            this.Load += new System.EventHandler(this.Mahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNim;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBersih;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBoxMahasiswa;
        private System.Windows.Forms.Button btnDelete;
    }
}