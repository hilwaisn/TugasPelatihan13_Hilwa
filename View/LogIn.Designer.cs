namespace TugasPelatihan13_Hilwa.View
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.btnCancel = new System.Windows.Forms.Button();
            this.MataTertutup = new System.Windows.Forms.PictureBox();
            this.MataTerbuka = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MataTertutup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MataTerbuka)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(658, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 47);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MataTertutup
            // 
            this.MataTertutup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MataTertutup.ErrorImage = global::TugasPelatihan13_Hilwa.Properties.Resources.Mata_Terbuka;
            this.MataTertutup.Image = global::TugasPelatihan13_Hilwa.Properties.Resources.Mata_Tertutup;
            this.MataTertutup.Location = new System.Drawing.Point(562, 255);
            this.MataTertutup.Name = "MataTertutup";
            this.MataTertutup.Size = new System.Drawing.Size(34, 35);
            this.MataTertutup.TabIndex = 26;
            this.MataTertutup.TabStop = false;
            this.MataTertutup.Click += new System.EventHandler(this.MataTertutup_Click);
            // 
            // MataTerbuka
            // 
            this.MataTerbuka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MataTerbuka.ErrorImage = global::TugasPelatihan13_Hilwa.Properties.Resources.Mata_Terbuka;
            this.MataTerbuka.Image = global::TugasPelatihan13_Hilwa.Properties.Resources.Mata_Terbuka;
            this.MataTerbuka.Location = new System.Drawing.Point(562, 255);
            this.MataTerbuka.Name = "MataTerbuka";
            this.MataTerbuka.Size = new System.Drawing.Size(34, 35);
            this.MataTerbuka.TabIndex = 25;
            this.MataTerbuka.TabStop = false;
            this.MataTerbuka.Click += new System.EventHandler(this.MataTerbuka_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.Navy;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(207, 325);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(389, 47);
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(207, 255);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(389, 35);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtAdmin
            // 
            this.txtAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdmin.Location = new System.Drawing.Point(207, 166);
            this.txtAdmin.Multiline = true;
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(389, 31);
            this.txtAdmin.TabIndex = 22;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Location = new System.Drawing.Point(202, 223);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(140, 35);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password :";
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdmin.Location = new System.Drawing.Point(202, 134);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(106, 35);
            this.lblAdmin.TabIndex = 20;
            this.lblAdmin.Text = "Admin :";
            // 
            // lblJudul
            // 
            this.lblJudul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJudul.Location = new System.Drawing.Point(270, 49);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(260, 32);
            this.lblJudul.TabIndex = 19;
            this.lblJudul.Text = "Please Login First";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasPelatihan13_Hilwa.Properties.Resources.Machine_Learning__TensorFlow_führt_experimentelle_Privacy_Testing_Library_ein;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.MataTertutup);
            this.Controls.Add(this.MataTerbuka);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.MataTertutup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MataTerbuka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox MataTertutup;
        private System.Windows.Forms.PictureBox MataTerbuka;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblJudul;
    }
}