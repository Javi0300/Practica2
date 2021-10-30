using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica2.Infrastructure.Interfaces;

namespace Practica2.Domain
{
    public class Ejercicio2Bebidas : Ejercicio2Interfaces
    {
        #region"Variables y dos constantes"
        private const double _Sangre = 0.08, _Etanol = 0.789;
        private int _Cantidad, _Mililitro;
        private double _Total, _Factor;
        private double _Resultado, _Operador, _Volumen;
        private double _Grado, _Peso, Sangre;
        private string _Bebida, _Valor, Mensaje;
        #endregion

        #region"Alcohol Consumido"
        public void AlcoholConsumido(int cantidad, string bebida)
        {
            _Cantidad = cantidad;
            _Bebida = bebida.ToLower();
            switch (bebida)
            {
                case "Cerveza":
                    _Mililitro = 330;
                    _Cantidad = _Cantidad * _Mililitro;
                    _Grado = 5;
                    _Total = _Grado / 100 * _Cantidad;
                    break;
                case "Vino":
                    _Mililitro = 100;
                    _Cantidad = _Cantidad * _Mililitro;
                    _Grado = 12;
                    _Total = _Grado / 100 * _Cantidad;
                    break;
                case "Vermu":
                    _Mililitro = 70;
                    _Cantidad = _Cantidad * _Mililitro;
                    _Grado = 17;
                    _Total = _Grado / 100 * _Cantidad;
                    break;
                case "Licor":
                    _Mililitro = 45;
                    _Cantidad = _Cantidad * _Mililitro;
                    _Grado = 23;
                    _Total = _Grado / 100 * _Cantidad;
                    break;
                case "Brandy":
                    _Mililitro = 45;
                    _Cantidad = _Cantidad * _Mililitro;
                    _Grado = 38;
                    _Total = _Grado / 100 * _Cantidad;
                    break;
                case "Combinado":
                    _Mililitro = 50;
                    _Cantidad = _Cantidad * _Mililitro;
                    _Grado = 38;
                    _Total = _Grado / 100 * _Cantidad;
                    break;
                default:
                    Mensaje = "Alcohol inexistente: ";
                    break;
            }

        }
        #endregion

        #region"Alcohol directo en sangre"
        public void AlcoholDirecto(int peso)
        {
            _Peso = peso;
            _Factor = 0.15 * _Total;
            #region"Masa de Etanol"
            _Operador = _Etanol * _Factor;
            #endregion
            #region"Volumen de Sangre"
            _Volumen = 0.08 * _Peso;
            _Resultado = _Operador / _Volumen;
            #endregion
        }
        #endregion

        public string Resultado()
        {
            if (_Resultado < 0.8)
            {
                return $"Volumen de sangre iguales a {_Volumen}. Etanol en sangre {_Resultado}, se le desea un buen viaje.";
            }
            return $"La cantidad de Etanol en la sangre es {_Resultado} Se solicita apoyo al conductor.";

        }
    }
    
}
