using Biblioteca.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models.Contracts.Services
{
    public interface ILivroService
    {
        List<LivroDto> Listar();
    }
}
