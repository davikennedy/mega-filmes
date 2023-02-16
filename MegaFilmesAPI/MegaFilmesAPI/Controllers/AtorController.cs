using AutoMapper;
using MegaFilmesAPI.Data;
using MegaFilmesAPI.Data.Dtos.AtorDtos;
using MegaFilmesAPI.Data.Dtos.AvaliacaoDtos;
using MegaFilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MegaFilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class AtorController : ControllerBase 
{
    private FilmeContext _context;
    private IMapper _mapper;

    public AtorController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarAtor([FromBody] CreateAtorDto atorDto)
    {
        Ator ator = _mapper.Map<Ator>(atorDto);
        _context.Atores.Add(ator);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarAtorPorId), new { Id = ator.Id }, ator);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarAtorPorId(int id)
    {
        var ator = _context.Atores.Find(id);

        if (ator != null)
        {
            ReadAtorDto atorDto = _mapper.Map<ReadAtorDto>(ator);
            return Ok();
        }

        return NotFound();
    }
}
    

