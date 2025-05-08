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
    /// Mapping class for the Produto entity.
    /// </summary>
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            // Table
            builder.ToTable("Produtos");

            // Primary Key
            builder.HasKey(p => p.Id);

            // Properties
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(p => p.Preco)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.Quantidade)
                .IsRequired();

            builder.Property(p => p.DataHoraCriacao)
                  .HasColumnType("datetime")
                  .IsRequired();

            builder.Property(p => p.Ativo)
                .IsRequired();

            builder.Property(p => p.CategoriaId)
                .IsRequired();

            // Relationships
            builder.HasOne(p => p.Categoria) // Define the relationship with Categoria 
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId);
        }
    }
}
