
namespace BotInstagram
{
    partial class FormMain
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserNamerOrEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.pcimage = new System.Windows.Forms.PictureBox();
            this.gbFollowers = new System.Windows.Forms.GroupBox();
            this.DgvFollowers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFollowers = new System.Windows.Forms.Button();
            this.IsPrivate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfilePic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLogin.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.gbProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcimage)).BeginInit();
            this.gbFollowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFollowers)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtUserNamerOrEmail);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Location = new System.Drawing.Point(741, 20);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbLogin.Size = new System.Drawing.Size(231, 184);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "User Account";
            this.gbLogin.Enter += new System.EventHandler(this.gbLogin_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(6, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(219, 29);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(219, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Carino2003Programming";
            // 
            // txtUserNamerOrEmail
            // 
            this.txtUserNamerOrEmail.Location = new System.Drawing.Point(6, 48);
            this.txtUserNamerOrEmail.Name = "txtUserNamerOrEmail";
            this.txtUserNamerOrEmail.Size = new System.Drawing.Size(219, 22);
            this.txtUserNamerOrEmail.TabIndex = 2;
            this.txtUserNamerOrEmail.Text = "carinolearn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "PassWord :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(116, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName or Email :";
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.btnEditProfile);
            this.gbCommand.Enabled = false;
            this.gbCommand.Location = new System.Drawing.Point(308, 20);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(157, 83);
            this.gbCommand.TabIndex = 4;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Command";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(15, 31);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(113, 26);
            this.btnEditProfile.TabIndex = 0;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.btnDelete);
            this.gbProfile.Controls.Add(this.btnAddPic);
            this.gbProfile.Controls.Add(this.pcimage);
            this.gbProfile.Location = new System.Drawing.Point(12, 12);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(281, 280);
            this.gbProfile.TabIndex = 5;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Pic Of Profile";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(22, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Pictrue";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddPic
            // 
            this.btnAddPic.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddPic.Enabled = false;
            this.btnAddPic.ForeColor = System.Drawing.Color.White;
            this.btnAddPic.Location = new System.Drawing.Point(151, 210);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(111, 33);
            this.btnAddPic.TabIndex = 1;
            this.btnAddPic.Text = "Add Pictrue";
            this.btnAddPic.UseVisualStyleBackColor = false;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // pcimage
            // 
            this.pcimage.Location = new System.Drawing.Point(22, 21);
            this.pcimage.Name = "pcimage";
            this.pcimage.Size = new System.Drawing.Size(240, 170);
            this.pcimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcimage.TabIndex = 0;
            this.pcimage.TabStop = false;
            // 
            // gbFollowers
            // 
            this.gbFollowers.Controls.Add(this.DgvFollowers);
            this.gbFollowers.Controls.Add(this.btnFollowers);
            this.gbFollowers.Enabled = false;
            this.gbFollowers.Location = new System.Drawing.Point(12, 321);
            this.gbFollowers.Name = "gbFollowers";
            this.gbFollowers.Size = new System.Drawing.Size(467, 431);
            this.gbFollowers.TabIndex = 6;
            this.gbFollowers.TabStop = false;
            this.gbFollowers.Text = "Followers";
            // 
            // DgvFollowers
            // 
            this.DgvFollowers.AllowUserToAddRows = false;
            this.DgvFollowers.AllowUserToDeleteRows = false;
            this.DgvFollowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFollowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFollowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.IsPrivate,
            this.ProfilePic});
            this.DgvFollowers.Location = new System.Drawing.Point(10, 18);
            this.DgvFollowers.Name = "DgvFollowers";
            this.DgvFollowers.ReadOnly = true;
            this.DgvFollowers.Size = new System.Drawing.Size(443, 338);
            this.DgvFollowers.TabIndex = 5;
            this.DgvFollowers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFollowers_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "UserName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FullName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnFollowers
            // 
            this.btnFollowers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFollowers.Location = new System.Drawing.Point(10, 376);
            this.btnFollowers.Name = "btnFollowers";
            this.btnFollowers.Size = new System.Drawing.Size(421, 29);
            this.btnFollowers.TabIndex = 4;
            this.btnFollowers.Text = "Show Followers";
            this.btnFollowers.UseVisualStyleBackColor = false;
            this.btnFollowers.Click += new System.EventHandler(this.btnFollowers_Click);
            // 
            // IsPrivate
            // 
            this.IsPrivate.HeaderText = "Is Private";
            this.IsPrivate.Name = "IsPrivate";
            this.IsPrivate.ReadOnly = true;
            // 
            // ProfilePic
            // 
            this.ProfilePic.HeaderText = "Profile Pic";
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 764);
            this.Controls.Add(this.gbFollowers);
            this.Controls.Add(this.gbProfile);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.gbLogin);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOT Instagram";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbCommand.ResumeLayout(false);
            this.gbProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcimage)).EndInit();
            this.gbFollowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFollowers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserNamerOrEmail;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.PictureBox pcimage;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbFollowers;
        private System.Windows.Forms.Button btnFollowers;
        private System.Windows.Forms.DataGridView DgvFollowers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPrivate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfilePic;
    }
}

