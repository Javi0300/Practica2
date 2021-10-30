using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using Practica2.Domain;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.Localization;

namespace Practica2.Infrastructure.Interfaces
{
    public interface Ejercicio2Interfaces
    {
        void AlcoholConsumido(int cantidad, string bebida);
        void AlcoholDirecto(int peso);
        //void Etanol(int peso);
        string Resultado();
    }
}
