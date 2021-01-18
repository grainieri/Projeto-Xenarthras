using ApiXenartras.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ApiXenartras.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class AparicaoController : ControllerBase
    {
        private int numeroDeRegistrosPorPagina = 50;
        private DatabaseContext _data;

        public AparicaoController(DatabaseContext data)
        {
            _data = data;
        }

        [HttpGet("MostrarAparicoes/")]
        public IEnumerable<Aparicao> MostrarAparicoes(int usu_ID, int numeroDaPagina)
        {
            return _data.Aparicoes.Where(a => a.usu_ID == usu_ID)
                .Skip(numeroDeRegistrosPorPagina * (numeroDaPagina - 1))
                .Take(numeroDeRegistrosPorPagina)
                .ToList<Aparicao>();
        }

        [HttpGet]
        public IActionResult MostrarAparicao(int apa_ID)
        {
            Aparicao aparicaoDB = _data.Aparicoes.FirstOrDefault(a => a.apa_ID == apa_ID);

            if (aparicaoDB == null)
            {
                return NotFound(); //Aparicao não encontrada.
            }
            return new JsonResult(aparicaoDB);
        }

        [HttpGet("Mostrar20UltimasAparicoes/{ani_Especie}")]
        public IEnumerable<Aparicao> Mostrar20UltimasAparicoes(string ani_Especie)
        {
            return _data.Aparicoes.Where(a => a.apa_Data >= DateTime.Now.AddDays(-20) &&
            a.ani_Especie == ani_Especie).ToList<Aparicao>();
        }

        [HttpPost]
        public IActionResult CadastrarAparicao(Aparicao aparicao)
        {
            //TODO - validação
            _data.Aparicoes.Add(aparicao);
            aparicao.apa_Data = DateTime.Now;
            aparicao.apa_Status = "Em análise";
            aparicao.ani_Especie = "Em análise";
            _data.SaveChanges();

            return CreatedAtAction(nameof(MostrarAparicao), new {
                aparicao });
        }

        [HttpPost("AtualizarAparicao/{apa_ID}")]
        public IActionResult AtualizarAparicao(Aparicao aparicao)
        {
            var aparicaoDados = _data.Aparicoes.First(aparicao => aparicao.apa_ID == aparicao.apa_ID);
            if (aparicaoDados != null)
            {
                aparicaoDados.apa_Comentario = aparicao.apa_Comentario;
                aparicaoDados.ani_Especie = aparicao.ani_Especie;
                aparicaoDados.apa_Status = aparicao.apa_Status;

                _data.SaveChanges();

                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("MostrarAparicoesPendentes/{numeroDaPagina}")]
        public IEnumerable<Aparicao> MostrarAparicoesPendentes(int numeroDaPagina)
        {
            return _data.Aparicoes.Where(a => a.apa_Status == "Em análise")
                .Skip(numeroDeRegistrosPorPagina * (numeroDaPagina - 1))
                .Take(numeroDeRegistrosPorPagina)
                .ToList<Aparicao>();
        }
    }
}
