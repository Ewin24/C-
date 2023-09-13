using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Entities
{
    public class Nota
    {
        public string codigoEst;
        public List<Double> parciales { get; set; }
        public List<Double> quices { get; set; }
        public List<Double> trabajos { get; set; }
        public Nota(string codigoEst)
        {
            this.codigoEst = codigoEst;
            this.parciales = new List<double>();
            this.quices = new List<double>();
            this.trabajos = new List<double>();
        }
        public static void setNotas(string codigoEst, List<Nota> notas, char tipoNota, double nota)
        {
            for (int i = 0; i < notas.Count; i++)
            {
                if (notas[i].codigoEst == codigoEst)
                {
                    switch (tipoNota)
                    {
                        case 'P':
                            if (notas[i].parciales.Count < 3)
                            {
                                notas[i].parciales.Add(nota);
                                Console.WriteLine("Nota de parcial agregada.");
                            }
                            else
                            {
                                Console.WriteLine("Número máximo de parciales alcanzado.");
                            }
                            break;
                        case 'Q':
                            if (notas[i].quices.Count < 4)
                            {
                                Console.WriteLine(notas[i].quices);
                                notas[i].quices.Add(nota);
                                Console.WriteLine("Nota de quiz agregada.");
                            }
                            else
                            {
                                Console.WriteLine("Número máximo de quices alcanzado.");
                            }

                            break;
                        case 'T':
                            if (notas[i].trabajos.Count < 2)
                            {
                                notas[i].trabajos.Add(nota);
                                Console.WriteLine("Nota de trabajo agregada.");
                            }
                            else
                            {
                                Console.WriteLine("Número máximo de trabajos alcanzado.");
                            }
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                }
            }
        }

    }
}