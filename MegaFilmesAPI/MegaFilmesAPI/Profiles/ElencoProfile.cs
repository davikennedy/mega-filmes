using AutoMapper;
using MegaFilmesAPI.Data.Dtos.ElencoDtos;
using MegaFilmesAPI.Models;

namespace MegaFilmesAPI.Profiles
{
    public class ElencoProfile : Profile
    {
        public ElencoProfile() 
        {
            CreateMap<CreateElencoDto, Elenco>();
            CreateMap<Elenco, ReadElencoDto>();
        }
    }
}
