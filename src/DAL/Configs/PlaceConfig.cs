using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class PlaceConfig : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Town).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Longitude).IsRequired();
            builder.Property(x => x.Latitude).IsRequired();
        }
    }
}
