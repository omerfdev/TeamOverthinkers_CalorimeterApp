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
			builder.Ignore(x=> x.FullName);
			builder.ToTable("Users");
			builder.HasMany(x=>x.UsersMeals).WithOne(x=>x.Users).HasForeignKey(x=>x.UserID);
			builder.HasOne(x=>x.UserDetails).WithOne(x=>x.Users).HasForeignKey<UserDetails>(x=>x.UserID);
			builder.HasData(new Users { ID = 1, FirstName = "admin", LastName = "admin", Email = "overthinkerst@gmail.com", Password = "60fe74406e7f353ed979f350f2fbb6a2e8690a5fa7d1b0c32983d1d8b3f95f67", IsAdmin = true });
		}
	}
}