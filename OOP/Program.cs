using OOP.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        int opc = 0;
        List<Estudiante> estudiantes = new List<Estudiante>();

        // do
        // {
        //     Console.WriteLine("1. Ingresar nuevo estudiante: ");
        //     Console.WriteLine("2. Eliminar estudiante: ");
        //     Console.WriteLine("3. Listar estudiantes: ");
        //     Console.WriteLine("4. Salir ");

        //     switch (opc)
        //     {
        //         case 1:
        //             String id = Guid.NewGuid().ToString();
        //             Console.Write("Ingrese el nombre del estudiante:");
        //             String nombre = Console.ReadLine();
        //             Console.Write("Ingrese la edad del estudiante:");
        //             int edad = Int32.Parse(Console.ReadLine());
        //             Console.Write("Ingrese el email del estudiante:");
        //             String email = Console.ReadLine();

        //             Estudiante estudiante = new Estudiante(id, nombre, edad, email);
        //             break;
        //         case 2:
        //             break;
        //         case 3:
        //             foreach (var i in estudiantes)
        //             {
        //                 Console.WriteLine(i.id);
        //             }
        //             break;
        //     }
        // } while (opc != 4);

        int var1 = "Cod Estudiante".Count();
        int var2 = "Cod Estudiante".Count();
        String longi = (var1 - var2).ToString();
        Console.WriteLine(" {0,10}{0,10}", "Cod Estudiante", "Nombre del estudiante");
        Console.WriteLine(" {" + "0," + "0" + "} {" + longi + ",0" + "}", "Menor1", "papa1","papa1");

    }
}


