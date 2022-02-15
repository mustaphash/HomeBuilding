using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class BrigadeConfig : IEntityTypeConfiguration<Brigade>
    {
        public void Configure(EntityTypeBuilder<Brigade> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
