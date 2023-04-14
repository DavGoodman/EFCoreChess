using Microsoft.EntityFrameworkCore;

namespace EFCoreChess.Entities.Seeding
{
    public class InitialSeeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var MagnusCarlsen = new Player { Id = 1, Name = "Magnus Carlsen", Country = "Norway", Rating = 2870 };
            var FabianoCaruana = new Player { Id = 2, Name = "Fabiano Caruana", Country = "USA", Rating = 2822 };
            var HikaruNakamura = new Player { Id = 3, Name = "Hikaru Nakamura", Country = "USA", Rating = 2780 };
            var LevyRossman = new Player { Id = 4, Name = "Levy Rossman", Country = "USA", Rating = 2400 };

            modelBuilder.Entity<Player>().HasData(MagnusCarlsen, FabianoCaruana, HikaruNakamura, LevyRossman);


            var ChessGame1 = new ChessGame
            {
                Id = 1, 
                WhitePlayerId = MagnusCarlsen.Id, 
                BlackPlayerId = HikaruNakamura.Id,
                WinnerId = MagnusCarlsen.Id, 
                Date = new DateTime(2012, 05, 11)
            };

            var ChessGame2 = new ChessGame
            {
                Id = 2,
                WhitePlayerId = HikaruNakamura.Id,
                BlackPlayerId = MagnusCarlsen.Id,
                WinnerId = HikaruNakamura.Id,
                Date = new DateTime(2013, 02, 12)
            };

            var ChessGame3 = new ChessGame
            {
                Id = 3,
                WhitePlayerId = HikaruNakamura.Id,
                BlackPlayerId = LevyRossman.Id,
                WinnerId = HikaruNakamura.Id,
                Date = new DateTime(2020, 01, 02)
            };

            var ChessGame4 = new ChessGame
            {
                Id = 4,
                WhitePlayerId = FabianoCaruana.Id,
                BlackPlayerId = MagnusCarlsen.Id,
                WinnerId = MagnusCarlsen.Id,
                Date = new DateTime(2021, 11, 04)
            };


            modelBuilder.Entity<ChessGame>().HasData(ChessGame1, ChessGame2, ChessGame3, ChessGame4);


            var ChessTournament1 = new ChessTournament
            {
                Id = 1,
                TournamentName = "Goodman Chess Tournament",
            };

            modelBuilder.Entity<ChessTournament>().HasData(ChessTournament1);

            var ChessGame5 = new ChessGame
            {
                Id = 5,
                WhitePlayerId = FabianoCaruana.Id,
                BlackPlayerId = HikaruNakamura.Id,
                WinnerId = FabianoCaruana.Id,
                Date = new DateTime(2023, 03, 11),
                ChessTournamentId = 1
            };

            var ChessGame6 = new ChessGame
            {
                Id = 6,
                WhitePlayerId = MagnusCarlsen.Id,
                BlackPlayerId = FabianoCaruana.Id,
                WinnerId = MagnusCarlsen.Id,
                Date = new DateTime(2023, 03, 11),
                ChessTournamentId = 1

            };

            var ChessGame7 = new ChessGame
            {
                Id = 7,
                WhitePlayerId = HikaruNakamura.Id,
                BlackPlayerId = FabianoCaruana.Id,
                WinnerId = HikaruNakamura.Id,
                Date = new DateTime(2023, 03, 11),
                ChessTournamentId = 1

            };

            var ChessGame8 = new ChessGame
            {
                Id = 8,
                WhitePlayerId = HikaruNakamura.Id,
                BlackPlayerId = MagnusCarlsen.Id,
                WinnerId = MagnusCarlsen.Id,
                Date = new DateTime(2023, 03, 11),
                ChessTournamentId = 1
            };


            modelBuilder.Entity<ChessGame>().HasData(ChessGame5, ChessGame6, ChessGame7, ChessGame8);

            var PlayerTournament1 = new PlayerChessTournament
            {
                PlayerId = MagnusCarlsen.Id,
                ChessTournamentId = ChessTournament1.Id,
                Place = 1
            };

            var PlayerTournament2 = new PlayerChessTournament
            {
                PlayerId = HikaruNakamura.Id,
                ChessTournamentId = ChessTournament1.Id,
                Place = 2
            };

            var PlayerTournament3 = new PlayerChessTournament
            {
                PlayerId = FabianoCaruana.Id,
                ChessTournamentId = ChessTournament1.Id,
                Place = 3
            };

            modelBuilder.Entity<PlayerChessTournament>().HasData(PlayerTournament1, PlayerTournament2, PlayerTournament3);

        }
    }
}
