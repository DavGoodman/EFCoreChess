using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreChess.Entities
{
    public class Player
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int? Rating { get; set; }


        [InverseProperty("BlackPlayer")]
        public List<ChessGame>? BlackGames { get; set; }


        [InverseProperty("WhitePlayer")]
        public List<ChessGame>? WhiteGames { get; set; }

        public List<PlayerChessTournament> PlayerChessTournaments { get; set; }

        //[NotMapped]
        //private List<ChessGame>? _allGames;

        //public List<ChessGame>? AllGames
        //{
        //    get
        //    {
        //        if (_allGames == null)
        //        {
        //            if (BlackGames == null && WhiteGames == null)

        //                _allGames = null;

        //            else if (BlackGames == null)
        //            {
        //                _allGames = WhiteGames;
        //            }
        //            else if (WhiteGames == null)
        //            {
        //                _allGames = BlackGames;
        //            }
        //            else
        //            {
        //                _allGames = BlackGames.Concat(WhiteGames).ToList();
        //            }
        //        }

        //        return _allGames;

        //    }
        //    set
        //    {
        //        _allGames = value;
        //    }

        //}


    }
}
