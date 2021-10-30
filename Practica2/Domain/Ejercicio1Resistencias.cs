using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica2.Infrastructure.Interfaces;

namespace Practica2.Domain
{
    //public record Ejercicio1Resistencias(string PrimeraBanda, string SegundaBanda, string Multiplicador, string Tolerancia, int? Resultado);
    public class Ejercicio1Resistencias : Ejercicio1Interfaces
    {
        #region"Variables"
        private string _PrimeraBanda, _SegundaBanda, _Multiplicador, _Tolerancia, Mensaje;
        private int valorSwitch1, valorSwitch2, _Resultado;
        private string Predeterminado;
        public double Calculo = 0.0, _ResultadoMultiplicador, _ResultadoTolerancia;
        #endregion

        #region"Primera Banda"
        public void PrimeraBanda(string PrimeraBanda)
        {
            _PrimeraBanda = PrimeraBanda.ToLower();
            switch (PrimeraBanda)
            {
                case "Negro":
                    break;
                case "Cafe":
                    valorSwitch1 = 1;
                    break;
                case "Rojo":
                    valorSwitch1 = 2;
                    break;
                case "Naranja":
                    valorSwitch1 = 3;
                    break;
                case "Amarillo":
                    valorSwitch1 = 4;
                    break;
                case "Verde":
                    valorSwitch1 = 5;
                    break;
                case "Azul":
                    valorSwitch1 = 6;
                    break;
                case "Violeta":
                    valorSwitch1 = 7;
                    break;
                case "Gris":
                    valorSwitch1 = 8;
                    break;
                case "Blanco":
                    valorSwitch1 = 9;
                    break;
                default:
                        Predeterminado = "Error, datos vacíos o un Color prohibido.";
                    break;
            }
        }
        #endregion

        #region"Segunda Banda"
        public void SegundaBanda(string SegundaBanda)
        {
            _SegundaBanda = SegundaBanda.ToLower();
            switch (SegundaBanda)
            {
                case "Negro":
                    _Resultado = valorSwitch1 + valorSwitch2;
                    break;
                case "Cafe":
                    valorSwitch2 = 1;
                    _Resultado = valorSwitch1 + valorSwitch2;
                    break;
                case "Rojo":
                    valorSwitch2 = 2;
                    _Resultado = valorSwitch1 + valorSwitch2;
                    break;
                case "Naranja":
                    valorSwitch2 = 3;
                    _Resultado = valorSwitch1 + valorSwitch2;
                    break;
                case "Amarillo":
                    valorSwitch2 = 4;
                    _Resultado = valorSwitch1 + valorSwitch2;
                    break;
                case "Verde":
                    valorSwitch2 = 5;
                    _Resultado = valorSwitch1 + valorSwitch2;
                    break;
                case "Azul":
                    valorSwitch2 = 6;
                    _Resultado = valorSwitch1 + valorSwitch2;
                    break;
                case "Violeta":
                    valorSwitch2 = 7;
                    _Resultado = valorSwitch1 + valorSwitch2;
                    break;
                case "Gris":
                    valorSwitch2 = 8;
                    _Resultado = valorSwitch1 + valorSwitch2;
                    break;
                case "Blanco":
                    valorSwitch2 = 9;
                    _Resultado = valorSwitch1 + valorSwitch2;
                    break;
                default:
                    Predeterminado = "Error, datos vacíos o un Color prohibido.";
                    break;
            }
        }
        #endregion

        #region"Multiplicador"
        public void Multiplicador(string Multiplicador)
        {
            int numero = 0;
            _Multiplicador = Multiplicador.ToLower();
            try {
                switch (Multiplicador)
                {

                    case "Negro":
                        _ResultadoMultiplicador = 1;
                        Calculo = _Resultado * _ResultadoMultiplicador;
                        break;
                    case "Cafe":
                        _ResultadoMultiplicador = 10;
                        Calculo = _Resultado * _ResultadoMultiplicador;
                        break;
                    case "Rojo":
                        _ResultadoMultiplicador = 100;
                        Calculo = _Resultado * _ResultadoMultiplicador;
                        break;
                    case "Naranja":
                        _ResultadoMultiplicador = 1000;
                        Calculo = _Resultado * _ResultadoMultiplicador;
                        break;
                    case "Amarillo":
                        _ResultadoMultiplicador = 10000;
                        Calculo = _Resultado * _ResultadoMultiplicador;
                        break;
                    case "Verde":
                        _ResultadoMultiplicador = 100000;
                        Calculo = _Resultado * _ResultadoMultiplicador;
                        break;
                    case "Azul":
                        _ResultadoMultiplicador = 1000000;
                        Calculo = _Resultado * _ResultadoMultiplicador;
                        break;
                    default:
                        Predeterminado = "Error, datos vacíos o un Color prohibido.";
                        break;
                }
            }
            catch(Exception ex)
            {
                Mensaje = "Colores prohibidos o campos vacíos";
            }
                
            
        }
        #endregion

        #region"Tolerancia"
        public void Tolerancia(string Tolerancia)
        {
            //double  Resultado;
            _Tolerancia = Tolerancia.ToLower();
            try
            {
                if (Tolerancia == "Dorado")
                {
                    _ResultadoTolerancia = Calculo * 0.5 / 10;
                }
                if (Tolerancia == "Plata")
                {
                    _ResultadoTolerancia = Calculo * 0.10 / 10;
                }
            }
            
            catch(Exception ex)
            {
                 Mensaje = "Solo se permite el color dorado o plateado.";
            }
        }
        #endregion

        public string Resultado()
        {
            return $"Valor en ohmios es {Calculo} +- {_ResultadoTolerancia} de tolerancia.";
        }




    }
}
