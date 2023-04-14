using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreChess.Entities.Configurations
{
    public class PlayerChessTournamentConfig : IEntityTypeConfiguration<PlayerChessTournament>
    {
        public void Configure(EntityTypeBuilder<PlayerChessTournament> builder)
        {
            builder.HasKey(x => new { x.PlayerId, x.ChessTournamentId });

          
        }
    }
}

