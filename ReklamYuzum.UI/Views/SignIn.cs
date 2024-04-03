using ReklamYuzum.Business.Abstract;

namespace ReklamYuzum.UI.Views
{
	public partial class SignIn : Form
	{
		private readonly IProfileService _profileService;
		public SignIn(IProfileService profileService)
		{
			_profileService = profileService;
			InitializeComponent();
		}


		private void btnSignIn_Click(object sender, EventArgs e)
		{
			var profile = _profileService.Get(p =>
				p.ProfileEmail == tbxSignInMail.Text && p.Password == tbxSignInPassword.Text);

			if (profile == null)
			{
				MessageBox.Show("Mail Adresinizi veya Parolanızı Yanlış Girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				var checkProfile = _profileService.CheckProfile(profile);
				if (checkProfile != null)
				{
					ProfilePage profilePage = new ProfilePage(_profileService,checkProfile);
					profilePage.Show();
					this.Close();
				}
			}
		}
	}
}
