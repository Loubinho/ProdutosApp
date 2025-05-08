using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Infra.Data.Mappings
{
    /// <summary>
    /// Mapping class for the Categoria entity.
    /// </summary>
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            // Table
            builder.ToTable("Categorias");

            // Primary Key
            builder.HasKey(c => c.Id);

            // Properties
            builder.Property(c => c.Nome)
                .HasColumnName("Nome") // Specify the column name in the database if different
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(c => c.Nome)
                .IsUnique()
                .HasDatabaseName("IX_Categoria_Nome"); // Specify the index name 

            // Relationships
            builder.HasMany(c => c.Produtos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.CategoriaId);
        }
    }
}
