using Integration.Domain.Entities.Models;
using Integration.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Integration.Infra.Data.Mapping.Produtos;
using Integration.Infra.Data.Mapping.User;

namespace Integration.Infra.Data.Contexts
{
    public class Context : DbContext
    {
        public virtual DbSet<ProdutosViewModel> Produtos { get; set; }
        public virtual DbSet<UserViewModel> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new ProdutoMap());
            modelBuilder.AddConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        // get the configuration from the app settings
        var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

    }
}
