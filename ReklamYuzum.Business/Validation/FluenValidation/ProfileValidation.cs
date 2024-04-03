using FluentValidation;
using ReklamYuzum.Entities.Concrete;

namespace ReklamYuzum.Business.Validation.FluenValidation
{
	public class ProfileValidation : AbstractValidator<Profile>
	{
		public ProfileValidation()
		{
			RuleFor(p => p.ProfileEmail).NotEmpty().WithMessage("Email Adres Alanının Boş Bırakamazsınız");
			RuleFor(p => p.ProfileEmail).Length(7, 200).WithMessage("Mail Adresiniz En az 7, en fazla 200 karakter olabilir");
			RuleFor(p => p.FirstName).NotEmpty().WithMessage("İsminizi Boş Bırakamazsınız");
			RuleFor(p => p.FirstName).Length(2, 150).WithMessage("İsminiz En az 2, en fazla 150 karakter olabilir");
			RuleFor(p => p.LastName).NotEmpty().WithMessage("Soyadınız İsminizi Boş Bırakamazsınız");
			RuleFor(p => p.LastName).Length(2, 150).WithMessage("Soyadınız En az 2, en fazla 150 karakter olabilir");
			RuleFor(p => p.Password).NotEmpty().WithMessage("Lütfen Bir Şifre Belirleyiniz");
			RuleFor(p => p.Password).MinimumLength(5).WithMessage("Şifreniz en az 5 karakter içermelidir");
		}
	}
}
