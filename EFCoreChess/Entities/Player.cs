using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreChess.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        [InverseProperty("BlackPlayer")]
        public List<ChessGame>? BlackGames { get; set; }

        [InverseProperty("WhitePlayer")]
        public List<ChessGame>? WhiteGames { get; set; }

        public List<ChessGame>? AllGames
        {
            get
            {
                if (BlackGames == null && WhiteGames == null) return null;
                if (BlackGames == null) return WhiteGames;
                if (WhiteGames == null) return BlackGames;
                
                var games = BlackGames.Concat(WhiteGames).ToList();
                return games;
            }

        }

        public int? Rating { get; set; }

    }
}
