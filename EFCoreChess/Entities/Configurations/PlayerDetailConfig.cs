using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreChess.Entities.Configurations
{
    public class PlayerDetailConfig : IEntityTypeConfiguration<PlayerDetail>
    {
        public void Configure(EntityTypeBuilder<PlayerDetail> builder)
        {
            builder.ToTable("Players");
        }
    }
}
