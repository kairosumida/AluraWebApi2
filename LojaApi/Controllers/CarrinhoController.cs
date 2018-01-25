using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaApi.DAO;
using LojaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Carrinho")]
    public class CarrinhoController : Controller
    {
        [HttpGet("{id}")]
        public Carrinho Get(int id)
        {
            CarrinhoDAO dao = new CarrinhoDAO();
            Carrinho carrinho = dao.Busca(id);
            return carrinho;
       }
        [HttpPost]
        public string Post([FromBody]Carrinho carrinho)
        {
            CarrinhoDAO dao = new CarrinhoDAO();
            dao.Adiciona(carrinho);
            return "sucesso";
        }
    }
}