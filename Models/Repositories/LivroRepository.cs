using Biblioteca.Models.Contracts.Repositories;
using Biblioteca.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public void Registar(LivroDto livro)
        {
            ContextDataFake.Livros.Add(livro);
        }

        public List<LivroDto> Listar()
        {
            var livros = ContextDataFake.Livros;
            return livros
                    .OrderBy(p => p.Nome)
                    .ToList();

        }

        
    }
}
