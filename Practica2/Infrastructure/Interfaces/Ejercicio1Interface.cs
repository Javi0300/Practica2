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
 
        //private readonly string _path;
        //List<Ejercicio1Resistencias> _resistencias;
        //Ejercicio1Resistencias _ejercicio1;
        public interface Ejercicio1Interfaces
        {
            void PrimeraBanda(string PrimeraBanda);
            void SegundaBanda(string SegundaBanda);
            void Multiplicador(string Multiplicador);
            void Tolerancia(string Tolerancia);
            string Resultado();
        }

}
