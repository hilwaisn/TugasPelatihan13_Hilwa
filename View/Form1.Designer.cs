namespace TugasPelatihan13_Hilwa
{
    partial class Beranda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beranda));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignUp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignUp.Location = new System.Drawing.Point(340, 140);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(129, 57);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.BackColor = System.Drawing.Color.Navy;
            this.btnLogIn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Location = new System.Drawing.Point(340, 212);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(129, 57);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // Beranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::TugasPelatihan13_Hilwa.Properties.Resources.Uses___What_I_use_on_a_daily_basis__;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnSignUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Beranda";
            this.Text = "Beranda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogIn;
    }
}

