using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebXenartras.Models;

namespace WebXenartras.Controllers
{
    public class UsuarioController : Controller
    {
        string BaseApiUrl = "https://apixenartras20201126021930.azurewebsites.net/";

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult GetMostrarUsuario()
        {
            return View();
        }

        public ViewResult MostrarUsuario() => View();

        [HttpGet]
        public async Task<IActionResult> MostrarUsuario(string usu_Email)
        {
            Usuario usuario = new Usuario();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"{BaseApiUrl}api/Usuario/BuscarUsuario/?usu_Email={usu_Email}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    usuario = JsonConvert.DeserializeObject<Usuario>(apiResponse);
                }
            }
            return View(usuario);
        }
    }
}
