using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica2.Infrastructure;
using Practica2.Domain;

namespace Practica2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ejercicio1Controller : ControllerBase
    {
        //private readonly Ejercicio1Repository _repository;
        //public Ejercicio1Controller()
        //{
        //    _repository = new Ejercicio1Repository();
        //}
        //[HttpGet]
        //[Route("GetAll")]
        //public async Task<IActionResult> GetAll()
        //{
        //    var lst = await _repository.GetAll();
        //    return Ok(lst);
        //}

        [HttpGet]
        [Route("CalcularResistencia")]
        public IActionResult Obtener(string PrimeraBanda, string SegundaBanda, string Multiplicador, string Tolerancia)
        {
            var resultado = new Ejercicio1Resistencias();
            resultado.PrimeraBanda(PrimeraBanda);
            resultado.SegundaBanda(SegundaBanda);
            resultado.Multiplicador(Multiplicador);
            resultado.Tolerancia(Tolerancia);
            resultado.Resultado();
            return Ok(resultado.Resultado());
        }
    }
}
