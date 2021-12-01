using Biblioteca.Models.Contracts.Services;
using Biblioteca.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            try
            {
                var livros = _livroService.Listar();
                return View(livros);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public ActionResult Create() // quando carregar no create , é mandada para a
        {
            return View();
        }
         
        [HttpPost]   // não podemos ter metodos com o mesmo nome, mas é válido com assinaturas diferentes
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Nome, Autor, Editora")] LivroDto livro)
        {
            try
            {
                _livroService.Registar(livro);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                throw ex;
            }
 
        }
    }
}
