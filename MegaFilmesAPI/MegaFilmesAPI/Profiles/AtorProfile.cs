using AutoMapper;
using MegaFilmesAPI.Data.Dtos.AtorDtos;
using MegaFilmesAPI.Models;

namespace MegaFilmesAPI.Profiles
{
    public class AtorProfile :Profile 
    {
        public AtorProfile() 
        {
            CreateMap<CreateAtorDto, Ator>();
            CreateMap<Ator, ReadAtorDto>();
        }
    }
}
