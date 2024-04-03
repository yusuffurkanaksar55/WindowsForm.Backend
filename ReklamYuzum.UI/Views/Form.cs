using FluentValidation;
using FluentValidation.Results;
using ReklamYuzum.Business.Abstract;
using ReklamYuzum.Business.Validation.FluenValidation;
using ReklamYuzum.Entities.Concrete;
using ReklamYuzum.UI.Views;

namespace ReklamYuzum.UI
{
	public partial class frmRegister : Form
	{
		public frmRegister(IProfileService profileService)
		{
			_profileService = profileService;
			InitializeComponent();
		}

		private readonly IProfileService _profileService;

		private void btnSignIn_Click(object sender, EventArgs e)
		{

			var profile = new Profile()
			{
				FirstName = tbxFirstName.Text,
				LastName = tbxLastName.Text,
				ProfileEmail = tbxMail.Text,
				Password = tbxPassword.Text,
				CreateDate = DateTime.Now,
				DwhDate = DateTime.Now,
				ProfileName = tbxProfileName.Text
			};

			IValidator<Profile> profileValidator = new ProfileValidation();

			ValidationResult result = profileValidator.Validate(profile);

			if (_profileService.IsEmailContain(profile.ProfileEmail))
			{
				MessageBox.Show("Zaten Bir Hesabýnýz Mevcut,Lütfen Giriþ Yapýn", "Uyarý", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
			else if (result.IsValid)
			{
				_profileService.Add(new Profile()
				{
					FirstName = tbxFirstName.Text,
					LastName = tbxLastName.Text,
					ProfileEmail = tbxMail.Text,
					Password = tbxPassword.Text,
					CreateDate = DateTime.Now,
					DwhDate = DateTime.Now,
					ProfileName = tbxProfileName.Text
				});
				MessageBox.Show("Hesap Baþarýyla Oluþturuldu", "Tebrikler", MessageBoxButtons.OK);
			}
			else
			{
				foreach (var error in result.Errors)
				{
					MessageBox.Show(error.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		private void btnSignUp_Click(object sender, EventArgs e)
		{
			SignIn signIn = new SignIn(_profileService);
			signIn.Show();
		}
	}
}
