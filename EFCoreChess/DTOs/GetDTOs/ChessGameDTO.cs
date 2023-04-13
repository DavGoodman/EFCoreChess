namespace EFCoreChess.DTOs.GetDTOs
{
    public class ChessGameDTO
    {
        public int Id { get; set; }
        public string WhitePlayer { get; set; }
        public string BlackPlayer { get; set; }
        public string Winner { get; set; }
        public string Date { get; set; }
    }
}
