using System.Linq.Expressions;
using PowerBITurkey.Core.CrossCuttingConcers.Aspects.PostSharp;
using ReklamYuzum.Business.Abstract;
using ReklamYuzum.Business.Validation.FluenValidation;
using ReklamYuzum.DataAccess.Abstract;
using ReklamYuzum.Entities.Concrete;

namespace ReklamYuzum.Business.Concrete
{
	public class ProfileManager :IProfileService
	{
		private readonly IProfileDal _profileDal;

		public ProfileManager(IProfileDal profileDal)
		{
			_profileDal = profileDal;
		}

		public List<Profile> GetProfile()
		{
			return _profileDal.GetAll().ToList();

		}

		public Profile GetProfileById(int id)
		{
			return _profileDal.Get(p => p.ProfileId == id);
		}

		public Profile Get(Expression<Func<Profile, bool>> filterExpression)
		{
			return _profileDal.Get(filterExpression);
		}


		[FluentValidationAspect(typeof(ProfileValidation))]
		public Profile Update(Profile profile)
		{
			return _profileDal.Update(profile);
		}

		[FluentValidationAspect(typeof(ProfileValidation))]
		public Profile Add(Profile profile)
		{
			return _profileDal.Add(profile);
		}

		[FluentValidationAspect(typeof(ProfileValidation))]
		public void Delete(Profile profile)
		{
			_profileDal.Delete(profile);
		}

		public bool IsEmailContain(string Email)
		{
			return _profileDal.IsEmailContain(Email);
		}

		public Profile CheckProfile(Profile profile)
		{
			return _profileDal.CheckProfile(profile);
		}
	}
}
