using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface for the category repository.
    /// </summary>
    public interface ICategoriaRepository : IBaseRepository<Entities.Categoria, Guid>
    {
    }
}
