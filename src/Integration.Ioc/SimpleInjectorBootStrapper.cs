﻿using Integration.Domain.Entities.Interfaces;
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

            //Context
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<Context>();
        }
    }
}
