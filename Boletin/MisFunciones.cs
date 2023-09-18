using System.Security.Cryptography.X509Certificates;
using Boletin.Entities;
using Newtonsoft.Json;

namespace Boletin;

public class MisFunciones
{
    public static byte MenuNotas()
    {
        Console.Clear();
        Console.WriteLine("1. Registro quices");
        Console.WriteLine("2. Registro trabajos");
        Console.WriteLine("3. Registro parciales");
        Console.WriteLine("0. Regresar al menu principal");
        Console.Write("Opcion: ");
        return Convert.ToByte(Console.ReadLine());
    }
    public static byte MenuEditNotas()
    {
        Console.Clear();
        Console.WriteLine("EDITAR NOTAS");
        Console.WriteLine("1. Editar Notas");
        Console.WriteLine("2. Eliminar Notas");
        Console.WriteLine("0. Regresar al menu principal");
        Console.Write("Opcion: ");
        return Convert.ToByte(Console.ReadLine());
    }
    public static byte Reportes()
    {
        Console.WriteLine("1. Notas del grupo");
        Console.WriteLine("2. Notas Finales");
        Console.WriteLine("0. Regresar al menu principal");
        Console.Write("Opcion: ");
        return Convert.ToByte(Console.ReadLine());
    }
    public static void SaveData(List<Estudiante> listaEstudiantes)
    {
        //guarda los datos de manera general, asumiendo que vienen validados desde el otro lado
        string json = JsonConvert.SerializeObject(listaEstudiantes, Formatting.Indented);
        File.WriteAllText("boletin.json", json);
    }
    public static void SaveDataEstudiante(Estudiante estudianteNuevo)
    {
        List<Estudiante> listaEstudiantes = LoadData();
        if (listaEstudiantes.Any(x => x.Code.Equals(estudianteNuevo.Code)))
        {
            Console.WriteLine("El estudiante ya se encuentra registrado en el sistema");
            Console.Write("Presione Enter para continuar: ");
            Console.ReadKey();
        }
        else
        {
            listaEstudiantes.Add(estudianteNuevo);
            SaveData(listaEstudiantes);
        }
    }
    public static void EditDataEstudiante(List<Estudiante> listaEstudiantes, Estudiante estudianteEditado)
    {

        int i = listaEstudiantes.IndexOf(estudianteEditado);
        Estudiante estudiante = new Estudiante(); //estudiante que contendra los datos actualizados, conservando notas
        estudiante.Code = estudianteEditado.Code;
        estudiante.Direccion = estudianteEditado.Direccion;
        estudiante.Edad = estudianteEditado.Edad;
        estudiante.Code = estudianteEditado.Code;
        estudiante.Code = estudianteEditado.Code;
        estudiante.Quices = listaEstudiantes[i].Quices;
        estudiante.Trabajos = listaEstudiantes[i].Trabajos;
        estudiante.Parciales = listaEstudiantes[i].Parciales;
        listaEstudiantes.Add(estudiante);

        string json = JsonConvert.SerializeObject(listaEstudiantes, Formatting.Indented);
        File.WriteAllText("boletin.json", json);
    }

