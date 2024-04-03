using ReklamYuzum.Core.Entites;

namespace ReklamYuzum.Entities.Concrete
{
	public class Profile :IEntity
	{
		public int ProfileId { get; set; }
		public string ProfileName { get; set; }
		public string ProfilePhoto { get; set; }
		public int Followers { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string ProfileEmail { get; set; }
		public int Followed { get; set; }
		public string Password { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime DwhDate { get; set; }
	}
}
