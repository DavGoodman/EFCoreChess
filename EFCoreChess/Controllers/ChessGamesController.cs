using AutoMapper;
using AutoMapper.QueryableExtensions;
using EFCoreChess.DTOs.GetDTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreChess.Controllers
{
    [ApiController]
    [Route("api/chessGames")]
    public class ChessGamesController : ControllerBase
    {

        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ChessGamesController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<ActionResult> Get()
        {
            var chessGames = await context.ChessGames
                .ProjectTo<ChessGameDTO>(mapper.ConfigurationProvider)
                .ToListAsync();

            if(chessGames == null) return NotFound();

            return Ok(chessGames);
        }

    }
}
