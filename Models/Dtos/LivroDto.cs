using Biblioteca.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models.Dtos
{
    public class LivroDto : EntidadeBase  // DataTransferObjects
    {

        // public string Id { get; set; } não mais necessário visto ter a classe id a gerar automaticamente 
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }

        public LivroDto()
        {
            
        }
        //construtores
        public LivroDto(string id, string nome, string autor, string editora)
            :this(nome, autor, editora)
        {
            this.Id = id;
        }
       
        public LivroDto(string nome, string autor, string editora)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Editora = editora;

        }
    }
}
