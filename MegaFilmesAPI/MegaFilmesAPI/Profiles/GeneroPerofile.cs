using AutoMapper;
using MegaFilmesAPI.Data.Dtos.GeneroDtos;
using MegaFilmesAPI.Models;

namespace MegaFilmesAPI.Profiles
{
    public class GeneroPerofile : Profile 
    {
        public GeneroPerofile()
        {
            CreateMap<CreateGeneroDto, Genero>();
            CreateMap<Genero, ReadGeneroDto>();
            CreateMap<UpdateGeneroDto, Genero>();
        }

    }
}
