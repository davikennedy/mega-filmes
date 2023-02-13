﻿using AutoMapper;
using MegaFilmesAPI.Data;
using MegaFilmesAPI.Data.Dtos;
using MegaFilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MegaFilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> AdicionarFilme([FromBody] CreateFilmeDto filmeDto)
    {
        Filme filme = _mapper.Map<Filme>(filmeDto);

        bool novoFilme = !_context.Filmes.Any(f => f.Nome.ToUpper() == filme.Nome.ToUpper());

        if (novoFilme)
        {
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarFilmePorId), new { Id = filme.Id }, filme);
        }

        return Conflict("Já existe um filme com mesmo nome");





        /*Filme filme = _mapper.Map<Filme>(filmeDto);

        if (await _context.Filmes.AnyAsync(f => f.Nome.ToUpper() == filme.Nome.ToUpper()))
        {
            return Conflict("Já existe um filme com mesmo nome");
        }

        _context.Filmes.Add(filme);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(RecuperarFilmePorId), new { Id = filme.Id}, filme);*/
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperarFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _context.Filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarFilmePorId(int id)
    {
        var filme = _context.Filmes.Find(id);
        
        if(filme != null)
        {
            ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);
            return Ok(filmeDto);
        }

        return NotFound();
    }

    [HttpPut ("{id}")]
    public IActionResult AtualizarFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        var filme = _context.Filmes.Find(id);

        if (filme == null) return NotFound();

        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();

         return NoContent(); 
    }

    [HttpDelete("{id}")]
    public IActionResult RemoverFilme(int id)
    {
        var filme = _context.Filmes.Find(id);

        if (filme == null) return NotFound();

        _context.Remove(filme);
        _context.SaveChanges();

        return NoContent();
    }
}
