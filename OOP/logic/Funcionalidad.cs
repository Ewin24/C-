using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.logic
{
    public class Funcionalidad
    {
        public Funcionalidad()
        {
        }

        public int menu()
        {
            int opc = 4;
            Console.WriteLine("=================MENU PRINCIPAL DE GESTION DE ESTUDIANTES=================");
            Console.WriteLine("1. Ingresar nuevo estudiante ");
            Console.WriteLine("2. Listar estudiantes ");
            Console.WriteLine("4. Salir ");
            Console.WriteLine("Opcion: ");
            opc = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            return opc;
        }
    }
}