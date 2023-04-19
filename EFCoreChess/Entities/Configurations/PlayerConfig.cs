using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreChess.Entities.Configurations
{
    public class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasOne(p => p.PlayerDetail).WithOne(p => p.Player).HasForeignKey<PlayerDetail>(pd => pd.Id);
        }
    }
}
