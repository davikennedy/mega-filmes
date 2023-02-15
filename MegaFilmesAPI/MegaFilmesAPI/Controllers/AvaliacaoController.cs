using AutoMapper;
using MegaFilmesAPI.Data;
using MegaFilmesAPI.Data.Dtos;
using MegaFilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MegaFilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AvaliacaoController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;
    private static int id = 0;

    public AvaliacaoController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AvaliaFilme( [FromBody] CreateAvaliacaoDto avaliacaoDto)
    {
        Avaliacao avaliacao = _mapper.Map<Avaliacao>(avaliacaoDto);
        _context.Avaliacoes.Add(avaliacao);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarAvaliacaoPorId), new { Id = avaliacao.Id }, avaliacao);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarAvaliacaoPorId(int id)
    {
        var avaliacao = _context.Elencos.Find(id);

        if (avaliacao != null)
        {
            ReadAvaliacaoDto avaliacaoDto = _mapper.Map<ReadAvaliacaoDto>(avaliacao);
            return Ok();
        }

        return NotFound();
    }
}


