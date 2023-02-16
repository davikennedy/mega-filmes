using AutoMapper;
using MegaFilmesAPI.Data;
using MegaFilmesAPI.Data.Dtos.DiretorDtos;
using MegaFilmesAPI.Data.Dtos.FilmeDtos;
using MegaFilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MegaFilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DiretorController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public DiretorController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarDiretor([FromBody] CreateDiretorDto diretorDto)
    {
        Diretor diretor = _mapper.Map<Diretor>(diretorDto);

        _context.Diretores.Add(diretor);
        _context.SaveChanges();
        
        return CreatedAtAction(nameof(RecuperarDiretorPorId), new { Id = diretor.Id }, diretor);
    }

    [HttpGet]
    public IEnumerable<Diretor> RecuperarDiretores([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _context.Diretores.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarDiretorPorId(int id)
    {
        var diretor = _context.Diretores.Find(id);

        if (diretor != null)
        {
            ReadDiretorDto diretorDto = _mapper.Map<ReadDiretorDto>(diretor);
            return Ok(diretorDto);
        }

        return NotFound();
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarDiretor(int id, [FromBody] UpdateDiretorDto diretorDto)
    {
        var diretor = _context.Diretores.Find(id);

        if (diretor == null) return NotFound();

        _mapper.Map(diretorDto, diretor);
        _context.SaveChanges();

        return NoContent();
    }
}
