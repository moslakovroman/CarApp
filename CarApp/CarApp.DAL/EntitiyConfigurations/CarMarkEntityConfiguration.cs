using CarAppDAL.Constants;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarAppDAL.EntitiyConfigurations
{
    public class CarMarkEntityConfiguration : IEntityTypeConfiguration<CarMarkEntity>
    {
        public void Configure(EntityTypeBuilder<CarMarkEntity> builder)
        {
            builder.ToTable(DatabaseTableNames.Marks);
            builder.HasKey(cm => cm.Id);

            builder.Property(cm => cm.Name).HasMaxLength(50);
            builder.Property(cm => cm.CarModels).HasMaxLength(50);
        }
    }
}
