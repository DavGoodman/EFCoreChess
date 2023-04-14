namespace EFCoreChess.Entities
{
    public class ChessTournament
    { 
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public List<ChessGame> Games { get; set; }
        public List<PlayerChessTournament> PlayerChessTournaments { get; set; }



    }
}
