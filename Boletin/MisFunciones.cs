using System.Security.Cryptography.X509Certificates;
using Boletin.Entities;
using Newtonsoft.Json;

namespace Boletin;

public class MisFunciones
{
    public static byte MenuNotas()
    {
        Console.WriteLine("1. Registro quices");
        Console.WriteLine("2. Registro trabajos");
        Console.WriteLine("3. Registro parciales");
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
    public static void SaveDataEstudiante(List<Estudiante> listaEstudiantes, Estudiante estudianteNuevo)
    {
        // if (listaEstudiantes.Exists(x => x.Code != estudianteNuevo.Code))
        if (listaEstudiantes.FirstOrDefault(x => x.Code == estudianteNuevo.Code) != null)
        {
            Console.WriteLine("El estudiante ya se encuentra registrado en el sistema");
        }
        {
            listaEstudiantes.Add(estudianteNuevo);
            string json = JsonConvert.SerializeObject(listaEstudiantes, Formatting.Indented);
            File.WriteAllText("boletin.json", json);
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
        listaEstudiantes.Remove();

        string json = JsonConvert.SerializeObject(listaEstudiantes, Formatting.Indented);
        File.WriteAllText("boletin.json", json);
    }

    public static List<Estudiante> LoadData()
    {
        try
        {
            using (StreamReader reader = new StreamReader("boletin.json"))
            {
                if (reader.ReadLine() != null)
                {
                    string json = reader.ReadToEnd();
                    return System.Text.Json.JsonSerializer.Deserialize<List<Estudiante>>(json, new System.Text.Json.JsonSerializerOptions()
                    { PropertyNameCaseInsensitive = true }) ?? new List<Estudiante>();
                }
                else
                {
                    return new List<Estudiante>();
                }
            }
        }
        catch (System.Exception)
        {
            return new List<Estudiante>();
        }
    }
}
