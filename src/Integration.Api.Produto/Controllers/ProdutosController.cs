using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integration.Application.Interfaces.Produtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Integration.CrossCuting.Tools.Json;
using Microsoft.AspNetCore.Authorization;

namespace Integration.Api.Produto.Controllers
{
    [Produces("application/json")]
    [Route("api/Produtos")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoApplication _iProdutoApplication;

        public ProdutosController(IProdutoApplication iProdutoApplication)
        {
            _iProdutoApplication = iProdutoApplication;
        }

        [Authorize("Bearer")]
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_iProdutoApplication.Get().ToJsonString());

        }

    }
}