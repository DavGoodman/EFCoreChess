namespace EFCoreChess.Entities
{
    public class ChessGame
    {
        public int Id { get; set; } 
        public int WhitePlayerId { get; set; }
        public Player WhitePlayer { get; set; }
        public int BlackPlayerId { get; set; }
        public Player BlackPlayer { get; set; }
        public DateTime Date { get; set; }
        public int WinnerId { get; set; }
        public ChessTournament? ChessTournament { get; set; }
        public int? ChessTournamentId { get; set; }
    }
}
