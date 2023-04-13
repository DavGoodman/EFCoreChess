using AutoMapper;
using AutoMapper.QueryableExtensions;
using EFCoreChess.DTOs.GetDTOs;
using EFCoreChess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreChess.Controllers
{
    [ApiController]
    [Route("api/players")]
    public class PlayersController : ControllerBase
    {

        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PlayersController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("All")]
        public async Task<ActionResult> Get()
        {
            var players = await context.Players
                .ToListAsync();

            if(players == null) return NotFound();
            return Ok(players);
        }

        [HttpGet("Filter")]
        public async Task<IEnumerable<Player>> Get(string name)
        {
            var players = await context.Players
                .Where(p => p.Name.Contains(name))
                .ToListAsync();

            return players;
        }

        [HttpGet("WithGames/{id:int}")]
        public async Task<ActionResult> GetWithGames(int id)
        {
            var player = await context.Players
                .ProjectTo<PlayerWithGamesDTO>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(p => p.Id == id);

            if(player == null) return NotFound();
            return Ok(player);
        }

    }
}
