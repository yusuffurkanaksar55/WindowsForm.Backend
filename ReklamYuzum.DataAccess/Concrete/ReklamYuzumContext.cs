using Microsoft.EntityFrameworkCore;
using ReklamYuzum.DataAccess.Concrete.Mapper;
using ReklamYuzum.Entities.Concrete;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace ReklamYuzum.DataAccess.Concrete
{
	public class ReklamYuzumContext :DbContext
	{
		public ReklamYuzumContext(DbContextOptions<ReklamYuzumContext> options) : base(options)
		{
		}
		public ReklamYuzumContext()
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration<Profile>(new ProfileMapper());

			//modelBuilder.Entity<Profile>().ToTable("Profiles");
			//modelBuilder.Entity<Account>().ToTable("Accounts");
			//modelBuilder.Entity<Account>()
			//	.HasKey(a=>a.AccountId);
			//modelBuilder.Entity<Profile>()
			//	.HasKey(p => p.ProfileId);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=localhost; Database=ReklamYuzum; TrustServerCertificate=True;Trusted_Connection=True; Integrated Security=True");
			}
		}

		public Microsoft.EntityFrameworkCore.DbSet<Profile> Profiles { get; set; }
	}
}
