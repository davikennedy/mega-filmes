using AutoMapper;
using MegaFilmesAPI.Data.Dtos.AvaliacaoDtos;
using MegaFilmesAPI.Models;

namespace MegaFilmesAPI.Profiles
{
    public class AvaliacaoProfile :Profile
    {
        public AvaliacaoProfile() 
        {
            CreateMap<CreateAvaliacaoDto, Avaliacao>();
            CreateMap<Avaliacao, ReadAvaliacaoDto>();
        }
    }
}
