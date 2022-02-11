using CarAppDAL.Constants;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CarAppDAL.EntitiyConfigurations
{
    public class CarModelEntityConfiguration : IEntityTypeConfiguration<CarModelEntity>
    {
        public void Configure(EntityTypeBuilder<CarModelEntity> builder)
        {
            builder.ToTable(DatabaseTableNames.Models);
            builder.HasKey(cm => cm.Id);

            builder.Property(cm => cm.Name).HasMaxLength(50);
            builder.Property(cm => cm.Mark).HasMaxLength(50);
            builder.Property(cm => cm.Cars).HasMaxLength(50);

            builder.HasOne(cm => cm.Mark)
                .WithMany(cmk => cmk.CarModels)
                .HasForeignKey(cm => cm.MarkId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
