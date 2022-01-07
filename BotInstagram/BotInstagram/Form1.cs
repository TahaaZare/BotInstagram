using System;
using System.IO;
using System.Windows.Forms;
using InstagramApiSharp;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;

namespace BotInstagram
{
    public partial class FormMain : Form
    {
        private static UserSessionData user;


        public FormMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            user = new UserSessionData();
            user.UserName = txtUserNamerOrEmail.Text;
            user.Password = txtPassword.Text;
            ctx_Context_.Api = InstaApiBuilder.CreateBuilder().SetUser(user).UseLogger(new DebugLogger(LogLevel.All))
                .SetRequestDelay(RequestDelay.FromSeconds(0, 1)).Build();

            var LoginRequest = await ctx_Context_.Api.LoginAsync();
            if (LoginRequest.Succeeded)
            {
                gbLogin.Enabled = false;
                pcimage.Enabled = false;
                gbCommand.Enabled = true;
                gbFollowers.Enabled = true;
                gbProfile.Enabled = true;
                btnDelete.Enabled = true;
                btnAddPic.Enabled = true;

                pcimage.Load(ctx_Context_.Api.GetLoggedUser().LoggedInUser.ProfilePicUrl); //Load Pic
            }
            else
            {
                MessageBox.Show("Login Failed !\n" + LoginRequest.Info.Message);
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            new FormEditProfile().ShowDialog();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var result = await ctx_Context_.Api.AccountProcessor.RemoveProfilePictureAsync();
            if (result.Succeeded)
            {
                pcimage.Image = null;
            }
        }

        private async void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var PicByt = File.ReadAllBytes(openFileDialog.FileName);
                var result = await ctx_Context_.Api.AccountProcessor.ChangeProfilePictureAsync(PicByt);
                if (result.Succeeded)
                {
                    pcimage.ImageLocation = openFileDialog.FileName;


                }
            }
        }

        private async void btnFollowers_Click(object sender, EventArgs e)
        {
            var Followers =
            await ctx_Context_.Api.UserProcessor.GetCurrentUserFollowersAsync(
                PaginationParameters.MaxPagesToLoad(1));

            foreach (var follower in Followers.Value)
            {
                DgvFollowers.Rows.Add("@" + follower.UserName, follower.FullName, follower.IsPrivate , follower.ProfilePicUrl);
            }
        }

        private void DgvFollowers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
