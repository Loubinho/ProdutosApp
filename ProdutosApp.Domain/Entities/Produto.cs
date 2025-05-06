using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Entities
{
    /// <summary>
    /// Represents a product model.
    /// </summary>
    public class Produto
    {
        #region Properties
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public DateTime? DataHoraCriacao { get; set; } // DateOnly + TimeSpan
        public bool? Ativo { get; set; }
        public Guid? CategoriaId  { get; set; }
        #endregion

        #region Relations
        public Categoria? Categoria { get; set; }
        #endregion
    }
}
