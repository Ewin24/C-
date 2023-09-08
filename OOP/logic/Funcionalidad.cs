using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP.Entities;

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
            Console.WriteLine("3. Adicionar Notas ");
            Console.WriteLine("4. Salir ");
            Console.WriteLine("Opcion: ");
            opc = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            return opc;
        }
        public void menuNotas()
        {
            int opc = 4;
            Console.WriteLine("=================MENU PRINCIPAL DE GESTION DE NOTAS=================");
            Console.WriteLine("1. Ingresar quices ");
            Console.WriteLine("2. Ingresar trabajos ");
            Console.WriteLine("3. Ingresar parciales ");
            Console.WriteLine("4. Salir ");
            Console.WriteLine("Opcion: ");
            opc = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            switch (opc)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:
                    return;

                    break;

                default:
                    Console.WriteLine("Opcion Incorrecta ");
                    break;
            }
        }

        public void agregarEstudiantes(List<Estudiante> estudiantes)
        {
            Console.WriteLine("\n");

            String? codigo = Console.ReadLine();
            if (codigo.Length > 15 || codigo.Length < 0)
            {
                Console.WriteLine("El nombre no puede superar 15 caracteres o ser menor a 1 caracter");
                return;
            }
            Console.Write("Ingrese el nombre del estudiante:");
            String? nombre = Console.ReadLine();
            if (nombre.Length > 40 || nombre.Length < 0)
            {
                Console.WriteLine("El nombre no puede superar 40 caracteres o ser menor a 1 caracter");
                return;
            }
            Console.Write("Ingrese el correo del estudiante:");
            String? correo = Console.ReadLine();
            if (correo.Length > 40 || correo.Length < 0)
            {
                Console.WriteLine("El correo no puede superar 40 caracteres o ser menor a 1 caracter");
                return;
            }
            Console.Write("Ingrese la edad del estudiante:");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad < 0)
            {
                Console.WriteLine("El estudiante no puede tener menos de 1 año");
                return;
            }
            Console.Write("Ingrese la direccion del estudiante:");
            String direccion = Console.ReadLine();
            if (direccion.Length > 35 || direccion.Length < 0)
            {
                Console.WriteLine("La direccion no puede superar 35 caracteres o ser menor a 1 caracter");
                return;
            }
            Estudiante estudiante = new Estudiante(codigo, nombre, edad, correo, direccion);
            estudiantes.Add(estudiante);
        }

        public void listarEstudiantes(List<Estudiante> estudiantes)
        {
            for (int i = 0; i < estudiantes.Count; i++)
            {
                Console.WriteLine(estudiantes[i].codigo);
                Console.WriteLine(estudiantes[i].nombre);
                Console.WriteLine(estudiantes[i].edad);
                Console.WriteLine(estudiantes[i].correo);
                Console.WriteLine(estudiantes[i].direccion);
                // Console.WriteLine(" {0,10}{0,10}", "Cod Estudiante", "Nombre del estudiante");
                // Console.WriteLine(" {" + "0," + "0" + "} {" + 0 + ",longi" + "}", "Menor1", "papa1", "papa1");
            }
        }
    }
}