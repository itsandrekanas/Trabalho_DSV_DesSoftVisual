using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmeDB.Models
{
    public class Filme
    {
        public Filme() => CriadoEm = DateTime.Now;
        public int Id { get; set; }

        public string Nome { get; set; }

        public Genero Genero { get; set; }

        public int GeneroId { get; set; }

        public string Ano { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}