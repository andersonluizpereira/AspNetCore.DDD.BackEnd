using Integration.Application.Implementations.Produtos;
using Integration.Application.Implementations.Usuarios;
using Integration.Application.Interfaces.Produtos;
using Integration.Application.Interfaces.Usuarios;
using Integration.CrossCuting.Tools.Jwt;
using Integration.Domain.Entities.Interfaces;
using Integration.Domain.Entities.Interfaces.Produtos;
using Integration.Domain.Entities.Interfaces.Usuarios;
using Integration.Domain.Entities.Models;
using Integration.Infra.Data.Contexts;
using Integration.Infra.Data.Implementations.Produtos;
using Integration.Infra.Data.Implementations.Usuarios;
using Integration.Infra.Data.UoW;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using Microsoft.AspNetCore.Authorization;


namespace Integration.Ioc
{
    public class SimpleInjectorBootStrapper
    {
        public static IConfiguration Configuration { get; }
        
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
