namespace Oop2
{
    partial class Login
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(61, 290);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 103;
            this.btnGiris.Text = "Log in";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGiris_MouseClick);
            // 
            // pbLogin
            // 
            this.pbLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbLogin.Location = new System.Drawing.Point(12, 12);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(180, 180);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 105;
            this.pbLogin.TabStop = false;
            // 
            // txtSifre
            // 
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSifre.Location = new System.Drawing.Point(81, 243);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 102;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKadi
            // 
            this.txtKadi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKadi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtKadi.Location = new System.Drawing.Point(81, 210);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(100, 20);
            this.txtKadi.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(11, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Username";
            // 
            // Login
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 325);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}