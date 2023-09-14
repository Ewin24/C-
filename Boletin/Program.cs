using Boletin;
using Boletin.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        Estudiante student = new Estudiante();
        bool cicloMenu = true;
        estudiantes = MisFunciones.LoadData();
        while (cicloMenu)
        {
            Console.Clear();
            Console.WriteLine("1. Registro de estudiantes");
            Console.WriteLine("2. Registro de notas");
            Console.WriteLine("3. Reportes e informes");
            Console.WriteLine("4. Eliminar Estudiante");
            Console.WriteLine("5  Editar Estudiante");
            Console.WriteLine("6. Editar Notas");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");
            byte opcionMenu = Convert.ToByte(Console.ReadLine());
            switch (opcionMenu)
            {
                case 1:
                    student.registroEstudiante(estudiantes);
                    break;
                case 2:
                    bool cicloNotas = true;
                    while (cicloNotas)
                    {
                        Console.Clear();
                        byte opcionNotas = MisFunciones.MenuNotas();
                        if (opcionNotas != 0)
                        {
                            student.RegistroNota(estudiantes, opcionNotas);
                            MisFunciones.SaveData(estudiantes);
                        }
                        else
                        {
                            cicloNotas = false;
                        }
                    }

                    break;
                case 3:
                    bool cicloReportes = true;
                    while (cicloReportes)
                    {
                        Console.Clear();
                        byte opcionRegistro = MisFunciones.Reportes();
                        switch (opcionRegistro)
                        {
                            case 1:
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                break;
                            case 0:
                                Console.Clear();
                                cicloReportes = false;
                                break;
                            default:
                                Console.WriteLine("Opcion invalida");
                                Console.Write("Presione Enter para volver a ingresar: ");
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;
                case 4:
                    student.RemoveItem(estudiantes);
                    break;
                case 5:
                    student.RemoveItem(estudiantes);
                    break;
                case 6:
                    student.RemoveItem(estudiantes);
                    break;
                case 0:
                    cicloMenu = false;
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    Console.Write("Presione Enter para volver a ingresar: ");
                    Console.ReadKey();
                    break;
            }

        }
    }
}

//TODO: validacion para que no deje ingresar estudiante si ya existe uno con el mismo codigo
//TODO: funcionalidad de edicion de estudiante por codigo en caso de que se edite el estudiante conservar notas
//TODO: funcionalidad de edicion de nota por codigo de estudiante 
