using OOP.Entities;
using OOP.logic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        Funcionalidad funciones = new Funcionalidad();
        try
        {
            int opc = 4;
            do
            {
                //MENU
                opc = funciones.menu();

                switch (opc)
                {
                    case 1:
                        funciones.agregarEstudiantes(estudiantes);
                        break;
                    case 2:
                        funciones.listarEstudiantes(estudiantes);
                        break;
                }
            } while (opc != 4);
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.ToString());
            funciones.menu();
            throw;
        }
    }
    //CRUD
    // un profesor necesita registrar estudiantes matriculados, la informacion que el docente posee de cada estudiante es:
    //  codigo del estudiante con longitud max de 15 caracteres
    //  nombre del estudiante con longitud max de 40 caracteres
    //  correo del estudiante con longitud max de 40 caracteres
    //  edad del estudiante 
    //  direccion del estudiante con longitud max de 35 caracteres
    //REPORTES
    //TODO: se tiene como norma que cada estudiante presenta 4 quices 2 trabajos y 3 parciales
    //TODO: las notas de los quices equivalen al 15%
    //TODO: las notas de los trabajos equivalen al 25%
    //TODO: las notas de los parciales equivalen al 60%
    //TODO: se le permite al profesor generar los reportes:
    //TODO: listado general de notas paginado por 10
    //TODO: el programa debe permitir registro por nota, quiz, parciales

    //FUNCIONALIDADES
    //TODO: Hacer que el programa no se detenga en caso de que se ingresen valores no correctos
}


