using AutoMapper;
using MegaFilmesAPI.Data.Dtos.FilmeDtos;
using MegaFilmesAPI.Models;

namespace MegaFilmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile() 
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>()
                .ForMember(filmeDto => filmeDto.Diretor,
                opt => opt.MapFrom(filme => filme.Diretor));
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
