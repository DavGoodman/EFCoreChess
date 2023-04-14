using AutoMapper;
using AutoMapper.QueryableExtensions;
using EFCoreChess.DTOs.GetDTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreChess.Controllers
{
    public class ChessTournamentController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ChessTournamentController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetWithPlayers(int id)
        {
            var tourney = await context.ChessTournaments
                .ProjectTo<ChessTournamentDTO>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(t => t.Id == id);

            if(tourney == null) return NotFound();
            return Ok(tourney);
        }
    }
}
