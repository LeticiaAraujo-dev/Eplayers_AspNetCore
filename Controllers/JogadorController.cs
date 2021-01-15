using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Eplayers_AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eplayers_AspNetCore.Controllers
{
    public class JogadorController : Controller
    {
        Jogador jogadorModel = new Jogador();
        public IActionResult Index()
        {
            ViewBag.Jogadores = jogadorModel.ReadAll();
            return View();
        }
        [Route("Jogador")]
         public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador     = new Jogador();
            novoJogador.IdJogador   = int.Parse(form["IdJogador"]);
            novoJogador.Nome        = form["Nome"];
            novoJogador.Email       = form["Email"];
            novoJogador.Senha       = form["Senha"];

            jogadorModel.Create(novoJogador);            
            ViewBag.Jogadores = jogadorModel.ReadAll();

            return LocalRedirect("~/Jogador");
        }
        
    }
}