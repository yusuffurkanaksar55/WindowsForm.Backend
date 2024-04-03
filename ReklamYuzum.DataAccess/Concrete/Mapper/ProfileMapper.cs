using ReklamYuzum.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReklamYuzum.DataAccess.Concrete.Mapper
{
	internal class ProfileMapper :EntityTypeConfiguration<Profile>, IEntityTypeConfiguration<Profile>
	{
		public ProfileMapper()
		{
			ToTable(@"Profiles", "dbo");
			HasKey(p => p.ProfileId);

			Property(p => p.DwhDate).HasColumnName("dwh_date");

		}

		public void Configure(EntityTypeBuilder<Profile> builder)
		{
			builder.HasKey(p=>p.ProfileId);
			builder.Property(p => p.DwhDate).HasColumnName("dwh_date");
		}
	}
}
