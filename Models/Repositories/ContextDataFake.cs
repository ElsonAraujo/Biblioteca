using Biblioteca.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models.Repositories
{
    public class ContextDataFake
    {
        public static List<LivroDto> Livros;

        static ContextDataFake()
        {
            Livros = new List<LivroDto>();
            InitializeData();
        }

        private static void InitializeData()
        {
            var livro = new LivroDto("Implementando Domain Driven Design", "Vaugh Vernon", "Alta Books" );
            Livros.Add(livro);

            livro = new LivroDto(" Domain Driven Design", "Eric Evans", "Alta Books" );
            Livros.Add(livro);

            livro = new LivroDto("Redes Guia Prático", "Carlos E. Morimoto", "Sul Editores" );
            Livros.Add(livro);

            livro = new LivroDto("PHP Programando com Orientação a Objetos", "Pablo ", "Alta Books" );
            Livros.Add(livro);

            livro = new LivroDto("Introdução a programar Pithon", "Vaugh Vernon", "NovaTech" );
            Livros.Add(livro);

        }
    }
}
