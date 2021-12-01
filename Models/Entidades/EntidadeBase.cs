﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models.Entidades
{
    public abstract class EntidadeBase
    {
        public string Id{get; set; }
        
        public EntidadeBase()
        {
            Id = Guid.NewGuid().ToString();
        }

    }
}
