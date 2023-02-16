using AutoMapper;
using MegaFilmesAPI.Data;
using MegaFilmesAPI.Data.Dtos.ElencoDtos;
using MegaFilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MegaFilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ElencoController :ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public ElencoController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaElenco([FromBody] CreateElencoDto elencoDto)
    {
        Elenco elenco = _mapper.Map<Elenco>(elencoDto);
        _context.Elencos.Add(elenco);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarElencoPorId), new { Id = elenco.Id }, elenco);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarElencoPorId(int id)
    {
        var elenco = _context.Elencos.Find(id);

        if (elenco != null)
        {
            ReadElencoDto elencoDto = _mapper.Map<ReadElencoDto>(elenco);
            return Ok();
        }

        return NotFound();
    }
}
