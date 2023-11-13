namespace TugasPelatihan13_Hilwa.View
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.MataTerbuka = new System.Windows.Forms.PictureBox();
            this.MataTertutup = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MataTerbuka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MataTertutup)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(208, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(389, 47);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(208, 260);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(389, 35);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtAdmin
            // 
            this.txtAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdmin.Location = new System.Drawing.Point(208, 171);
            this.txtAdmin.Multiline = true;
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(389, 31);
            this.txtAdmin.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Location = new System.Drawing.Point(203, 228);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(140, 35);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password :";
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdmin.Location = new System.Drawing.Point(203, 139);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(106, 35);
            this.lblAdmin.TabIndex = 9;
            this.lblAdmin.Text = "Admin :";
            // 
            // lblJudul
            // 
            this.lblJudul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJudul.Location = new System.Drawing.Point(213, 56);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(374, 32);
            this.lblJudul.TabIndex = 8;
            this.lblJudul.Text = "Please Make your Account";
            // 
            // MataTerbuka
            // 
            this.MataTerbuka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MataTerbuka.ErrorImage = global::TugasPelatihan13_Hilwa.Properties.Resources.Mata_Terbuka;
            this.MataTerbuka.Image = global::TugasPelatihan13_Hilwa.Properties.Resources.Mata_Terbuka;
            this.MataTerbuka.Location = new System.Drawing.Point(563, 260);
            this.MataTerbuka.Name = "MataTerbuka";
            this.MataTerbuka.Size = new System.Drawing.Size(34, 35);
            this.MataTerbuka.TabIndex = 16;
            this.MataTerbuka.TabStop = false;
            this.MataTerbuka.Click += new System.EventHandler(this.MataTerbuka_Click);
            // 
            // MataTertutup
            // 
            this.MataTertutup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MataTertutup.ErrorImage = global::TugasPelatihan13_Hilwa.Properties.Resources.Mata_Terbuka;
            this.MataTertutup.Image = global::TugasPelatihan13_Hilwa.Properties.Resources.Mata_Tertutup;
            this.MataTertutup.Location = new System.Drawing.Point(563, 260);
            this.MataTertutup.Name = "MataTertutup";
            this.MataTertutup.Size = new System.Drawing.Size(34, 35);
            this.MataTertutup.TabIndex = 17;
            this.MataTertutup.TabStop = false;
            this.MataTertutup.Click += new System.EventHandler(this.MataTertutup_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(659, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 47);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasPelatihan13_Hilwa.Properties.Resources.Premium_Vector___Global_network_connection_world_map_abstract_technology_background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.MataTertutup);
            this.Controls.Add(this.MataTerbuka);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MataTerbuka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MataTertutup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.PictureBox MataTerbuka;
        private System.Windows.Forms.PictureBox MataTertutup;
        private System.Windows.Forms.Button btnCancel;
    }
}