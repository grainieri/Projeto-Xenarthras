using Newtonsoft.Json;
using PCC.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PCC.Services
{
    public class UsuarioService : Service
    {
        public async Task<ResponseService<List<Usuario>>> PesquisarUsuario(string usu_Email, int numeroDaPagina)
        {
            //TODO - Entender pq não está funcionando
            HttpResponseMessage response = await _client.GetAsync($"{BaseApiUrl}api/Usuario/PesquisarUsuario/?usu_Email={usu_Email}&numeroDaPagina={numeroDaPagina}");

            ResponseService<List<Usuario>> responseService = new ResponseService<List<Usuario>>();
            responseService.IsSuccess = response.IsSuccessStatusCode;
            responseService.StatusCode = (int)response.StatusCode;

            if (response.IsSuccessStatusCode)
            {
                responseService.Data = await response.Content.ReadAsAsync<List<Usuario>>();
            }
            else
            {
                var problemResponse = await response.Content.ReadAsStringAsync();
                var errors = JsonConvert.DeserializeObject<ResponseService<List<Usuario>>>(problemResponse);

                responseService.Errors = errors.Errors;
            }
            return responseService;
        }

        public async Task<ResponseService<Usuario>> LoginUsuario(string usu_Email, string usu_Senha)
        {
            HttpResponseMessage response = await _client.GetAsync($"{BaseApiUrl}api/Usuario/?usu_Email={usu_Email}&usu_Senha={usu_Senha}");

            ResponseService<Usuario> responseService = new ResponseService<Usuario>();
            responseService.IsSuccess = response.IsSuccessStatusCode;
            responseService.StatusCode = (int)response.StatusCode;

            if (response.IsSuccessStatusCode)
            {
                responseService.Data = await response.Content.ReadAsAsync<Usuario>();
            }
            else
            {
                var problemResponse = await response.Content.ReadAsStringAsync();
                var errors = JsonConvert.DeserializeObject<ResponseService<Usuario>>(problemResponse);

                responseService.Errors = errors.Errors;
            }
            return responseService;
        }

        public async Task<ResponseService<Usuario>> CadastrarUsuario(Usuario usuario)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync($"{BaseApiUrl}api/Usuario", usuario);

            ResponseService<Usuario> responseService = new ResponseService<Usuario>();
            responseService.IsSuccess = response.IsSuccessStatusCode;
            responseService.StatusCode = (int)response.StatusCode;

            if (response.IsSuccessStatusCode)
            {
                responseService.Data = await response.Content.ReadAsAsync<Usuario>();
            }
            else
            {
                var problemResponse = await response.Content.ReadAsStringAsync();
                var errors = JsonConvert.DeserializeObject<ResponseService<Usuario>>(problemResponse);

                responseService.Errors = errors.Errors;
            }

            return responseService;
        }
    }
}
