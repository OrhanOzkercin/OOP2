namespace Oop2
{
    partial class MainForm
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
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.PictureLogin = new System.Windows.Forms.PictureBox();
            this.PictureSignup = new System.Windows.Forms.PictureBox();
            this.btnMyprofile = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Admincheck = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSignup)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureProfile
            // 
            this.pictureProfile.Location = new System.Drawing.Point(12, 12);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(150, 150);
            this.pictureProfile.TabIndex = 0;
            this.pictureProfile.TabStop = false;
            // 
            // PictureLogin
            // 
            this.PictureLogin.Location = new System.Drawing.Point(26, 184);
            this.PictureLogin.Name = "PictureLogin";
            this.PictureLogin.Size = new System.Drawing.Size(48, 48);
            this.PictureLogin.TabIndex = 1;
            this.PictureLogin.TabStop = false;
            this.PictureLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureLogin_MouseClick);
            // 
            // PictureSignup
            // 
            this.PictureSignup.Location = new System.Drawing.Point(105, 184);
            this.PictureSignup.Name = "PictureSignup";
            this.PictureSignup.Size = new System.Drawing.Size(48, 48);
            this.PictureSignup.TabIndex = 2;
            this.PictureSignup.TabStop = false;
            this.PictureSignup.Click += new System.EventHandler(this.PictureSignup_Click);
            this.PictureSignup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureSignup_MouseClick);
            // 
            // btnMyprofile
            // 
            this.btnMyprofile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyprofile.Location = new System.Drawing.Point(12, 238);
            this.btnMyprofile.Name = "btnMyprofile";
            this.btnMyprofile.Size = new System.Drawing.Size(150, 36);
            this.btnMyprofile.TabIndex = 3;
            this.btnMyprofile.Text = "My Profile";
            this.btnMyprofile.UseVisualStyleBackColor = true;
            // 
            // btnCard
            // 
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCard.Location = new System.Drawing.Point(12, 290);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(150, 36);
            this.btnCard.TabIndex = 7;
            this.btnCard.Text = "Shopping Cart";
            this.btnCard.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.Location = new System.Drawing.Point(12, 342);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(150, 36);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "Prev. Purchases";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Location = new System.Drawing.Point(12, 394);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 36);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Location = new System.Drawing.Point(12, 446);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(150, 36);
            this.btnAdmin.TabIndex = 10;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(193, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(593, 420);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // Admincheck
            // 
            this.Admincheck.AutoSize = true;
            this.Admincheck.Location = new System.Drawing.Point(13, 161);
            this.Admincheck.Name = "Admincheck";
            this.Admincheck.Size = new System.Drawing.Size(84, 17);
            this.Admincheck.TabIndex = 12;
            this.Admincheck.TabStop = true;
            this.Admincheck.Text = "Admincheck";
            this.Admincheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 498);
            this.Controls.Add(this.Admincheck);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnMyprofile);
            this.Controls.Add(this.PictureSignup);
            this.Controls.Add(this.PictureLogin);
            this.Controls.Add(this.pictureProfile);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSignup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.PictureBox PictureLogin;
        private System.Windows.Forms.PictureBox PictureSignup;
        private System.Windows.Forms.Button btnMyprofile;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton Admincheck;
    }
}

