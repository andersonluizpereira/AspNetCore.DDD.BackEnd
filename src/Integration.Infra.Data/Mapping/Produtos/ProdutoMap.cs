using System;
using System.Collections.Generic;
using System.Text;

using Integration.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Integration.Domain.Entities.Models;

namespace Integration.Infra.Data.Mapping.Produtos
{
    public class ProdutoMap : EntityTypeConfiguration<ProdutosViewModel>
    {
        public override void Map(EntityTypeBuilder<ProdutosViewModel> builder)
        {
            builder.ToTable("Produtos");

            builder.Property(c => c.Id)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(c => c.Descricao)
                   .HasColumnType("varchar(150)")
                   .HasMaxLength(150);

            builder.Property(c => c.Preco)
                   .HasColumnType("decimal(18,2)");

        }
    }
}
