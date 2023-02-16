using AutoMapper;
using MegaFilmesAPI.Data.Dtos.DiretorDtos;
using MegaFilmesAPI.Models;

namespace MegaFilmesAPI.Profiles
{
    public class DiretorProfile : Profile
    {
        public DiretorProfile() 
        {
            CreateMap<CreateDiretorDto, Diretor>();
            CreateMap<Diretor, ReadDiretorDto>();
            CreateMap<UpdateDiretorDto, Diretor>();
        }
    }
}
