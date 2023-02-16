using AutoMapper;
using MegaFilmesAPI.Data.Dtos.GeneroDtos;
using MegaFilmesAPI.Models;

namespace MegaFilmesAPI.Profiles
{
    public class GeneroProfile : Profile 
    {
        public GeneroProfile()
        {
            CreateMap<CreateGeneroDto, Genero>();
            CreateMap<Genero, ReadGeneroDto>();
            CreateMap<UpdateGeneroDto, Genero>();
        }
    }
}
