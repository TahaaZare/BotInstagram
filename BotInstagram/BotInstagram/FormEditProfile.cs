using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp.Enums;

namespace BotInstagram
{
    public partial class FormEditProfile : Form
    {
        public FormEditProfile()
        {
            InitializeComponent();
        }

        private async void FormEditProfile_Load(object sender, EventArgs e)
        {
            var EditProfile = await ctx_Context_.Api.AccountProcessor.GetRequestForEditProfileAsync();
            if (EditProfile.Succeeded)
            {
                txtBio.Text = EditProfile.Value.Biography;
                txtEmailEdit.Text = EditProfile.Value.Email;
                txtMoblEdit.Text = EditProfile.Value.PhoneNumber;
                txtNameEdit.Text = EditProfile.Value.FullName;
                txtUserNameEdit.Text = EditProfile.Value.Username;
                txtWebsiteEdit.Text = EditProfile.Value.ExternalUrl;

                if (EditProfile.Value.Gender == InstaGenderType.Male)
                {
                    rbmale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var edit = await ctx_Context_.Api.AccountProcessor.EditProfileAsync(txtNameEdit.Text, txtBio.Text,
                txtWebsiteEdit.Text, txtEmailEdit.Text,
                txtMoblEdit.Text, (rbmale.Checked) ? InstaGenderType.Male : InstaGenderType.Female, txtUserNameEdit.Text );
            if (edit.Succeeded )
            {
                MessageBox.Show("Changes Made successfully");
                this.Close();

            }
        }

        private void txtNameEdit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
