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
        _context.Avaliacaos.Add(avaliacao);
        _context.SaveChanges();
        return Ok();
    }
}


