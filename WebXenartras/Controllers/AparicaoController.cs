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
    public class AparicaoController : Controller
    {
        string BaseApiUrl = "https://apixenartras20201126021930.azurewebsites.net/";
        HttpClient client;
        Uri aparicaoUri;

        public ActionResult MostrarAparicoesPendentes()
        {
            List<Aparicao> listaAparicao = GetMostrarAparicoesPendentes().ToList();
            return View(listaAparicao);
        }

        public ActionResult GetMostrarAparicao()
        {
            return View();
        }

        private IEnumerable<Aparicao> GetMostrarAparicoesPendentes()
        {
            client = new HttpClient();
            HttpResponseMessage response = client.GetAsync($"{BaseApiUrl}api/Aparicao/MostrarAparicoesPendentes/1").Result;

            aparicaoUri = response.Headers.Location;

            var aparicaos = response.Content.ReadAsAsync<IEnumerable<Aparicao>>().Result;

            return aparicaos;
        }

        public ViewResult MostrarAparicao() => View();

        [HttpGet]
        public async Task<IActionResult> MostrarAparicao(int apa_ID)
        {
            Aparicao aparicao = new Aparicao();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"{BaseApiUrl}/api/Aparicao/?apa_ID={apa_ID}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    aparicao = JsonConvert.DeserializeObject<Aparicao>(apiResponse);
                }
            }
            return View(aparicao);
        }


        public async Task<IActionResult> AtualizarAparicao(int apa_ID)
        {
            Aparicao aparicao = new Aparicao();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"{BaseApiUrl}api/Aparicao/AtualizarAparicao/{apa_ID}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    aparicao = JsonConvert.DeserializeObject<Aparicao>(apiResponse);
                }
            }
            return View(aparicao);
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarAparicao(Aparicao aparicao)
        {
            Aparicao aparicaoRecebida = new Aparicao();
            using (var httpClient = new HttpClient())
            {
                var aparicaoDados = new MultipartFormDataContent();
                aparicaoDados.Add(new StringContent(aparicao.apa_ID.ToString()), "ID: ");
                aparicaoDados.Add(new StringContent(aparicao.apa_Comentario), "Comentário: ");
                aparicaoDados.Add(new StringContent(aparicao.apa_Status), "Status: ");
                aparicaoDados.Add(new StringContent(aparicao.ani_Especie), "Espécie: ");

                using (var response = await httpClient.PutAsync($"{BaseApiUrl}api/Aparicao/AtualizarAparicao/", aparicaoDados))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    aparicaoRecebida = JsonConvert.DeserializeObject<Aparicao>(apiResponse);
                }
            }
            return View(aparicaoRecebida);
        }

        [HttpGet]
        public IActionResult VerFoto(byte[] fotoArray)
        {
            Byte[] b = System.IO.File.ReadAllBytes(fotoArray.ToString());  
            return File(b, "image/jpeg");
        }

    }
}