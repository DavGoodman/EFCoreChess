namespace EFCoreChess.DTOs.GetDTOs
{
    public class PlayerWithGamesDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int? Rating { get; set; }
        public List<ChessGameDTO> Games { get; set; }
    }
}
