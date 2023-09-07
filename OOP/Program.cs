using OOP.Entities;
using OOP.logic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        Funcionalidad funciones = new Funcionalidad();
        int opc = 4;
        do
        {
            //MENU
            opc = funciones.menu();

            switch (opc)
            {
                case 1:
                    Console.WriteLine("\n");
                    String? codigo = Guid.NewGuid().ToString();
                    Console.Write("Ingrese el nombre del estudiante:");
                    String? nombre = Console.ReadLine();
                    if (nombre.Length > 40 || nombre.Length < 0)
                    {
                        Console.WriteLine("El nombre no puede superar 40 caracteres");
                        break;
                    }
                    Console.Write("Ingrese el correo del estudiante:");
                    String? correo = Console.ReadLine();
                    if (correo.Length > 40)
                    {
                        Console.WriteLine("El correo no puede superar 40 caracteres");
                        break;

                    }
                    Console.Write("Ingrese la edad del estudiante:");
                    int edad = Int32.Parse(Console.ReadLine());
                    if (edad < 0)
                    {
                        Console.WriteLine("El estudiante no puede tener menos de 1 año");
                        break;
                    }
                    Console.Write("Ingrese la direccion del estudiante:");
                    String direccion = Console.ReadLine();
                    if (direccion.Length > 35)
                    {
                        Console.WriteLine("La direccion no puede superar 35 caracteres");
                        break;
                    }
                    Estudiante estudiante = new Estudiante(codigo, nombre, edad, correo, direccion);
                    estudiantes.Add(estudiante);
                    break;
                case 2:
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
                    break;
            }
        } while (opc != 4);

    }
    //CRUD
    // un profesor necesita registrar estudiantes matriculados, la informacion que el docente posee de cada estudiante es:
    // TODO: codigo del estudiante con longitud max de 15 caracteres
    // TODO: nombre del estudiante con longitud max de 40 caracteres
    // TODO: correo del estudiante con longitud max de 40 caracteres
    // TODO: edad del estudiante 
    // TODO: direccion del estudiante con longitud max de 35 caracteres
    //REPORTES
    //TODO: se tiene como norma que cada estudiante presenta 4 quices 2 trabajos y 3 parciales
    //TODO: las notas de los quices equivalen al 15%
    //TODO: las notas de los trabajos equivalen al 25%
    //TODO: las notas de los parciales equivalen al 60%
    //TODO: se le permite al profesor generar los reportes:
    //TODO: listado general de notas paginado por 10
    //TODO: el programa debe permitir registro por nota, quiz, parciales
}


