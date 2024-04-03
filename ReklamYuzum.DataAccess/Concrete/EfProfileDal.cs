using System.Linq.Expressions;
using ReklamYuzum.Core.DataAccess.EntityFramework;
using ReklamYuzum.DataAccess.Abstract;
using ReklamYuzum.Entities.Concrete;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReklamYuzum.DataAccess.Concrete
{
	public class EfProfileDal : EfEntityRepositoryBase<Profile,ReklamYuzumContext>,IProfileDal
	{
		public bool IsEmailContain(string profileEmail)
		{
			using (var context=new ReklamYuzumContext())
			{
				var email = context.Profiles.Any(p => p.ProfileEmail == profileEmail);

				return email;
			}
		}

		public Profile CheckProfile(Profile profile)
		{
			using (var context = new ReklamYuzumContext())
			{
				return context.Profiles.FirstOrDefault(p => p.ProfileEmail == profile.ProfileEmail && p.Password == profile.Password);
			}
		}
	}
}
