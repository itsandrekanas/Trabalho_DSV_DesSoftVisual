using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmeDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmeDB.Controllers
{
      [ApiController]
    [Route("api/generos")]
    public class GeneroController : ControllerBase
    {
        private readonly DataContext _context;
        public GeneroController(DataContext context) =>
            _context = context;

        //POST: api/generos/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Genero genero)
        {
            _context.Generos.Add(genero);
            _context.SaveChanges();
            return Created("Genero cadastrado com sucesso!", genero);
        }

        //GET: api/generos/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Generos.ToList());

        
        // PATCH: /api/atores/alterar

        // DELETE: /api/atores/deletar/{id}
        
    }
}