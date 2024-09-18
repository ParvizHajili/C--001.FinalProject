using Entities.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Teams");

            builder.Property(x => x.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.PhotoUrl)
                .HasMaxLength(200)
                .IsRequired();


            builder.Property(x => x.FacebookLink)
                .HasMaxLength(150)
                .IsRequired();


            builder.Property(x => x.InstagramLink)
                .HasMaxLength(150)
                .IsRequired();


            builder.Property(x => x.TwitterLink)
                .HasMaxLength(150)
                .IsRequired();

            builder.HasOne(x => x.Position)
                .WithMany(x => x.Teams)
                .HasForeignKey(x => x.PoritionId);

            builder.HasIndex(x => x.FirstName);


            builder.HasIndex(x => new { x.FirstName, x.Deleted })
                .IsUnique();
        }
    }
}
