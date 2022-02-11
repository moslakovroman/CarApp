using CarAppDAL.Constants;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntitiyConfigurations
{
    public class CarEntityConfiguration : IEntityTypeConfiguration<CarEntity>
    {
        public void Configure(EntityTypeBuilder<CarEntity> builder)
        {
            builder.ToTable(DatabaseTableNames.Cars);
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Mark).HasMaxLength(50);
            builder.Property(c => c.Model).HasMaxLength(50);
            builder.Property(c => c.Body).HasMaxLength(50);
            builder.Property(c => c.Year).HasMaxLength(50);
            builder.Property(c => c.Number).HasMaxLength(50);

            builder.HasOne(c => c.Model)
                .WithMany(m => m.Cars)
                .HasForeignKey(c => c.ModelId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
