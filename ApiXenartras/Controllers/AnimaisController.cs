using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using PCC.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiXenartras.Database;
using Xamarin.Essentials;

namespace ApiXenartras.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        private DatabaseContext _data;
        private int numeroDeRegistrosPorPagina = 5;

        public AnimaisController(DatabaseContext data)
        {
            _data = data;
        }

        [HttpGet]
        public IActionResult MostrarAnimal(int ani_ID)
        {
            Animal animalDB= _data.Animais.FirstOrDefault(a => a.ani_ID == ani_ID);

            if (animalDB == null)
            {
                return NotFound(); //Animal não encontrados.
            }
            return new JsonResult(animalDB);
        }

        [HttpGet("MostrarAnimais/")]
        public IEnumerable<Animal> MostrarAnimais(string ani_Especie, int numeroDaPagina)
        {
            return _data.Animais.Where(a => a.ani_Especie == ani_Especie)
                .Skip(numeroDeRegistrosPorPagina * (numeroDaPagina - 1))
                .Take(numeroDeRegistrosPorPagina)
                .ToList<Animal>();
        }
    }
}
