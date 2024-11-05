using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeCancerCompanySA
{
    public class Pacientes
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public bool EstaEnfermo { get; set; }
        public decimal Deuda { get; set; }
        public string Condicion { get; set; }

        public Pacientes(string cedula, string nombre, int edad, string genero, bool estaEnfermo, decimal deuda, string condicion)
        {
            Cedula = cedula;
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            EstaEnfermo = estaEnfermo;
            Deuda = deuda;
            Condicion = condicion;
        }
    }
}

