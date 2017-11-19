using Integration.Domain.Entities.Interfaces;
using Integration.Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Integration.Domain.Entities.Interfaces.Produtos;
using Integration.Infra.Data.Contexts;
using Integration.Infra.Data.Implementations.Produtos;
using Integration.Application.Implementations.Produtos;
using Integration.Application.Interfaces.Produtos;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using Integration.Application.Implementations.Usuarios;
using Integration.Application.Interfaces.Usuarios;
using Integration.Domain.Entities.Interfaces.Usuarios;
using Integration.Infra.Data.Implementations.Usuarios;
using Integration.CrossCuting.Tools.Jwt;

namespace Integration.Ioc
{
    public class SimpleInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            
            //Repository
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IProdutoApplication, ProdutoApplication>();

            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            services.AddTransient<IUsuarioApplication, UsuarioApplication>();

            //Context
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<Context>();
        }
    }
}
