namespace EFCoreChess.DTOs.GetDTOs
{
    public class ChessTournamentDTO
    {
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public List<PlayerTournamentDTO> Players { get; set; }
        public List<ChessGameDTO> Games { get; set; }

    }
}
