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
    public IEnumerable<Filme> RecuperarFilmes()
    {
        return _filmes;
    }

    [HttpPut ("{id}")]

    public IActionResult AtualizarFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        var filme = _filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();

        //_mapper.Map(filmeDto, filme);
        // _context.SaveChanges();

         return NoContent(); 
    }
}
