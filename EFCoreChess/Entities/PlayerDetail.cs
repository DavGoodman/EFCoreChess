using System.ComponentModel.DataAnnotations;

namespace EFCoreChess.Entities
{
    public class PlayerDetail
    {
        public int Id { get; set; }
        [Required]
        public int? Rating { get; set; }
        public string? MostPLayedOpening { get; set; }
        public string? Bio { get; set; }
        public Player Player { get; set; }

    }
}
