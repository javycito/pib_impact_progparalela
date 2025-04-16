using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

class ResultadoSimulacion
{
    public string Pais { get; set; }
    public double PIBOriginal { get; set; }
    public double TasaArancel { get; set; }
    public double PIBAjustado { get; set; }

    public override string ToString()
    {
        return $"{Pais} - PIB Ajustado: {PIBAjustado}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        string rutaArchivo = "C:\\Users\\souls\\Desktop\\ITLA C6\\Programacion paralela\\datos.csv";
        int tamañoBloque = 100;
        var resultados = new List<ResultadoSimulacion>(); // Lista antes de utilizar el concurrentbag (NO ES SEGURO)
        var reloj = Stopwatch.StartNew();

        using (var lector = new StreamReader(rutaArchivo))
        {
            string encabezado = lector.ReadLine(); // Leer y descartar el encabezado (primera línea)

            List<string> bloque = new List<string>();

            while (!lector.EndOfStream)
            {

                // Validacion para saber el estado de las lineas
                for (int i = 0; i < tamañoBloque && !lector.EndOfStream; i++)
                {
                    string linea = lector.ReadLine();
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        bloque.Add(linea); // Añade línea al bloque actual
                    }
                }

                Parallel.ForEach(bloque, linea =>
                {
                    var partes = linea.Split(',');
                    if (partes.Length == 3)
                    {
                        try
                        {
                            string pais = partes[0];
                            double pib = double.Parse(partes[1]);
                            double tasa = double.Parse(partes[2]);

                            double pibAjustado = pib * (1 - tasa);

                            //  Esto no es seguro en paralelismo, solo para demostración
                            resultados.Add(new ResultadoSimulacion
                            {
                                Pais = pais,
                                PIBOriginal = pib,
                                TasaArancel = tasa,
                                PIBAjustado = pibAjustado
                            });
                        }
                        catch
                        {
                            Console.WriteLine($"Error al procesar línea: {linea}");
                        }
                    }
                });

                bloque.Clear(); // Limpiar bloque para el siguiente grupo de líneas
            }
        }

        reloj.Stop();

        Console.WriteLine("=== RESULTADOS ===");
        foreach (var resultado in resultados)
        {
            Console.WriteLine(resultado);
        }

        Console.WriteLine("\n=== MÉTRICAS ===");
        Console.WriteLine($"Líneas procesadas: {resultados.Count}");
        Console.WriteLine($"Tiempo total: {reloj.ElapsedMilliseconds} ms");
        Console.WriteLine($"Memoria usada: {GC.GetTotalMemory(false) / 1024.0:F2} KB");
    }
}
