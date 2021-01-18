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
    public class UsuarioController : ControllerBase
    {
        private int numeroDeRegistrosPorPagina = 5;
        private DatabaseContext _data;
        public UsuarioController(DatabaseContext data)
        {
            _data = data;
        }

        [HttpGet("BuscarUsuario/")]
        public IActionResult BuscarUsuario(string usu_Email)
        {
            Usuario usuarioDB = _data.Usuarios.FirstOrDefault(a => a.usu_Email == usu_Email);

            if (usuarioDB == null)
            {
                return NotFound(); //Usuário não encontrado.
            }
            return new JsonResult(usuarioDB);
        }

        [HttpGet("PesquisarUsuario/")]
        public IEnumerable<Usuario> PesquisarUsuario(string usu_Email, int numeroDaPagina)
        {
            return _data.Usuarios.Where(a => a.usu_Email.ToLower() == usu_Email.ToLower())
                .Skip(numeroDeRegistrosPorPagina * (numeroDaPagina - 1))
                .Take(numeroDeRegistrosPorPagina)
                .ToList<Usuario>();
        }

        [HttpGet]
        public IActionResult LoginUsuario(string usu_Email, string usu_Senha)
        {
            Usuario usuarioDB = _data.Usuarios.FirstOrDefault(a => a.usu_Email == usu_Email && a.usu_Senha == usu_Senha);

            if (usuarioDB == null)
            {
                return NotFound(); //Usuário não encontrado.
            }
            return new JsonResult(usuarioDB);
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario) 
        {
            //TODO - validação
            _data.Usuarios.Add(usuario);
            usuario.usu_Status = false;
            _data.SaveChanges();
            return CreatedAtAction(nameof(LoginUsuario), new { usu_ID = usuario.usu_ID, usu_Email = usuario.usu_Email, usu_Senha = usuario.usu_Senha });
        }
    }
}
