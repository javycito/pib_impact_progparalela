using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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

        int cantidadEsperada = ContarLineasValidas(rutaArchivo);
        var resultados = new ConcurrentBag<ResultadoSimulacion>();

        var reloj = Stopwatch.StartNew();

        using (var lector = new StreamReader(rutaArchivo))
        {
            string encabezado = lector.ReadLine(); // Saltar encabezado

            List<string> bloque = new List<string>();

            while (!lector.EndOfStream)
            {
                for (int i = 0; i < tamañoBloque && !lector.EndOfStream; i++)
                {
                    string linea = lector.ReadLine();
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        bloque.Add(linea);
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

                            lock (resultados)
                            {
                                resultados.Add(new ResultadoSimulacion
                                {
                                    Pais = pais,
                                    PIBOriginal = pib,
                                    TasaArancel = tasa,
                                    PIBAjustado = pibAjustado
                                });
                            }
                        }
                        catch
                        {
                            Console.WriteLine($"Error al procesar línea: {linea}");
                        }
                    }
                });

                bloque.Clear();
            }
        }

        reloj.Stop();

        Console.WriteLine("------- RESULTADOS -------");
        foreach (var resultado in resultados)
        {
            Console.WriteLine(resultado);
        }

        Console.WriteLine("------- ESTADISTICAS -------");
        Console.WriteLine($"Líneas procesadas: {resultados.Count}");
        Console.WriteLine($"Tiempo total: {reloj.ElapsedMilliseconds} ms");

        // PROBANDO LOS RESULTADOS / VALIDANDO
        ValidarResultados(resultados, cantidadEsperada);
    }

    // Validando la cantidad de lineas respectivas al bloque

    static int ContarLineasValidas(string ruta)
    {
        int contador = 0;
        using (var lector = new StreamReader(ruta))
        {
            lector.ReadLine(); 
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                if (!string.IsNullOrWhiteSpace(linea))
                {
                    contador++;
                }
            }
        }
        return contador;
    }


    // Validando los resultados
    static void ValidarResultados(List<ResultadoSimulacion> resultados, int esperados)
    {
        Console.WriteLine("VALIDACIÓN DE PRUEBAS:");

        if (resultados.Count == esperados)
        {
            Console.WriteLine("Cantidad de resultados esperada");
        }
        else
        {
            Console.WriteLine($"Ha ocurrido un error!: Se esperaban {esperados}, pero se obtuvieron {resultados.Count}");
        }

        int errores = resultados.Count(r => r.Pais == null || r.PIBAjustado <= 0);
        if (errores == 0)
        {
            Console.WriteLine("Todos los resultados son válidos");
        }
        else
        {
            Console.WriteLine($"Hay {errores} resultados inválidos");
        }
    }
}
