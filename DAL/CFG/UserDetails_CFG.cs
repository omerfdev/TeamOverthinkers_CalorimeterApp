using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CFG
{
	public class UserDetails_CFG : IEntityTypeConfiguration<UserDetails>
	{
		public void Configure(EntityTypeBuilder<UserDetails> builder)
		{
			builder.HasKey(x => x.ID);
			builder.Property(x=>x.UserID).IsRequired().HasColumnType("int");
			builder.Property(x=>x.Phone).HasColumnType("nvarchar").HasMaxLength(20);
			builder.ToTable("User Details");
			builder.Property(x=>x.Weight).HasColumnType("decimal").IsRequired();
			builder.Property(x=>x.Height).IsRequired(). HasColumnType("decimal");

		}
	}
}