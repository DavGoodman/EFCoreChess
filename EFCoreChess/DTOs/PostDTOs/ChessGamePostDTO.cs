namespace EFCoreChess.DTOs.PostDTOs
{
    public class ChessGamePostDTO
    {
        public int WhitePlayerId { get; set; }
        public int BlackPlayerId { get; set; }
        public DateTime Date { get; set; }
        public int WinnerId { get; set; }
    }
}
