using System.Linq.Expressions;
using ReklamYuzum.Entities.Concrete;

namespace ReklamYuzum.Business.Abstract
{
	public interface IProfileService
	{
		List<Profile> GetProfile();
		Profile GetProfileById(int id);
		Profile Get(Expression<Func<Profile,bool>> filterExpression);
		Profile Update(Profile profile);
		Profile Add(Profile profile);
		void Delete(Profile profile);
		Boolean IsEmailContain(string Email);
		Profile CheckProfile(Profile profile);
	}
}
