using System.Linq.Expressions;
using ReklamYuzum.Entities.Concrete;
using ReklamYuzum.Core.DataAccess;

namespace ReklamYuzum.DataAccess.Abstract
{
	public interface IProfileDal :IEntityRepositoryBase<Profile>
	{
		Boolean IsEmailContain(string profileEmail);
		Profile CheckProfile(Profile profile);
	}
}
