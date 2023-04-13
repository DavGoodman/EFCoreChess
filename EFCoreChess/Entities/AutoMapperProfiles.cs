using AutoMapper;
using EFCoreChess.DTOs.GetDTOs;

namespace EFCoreChess.Entities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // GET DTOs
            CreateMap<ChessGame, ChessGameDTO>()
                .ForMember(dto => dto.WhitePlayer, ent => ent.MapFrom(src => src.WhitePlayer.Name))
                .ForMember(dto => dto.BlackPlayer, ent => ent.MapFrom(src => src.BlackPlayer.Name))
                .ForMember(ent => ent.Winner, ent =>
                    ent.MapFrom(src => src.WinnerId == null
                        ? null
                        : src.WinnerId == src.BlackPlayerId
                        ? src.BlackPlayer.Name : src.WhitePlayer.Name))
                .ForMember(ent => ent.Date, ent => ent.MapFrom(src => src.Date.ToString("yyyy-mm-dd")));

            CreateMap<Player, PlayerWithGamesDTO>()
                .ForMember(dto => dto.Games, ent =>
                    ent.MapFrom(src => src.WhiteGames.Union(src.BlackGames)));

            // POST DTOs




            // PUT DTOs

        }

    }
}
