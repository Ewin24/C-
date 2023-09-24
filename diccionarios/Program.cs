// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Dictionary<int, string> diccionario = new Dictionary<int, string>();
//         Console.WriteLine("El total de lementos del diccionario es : {0}", diccionario.Count);
//     }
// }



// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Dictionary<string, string> openWith = new Dictionary<string, string>();
//         // Add some elements to the dictionary. There are no
//         // duplicate keys, but some of the values are duplicates.
//         openWith.Add("txt", "notepad.exe");
//         openWith.Add("bmp", "paint.exe");
//         openWith.Add("dib", "paint.exe");
//         openWith.Add("rtf", "wordpad.exe");
//         // The Add method throws an exception if the new key is 
//         // already in the dictionary.
//         try
//         {
//             openWith.Add("txt", "winword.exe");
//         }
//         catch (ArgumentException)
//         {
//             Console.WriteLine("Un elemento con la llave = \"txt\" ya existe.");
//         }
//     }
// }



//!keys
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Dictionary<string, string> openWith = new Dictionary<string, string>();
//         // Add some elements to the dictionary. There are no
//         // duplicate keys, but some of the values are duplicates. openWith.Add("txt", "notepad.exe");
//         openWith.Add("bmp", "paint.exe");
//         openWith.Add("dib", "paint.exe");
//         openWith.Add("rtf", "wordpad.exe");
//         Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;
//         foreach (string key in keyColl)
//         {
//             Console.WriteLine(key);
//         }
//     }
// }



// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Dictionary<string, string> openWith = new Dictionary<string, string>();
//         // Add some elements to the dictionary. There are no
//         // duplicate keys, but some of the values are duplicates.
//         openWith.Add("txt", "notepad.exe");
//         openWith.Add("bmp", "paint.exe");
//         openWith.Add("dib", "paint.exe");
//         openWith.Add("rtf", "wordpad.exe");
//         Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;
//         foreach (string key in keyColl)
//         {
//             Console.WriteLine(key);
//         }
//         foreach (KeyValuePair<string, string> pair in openWith)
//         {
//             Console.WriteLine("Llave {0} - Valor {1}", pair.Key, pair.Value);
//         }
//     }
// }



//!values
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Dictionary<string, string> openWith = new Dictionary<string, string>();
//         // Add some elements to the dictionary. There are no
//         // duplicate keys, but some of the values are duplicates.
//         openWith.Add("txt", "notepad.exe");
//         openWith.Add("bmp", "paint.exe");
//         openWith.Add("dib", "paint.exe");
//         openWith.Add("rtf", "wordpad.exe");
//         Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
//         foreach (string valor in valueColl)
//         {
//             Console.WriteLine(valor);
//         }
//     }
// }


//!Add
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Dictionary<string, string> openWith = new Dictionary<string, string>();
//         // Add some elements to the dictionary. There are no
//         // duplicate keys, but some of the values are duplicates.
//         openWith.Add("txt", "notepad.exe");
//         openWith.Add("bmp", "paint.exe");
//         openWith.Add("dib", "paint.exe");
//         openWith.Add("rtf", "wordpad.exe");
//         Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
//     }
// }



//!clear()
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Dictionary<string, string> openWith = new Dictionary<string, string>();
//         // Add some elements to the dictionary. There are no
//         // duplicate keys, but some of the values are duplicates.
//         openWith.Add("txt", "notepad.exe");
//         openWith.Add("bmp", "paint.exe");
//         openWith.Add("dib", "paint.exe");
//         openWith.Add("rtf", "wordpad.exe");
//         Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
//         foreach (string valor in valueColl)
//         {
//             Console.WriteLine(valor);
//         }
//         openWith.Clear();
//         Console.WriteLine("Total de datos en el diccionario: " + openWith.Count);
//     }
// }



//!ContainsKey
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Dictionary<string, string> openWith = new Dictionary<string, string>();
//         // Add some elements to the dictionary. There are no
//         // duplicate keys, but some of the values are duplicates.
//         openWith.Add("txt", "notepad.exe");
//         openWith.Add("bmp", "paint.exe"); openWith.Add("dib", "paint.exe");
//         openWith.Add("rtf", "wordpad.exe");
//         if (openWith.ContainsKey("bmp"))
//         {
//             Console.WriteLine("El tipo de formato esta soportado.");
//         }
//         Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
//         foreach (string valor in valueColl)
//         {
//             Console.WriteLine(valor);
//         }
//     }
// }


//!ContainsValue
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Dictionary<string, string> openWith = new Dictionary<string, string>();
//         // Add some elements to the dictionary. There are no
//         // duplicate keys, but some of the values are duplicates.
//         openWith.Add("txt", "notepad.exe");
//         openWith.Add("bmp", "paint.exe"); 
//         openWith.Add("dib", "paint.exe"); 
//         openWith.Add("rtf", "wordpad.exe");
//         if (openWith.ContainsValue("notepad"))
//         {
//             Console.WriteLine("El valor se encuentra registrado.");
//         }
//         else
//         {
//             Console.WriteLine("El valor no se encuentra registrado.");
//         }
//         Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
//         foreach (string valor in valueColl)
//         {
//             Console.WriteLine(valor);
//         }
//     }
// }


//! remove
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Dictionary<string, string> openWith = new Dictionary<string, string>();
//         // Add some elements to the dictionary. There are no
//         // duplicate keys, but some of the values are duplicates.
//         openWith.Add("txt", "notepad.exe");
//         openWith.Add("bmp", "paint.exe");
//         openWith.Add("dib", "paint.exe");
//         openWith.Add("rtf", "wordpad.exe");
//         if (openWith.ContainsValue("notepad"))
//         {
//             Console.WriteLine("El valor se encuentra registrado.");
//         }
//         else
//         {
//             Console.WriteLine("El valor no se encuentra registrado.");
//         }
//         Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
//         openWith.Remove("dib");
//         foreach (string valor in valueColl)
//         {
//             Console.WriteLine(valor);
//         }
//     }
// }