    public static List<Estudiante> LoadData()
    {
        try
        {
            using (StreamReader reader = new StreamReader("boletin.json"))
            {
                string archivoJson = "boletin.json";
                if (File.Exists(archivoJson))
                {
                    string json = File.ReadAllText(archivoJson);
                    return JsonConvert.DeserializeObject<List<Estudiante>>(json) ?? new List<Estudiante>();
                }
                else
                {
                    return new List<Estudiante>();
                }
                //     if (reader.ReadLine() != null)
                //     {
                //         string json = reader.ReadToEnd();
                //         return System.Text.Json.JsonSerializer.Deserialize<List<Estudiante>>(json, new System.Text.Json.JsonSerializerOptions()
                //         { PropertyNameCaseInsensitive = true }) ?? new List<Estudiante>();
                //     }
                //     else
                //     {
                //         return new List<Estudiante>();
                //     }
                // }
            }
        }
        catch (System.Exception)
        {
            return new List<Estudiante>();
        }
    }
    public static byte Find()
    {
        Console.Clear();
        Console.WriteLine("BUSCAR ALUMNO");
        Console.WriteLine("1. Buscar por codigo");
        Console.WriteLine("2. Buscar por nombre");
        Console.WriteLine("3. Buscar por edad");
        Console.WriteLine("4. Buscar por direccion");
        Console.WriteLine("0. Regresar al menu principal");
        Console.Write("Opcion: ");
        return Convert.ToByte(Console.ReadLine());
    }
    public static void ImprimirNotas()
    {
        int estudiantesPorPagina = 10;
        int paginaActual = 0;
        List<Estudiante> estudiantes = LoadData();
        while (paginaActual * estudiantesPorPagina < estudiantes.Count)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| {0,-20} | {1,-40} | {2,-5} | {3,-5} | {4,-5} | {5,-5} | {6,-5} | {7,-5} | {8,-5} | {9,-5} | {10,-5} |", "Cod.Estudiante", "Nombre Estudiante", "Q1", "Q2", "Q3", "Q4", "T1", "T2", "P1", "P2", "P3");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = paginaActual * estudiantesPorPagina; i < (paginaActual + 1) * estudiantesPorPagina && i < estudiantes.Count; i++)
            {
                Estudiante estudiante = estudiantes[i];
                Console.Write("| {0,-20} | {1,-40} |", estudiante.Code, estudiante.Nombre);
                ImprimirNotasDeLista("Q", estudiante.Quices, 4);
                ImprimirNotasDeLista("T", estudiante.Trabajos, 2);
                ImprimirNotasDeLista("P", estudiante.Parciales, 3);
                Console.WriteLine();
            }
            Console.WriteLine("Página {0}", paginaActual + 1);
            Console.WriteLine("Presione Enter para continuar a la siguiente pagina...");
            Console.ReadKey();
            Console.Clear();
            var estudiantesPagina = estudiantes
            .Skip(paginaActual * estudiantesPorPagina)
            .Take(estudiantesPorPagina);
            Console.WriteLine("Presione Enter para avanzar a la siguiente página o cualquier otra tecla para salir...");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                break; // Salir si el usuario no presiona "Enter" para avanzar.
            }
            paginaActual++;
        }
    }
    public static void ImprimirNotasDeLista(string tipo, List<float> notas, int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            float nota = notas.ElementAtOrDefault(i);
            Console.Write(" {0,-5} |", nota != 0.0f ? nota.ToString() : "0.0");
        }
    }
    public static float CalcularNotaFinal(List<float> quices, List<float> trabajos, List<float> parciales)
    {
        float pesoQuices = 0.25f;
        float pesoTrabajos = 0.15f;
        float pesoParciales = 0.60f;
        float sumaQuices = quices.Take(4).DefaultIfEmpty(0.0f).Sum();
        float sumaTrabajos = trabajos.Take(2).DefaultIfEmpty(0.0f).Sum();
        float sumaParciales = parciales.Take(3).DefaultIfEmpty(0.0f).Sum();
        float notaFinal = (sumaQuices * pesoQuices) + (sumaTrabajos * pesoTrabajos) + (sumaParciales * pesoParciales);
        return notaFinal;
    }
    public static void ImprimirNotasFinales(List<Estudiante> estudiantes)
    {
        Console.Clear();
        Console.WriteLine("Tabla de Notas Finales");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("| {0,-20} | {1,-40} | {2,-7} |", "Cod.Estudiante", "Nombre Estudiante", "Nota Final");
        Console.WriteLine("------------------------------------------------------------------");
        foreach (var estudiante in estudiantes)
        {
            float notaFinal = CalcularNotaFinal(estudiante.Quices, estudiante.Trabajos, estudiante.Parciales);
            Console.WriteLine("| {0,-20} | {1,-40} | {2,-7} |", estudiante.Code, estudiante.Nombre, notaFinal.ToString());
        }
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadKey();
    }
}
