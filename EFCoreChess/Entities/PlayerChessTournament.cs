namespace EFCoreChess.Entities
{
    public class PlayerChessTournament
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int ChessTournamentId { get; set; }
        public ChessTournament ChessTournament { get; set; }
        public int Place { get; set; }
    }
}
