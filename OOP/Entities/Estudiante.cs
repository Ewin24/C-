using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Entities
{
    public class Estudiante
    {
        public string? codigo { get; set; }

        public string? nombre { get; set; }
        public string? correo { get; set; }
        public int? edad { get; set; }
        public string? direccion { get; set; }
        public Estudiante()
        {
        }
        public Estudiante(string codigo, string nombre, int edad, string correo, string direccion)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.correo = correo;
            this.edad = edad;
            this.direccion = direccion;
        }
    }
}