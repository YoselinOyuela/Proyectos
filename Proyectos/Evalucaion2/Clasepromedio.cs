using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalucaion2
{
    class Clasepromedio
    {
        //private string nombreEstudiante;
        //private decimal numeroCuenta;
        //private int nota1;
        //private int nota2;
        //private int nota3;
        //private int nota4;

        public string NombreEstudiante { get; set; }
        public decimal NumeroCuenta { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Nota4 { get; set; }

        public Clasepromedio() { }

        public Clasepromedio(string _NombreEstudiante, int _NumeroCuenta)
        {
            NombreEstudiante = _NombreEstudiante;
            NumeroCuenta = _NumeroCuenta;
        }
        public Clasepromedio(string _NombreEstudiante, decimal _NumeroCuenta, decimal _Nota1, decimal _Nota2, decimal _Nota3, decimal _Nota4)
        {
            NombreEstudiante = _NombreEstudiante;
            NumeroCuenta = _NumeroCuenta;
            Nota1 = _Nota1;
            Nota2 = _Nota2;
            Nota3 = _Nota3;
            Nota4 = _Nota4;
        }
    }
}
