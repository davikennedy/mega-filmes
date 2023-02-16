using AutoMapper;
using MegaFilmesAPI.Data.Dtos.DiretorDtos;
using MegaFilmesAPI.Data;
using MegaFilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using MegaFilmesAPI.Data.Dtos.GeneroDtos;
using MegaFilmesAPI.Data.Dtos.FilmeDtos;

namespace MegaFilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GeneroController :ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public GeneroController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarGenero([FromBody] CreateGeneroDto generoDto)
    {
        Genero genero = _mapper.Map<Genero>(generoDto);

        _context.Generos.Add(genero);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarGeneroPorId), new { id = genero.Id }, genero);
      
    }

    [HttpGet]
    public IEnumerable<ReadGeneroDto> RecuperarGeneros([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _mapper.Map<List<ReadGeneroDto>>(_context.Generos.Skip(skip).Take(take).ToList());
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarGeneroPorId(int id)
    {
        var genero = _context.Generos.Find(id);

        if (genero != null)
        {
            ReadGeneroDto generoDto = _mapper.Map<ReadGeneroDto>(genero);
            return Ok(generoDto);
        }

        return NotFound();
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarGenero(int id, [FromBody] UpdateGeneroDto generoDto)
    {
        var genero = _context.Generos.Find(id);

        if (genero == null) return NotFound();

        _mapper.Map(generoDto, genero);
        _context.SaveChanges();

        return NoContent();
    }

}
