using Newtonsoft.Json;
using PCC.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PCC.Services
{
    public class AparicaoService : Service
    {
        public async Task<ResponseService<List<Aparicao>>> MostrarAparicoes(int usu_ID, int numeroDaPagina)
        {
            HttpResponseMessage response = await _client.GetAsync($"{BaseApiUrl}api/Aparicao/MostrarAparicoes/?usu_ID={usu_ID}&numeroDaPagina={numeroDaPagina}");

            ResponseService<List<Aparicao>> responseService = new ResponseService<List<Aparicao>>();
            responseService.IsSuccess = response.IsSuccessStatusCode;
            responseService.StatusCode = (int)response.StatusCode;

            if (response.IsSuccessStatusCode)
            {
                responseService.Data = await response.Content.ReadAsAsync<List<Aparicao>>();
            }
            else
            {
                var problemResponse = await response.Content.ReadAsStringAsync();
                var errors = JsonConvert.DeserializeObject<ResponseService<List<Aparicao>>>(problemResponse);

                responseService.Errors = errors.Errors;
            }
            return responseService;
        }

        public async Task<ResponseService<Aparicao>> MostrarAparicao(int apa_ID)
        {
            HttpResponseMessage response = await _client.GetAsync($"{BaseApiUrl}api/Aparicao/?apa_ID={apa_ID}");

            ResponseService<Aparicao> responseService = new ResponseService<Aparicao>();
            responseService.IsSuccess = response.IsSuccessStatusCode;
            responseService.StatusCode = (int)response.StatusCode;

            if (response.IsSuccessStatusCode)
            {
                responseService.Data = await response.Content.ReadAsAsync<Aparicao>();
            }
            else
            {
                var problemResponse = await response.Content.ReadAsStringAsync();
                var errors = JsonConvert.DeserializeObject<ResponseService<Aparicao>>(problemResponse);

                responseService.Errors = errors.Errors;
            }
            return responseService;
        }

        public async Task<ResponseService<List<Aparicao>>> Mostrar20UltimasAparicoes(string ani_Especie)
        {
            HttpResponseMessage response = await _client.GetAsync($"{BaseApiUrl}api/Aparicao/Mostrar20UltimasAparicoes/{ani_Especie}");

            ResponseService<List<Aparicao>> responseService = new ResponseService<List<Aparicao>>();
            responseService.IsSuccess = response.IsSuccessStatusCode;
            responseService.StatusCode = (int)response.StatusCode;

            if (response.IsSuccessStatusCode)
            {
                responseService.Data = await response.Content.ReadAsAsync<List<Aparicao>>();
            }
            else
            {
                var problemResponse = await response.Content.ReadAsStringAsync();
                var errors = JsonConvert.DeserializeObject<ResponseService<List<Aparicao>>>(problemResponse);

                responseService.Errors = errors.Errors;
            }
            return responseService;
        }

        public async Task<ResponseService<Aparicao>> CadastrarAparicao(Aparicao aparicao)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync($"{BaseApiUrl}api/Aparicao", aparicao);

            ResponseService<Aparicao> responseService = new ResponseService<Aparicao>();
            responseService.IsSuccess = response.IsSuccessStatusCode;
            responseService.StatusCode = (int)response.StatusCode;

            if (response.IsSuccessStatusCode)
            {
                responseService.Data = await response.Content.ReadAsAsync<Aparicao>();
            }
            else
            {
                var problemResponse = await response.Content.ReadAsStringAsync();
                var errors = JsonConvert.DeserializeObject<ResponseService<Aparicao>>(problemResponse);

                responseService.Errors = errors.Errors;
            }

            return responseService;
        }

        public async Task<ResponseService<Aparicao>> AtualizarAparicao(Aparicao aparicao)
        {
            var json = JsonConvert.SerializeObject(aparicao);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _client.PostAsync($"{BaseApiUrl}api/Aparicao/AtualizarAparicao/{aparicao.apa_ID}", content);
            
            //OU 
            //HttpResponseMessage response = await _client.PostAsJsonAsync($"{BaseApiUrl}api/Aparicao/AtualizarAparicao/{aparicao.apa_ID}", aparicao);

            ResponseService<Aparicao> responseService = new ResponseService<Aparicao>();
            responseService.IsSuccess = response.IsSuccessStatusCode;
            responseService.StatusCode = (int)response.StatusCode;

            if (response.IsSuccessStatusCode)
            {
                responseService.Data = await response.Content.ReadAsAsync<Aparicao>();
            }
            else
            {
                var problemResponse = await response.Content.ReadAsStringAsync();
                var errors = JsonConvert.DeserializeObject<ResponseService<Aparicao>>(problemResponse);

                responseService.Errors = errors.Errors;
            }

            return responseService;
        }

        public async Task<ResponseService<List<Aparicao>>> MostrarAparicoesPendentes(int numeroDaPagina)
        {
            HttpResponseMessage response = await _client.GetAsync($"{BaseApiUrl}api/Aparicao/MostrarAparicoesPendentes/{numeroDaPagina}");

            ResponseService<List<Aparicao>> responseService = new ResponseService<List<Aparicao>>();
            responseService.IsSuccess = response.IsSuccessStatusCode;
            responseService.StatusCode = (int)response.StatusCode;

            if (response.IsSuccessStatusCode)
            {
                responseService.Data = await response.Content.ReadAsAsync<List<Aparicao>>();
            }
            else
            {
                var problemResponse = await response.Content.ReadAsStringAsync();
                var errors = JsonConvert.DeserializeObject<ResponseService<List<Aparicao>>>(problemResponse);

                responseService.Errors = errors.Errors;
            }
            return responseService;
        }
    }
}
