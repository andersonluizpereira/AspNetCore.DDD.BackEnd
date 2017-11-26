using System;
using System.Collections.Generic;
using System.Text;
using Integration.Domain.Entities.Models;
using Integration.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Integration.Infra.Data.Mapping.User
{
    public class UsuarioMap : EntityTypeConfiguration<Domain.Entities.Models.User>
    {
        public override void Map(EntityTypeBuilder<Domain.Entities.Models.User> builder)
        {
            builder.ToTable("Users");
            
            builder.Property(c => c.UserID)
                   .HasColumnType("varchar(20)")
                   .HasMaxLength(20);

            builder.Property(c => c.AccessKey)
                   .HasColumnType("varchar(1000)")
                   .HasMaxLength(1000);

        }
    }
}
