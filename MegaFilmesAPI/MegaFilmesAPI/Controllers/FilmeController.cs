using MegaFilmesAPI.Data.Dtos;
using MegaFilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MegaFilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> _filmes = new List<Filme>();

    [HttpPost]
    public void AdicionarFilme([FromBody] Filme filme)
    //public IActionResult Post([FromBody] Filme filme)
    {
        bool novoFilme = !_filmes.Any(f => f.Nome.ToUpper() == filme.Nome.ToUpper());

        if (novoFilme)
        {
            _filmes.Add(filme);
            //return CreatedAtAction();
        }

        //return Conflict("Já existe um filme com mesmo nome");
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperarFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarFilmePorId(int id)
    {
        var filme = _filmes.FirstOrDefault(filme => filme.Id == id);
        
        if(filme != null)
        {
            //ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);
            return Ok(filme);
        }
        return NotFound();
    }

    [HttpPut ("{id}")]
    public IActionResult AtualizarFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        var filme = _filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();

        //_mapper.Map(filmeDto, filme);
        //_context.SaveChanges();

         return NoContent(); 
    }
}
