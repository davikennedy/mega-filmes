using AutoMapper;
using MegaFilmesAPI.Data.Dtos;
using MegaFilmesAPI.Models;

namespace MegaFilmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile() 
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
