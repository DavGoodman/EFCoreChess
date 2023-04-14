using Microsoft.EntityFrameworkCore;
using System.Reflection;
using EFCoreChess.Entities;
using EFCoreChess.Entities.Seeding;

namespace EFCoreChess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<string>().HaveMaxLength(120);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            modelBuilder.Entity<ChessGame>()
                .HasOne(p => p.WhitePlayer)
                .WithMany(p => p.WhiteGames)
                .HasForeignKey(p => p.WhitePlayerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChessGame>()
                .HasOne(p => p.BlackPlayer)
                .WithMany(p => p.BlackGames)
                .HasForeignKey(p => p.BlackPlayerId)
                .OnDelete(DeleteBehavior.Restrict);


            InitialSeeding.Seed(modelBuilder);
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<ChessGame> ChessGames { get; set; }
        public DbSet<ChessTournament> ChessTournaments { get; set; }
        public DbSet<PlayerChessTournament> PlayerChessTournaments { get; set; }

    }
}
