﻿using Biblioteca.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models.Contracts.Repositories
{
    public interface ILivroRepository
    {
        List<LivroDto> Listar();
    }
}
