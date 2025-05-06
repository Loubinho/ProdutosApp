using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Entities
{
    /// <summary>
    /// Represents a product category model.
    /// </summary>
    public class Categoria
    {
        #region Properties
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }

        #endregion

        #region Relations
        public ICollection<Produto>? Produtos { get; set; }
        #endregion
    }
}
