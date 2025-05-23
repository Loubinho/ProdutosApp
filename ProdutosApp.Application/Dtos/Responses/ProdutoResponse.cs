﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Application.Dtos.Responses
{
    public class ProdutoResponse
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public Guid? CategoriaId { get; set; }
    }
}

