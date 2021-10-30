using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica2.Domain;

namespace Practica2.Controllers
{
    public class Ejercicio2Controller : ControllerBase
    {
        [HttpGet]
        [Route("Controller/{cantidad}/{bebida}/{peso}")]
        public IActionResult GetAlcoholemia(int cantidad, string bebida, double peso /*double sangre*/)
        {

            var resultado = new Ejercicio2Bebidas();
            resultado.AlcoholConsumido(cantidad, bebida);
            resultado.AlcoholDirecto((int)peso);
            //resultado.Etanol((int)peso);
            resultado.Resultado();
            return Ok(resultado.Resultado());
        }
    }
}
