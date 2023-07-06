using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CFG
{
	public class Users_CFG : IEntityTypeConfiguration<Users>
	{
		public void Configure(EntityTypeBuilder<Users> builder)
		{
			builder.HasKey(x => x.ID);
			builder.Property(x=>x.FirstName).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
			builder.Property(x=>x.LastName).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
			builder.Property(x=>x.Email).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
			builder.Property(x=>x.Password).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
			builder.Property(x => x.IsActive).IsRequired().HasColumnType("bit");

			builder.HasMany(x=>x.UsersMeals).WithOne(x=>x.Users).HasForeignKey(x=>x.UserID);
			builder.HasOne(x=>x.UserDetails).WithOne(x=>x.Users).HasForeignKey<UserDetails>(x=>x.UserID);
		}
	}
}