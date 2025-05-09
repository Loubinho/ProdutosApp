using Microsoft.EntityFrameworkCore;
using ProdutosApp.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Infra.Data.Contexts
{
    /// <summary>
    /// Represents the database context for the application with Entity Framework Core.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Constructor for the DataContext class.
        /// </summary>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        /// <summary>
        /// DbSet for the Produto entity.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());

            // Apply the mappings
            base.OnModelCreating(modelBuilder);
        }
    }
}
