using ScottPlot;
using System;
using System.Collections.Generic;
using System.IO;

namespace PIBImpact.analysis
{
    public static class Graficador
    {
        public static void GraficarTiempos(long tiempoSecuencial, long tiempoParalelo)
        {
            double[] valores = { tiempoSecuencial, tiempoParalelo };
            string[] etiquetas = { "Secuencial", "Paralela" };

            var plt = new ScottPlot.Plot(600, 400);
            var barras = plt.AddBar(valores);

            plt.XTicks(etiquetas);
            plt.Title("Comparacion de Tiempos de Ejecución");
            plt.YLabel("Tiempo (ms)");
            plt.SetAxisLimits(yMin: 0);

            // Ruta relativa a la raíz del proyecto
            string rutaArchivo = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "metrics", "grafica_tiempos.png");

            // Crear directorio si no existe
            string? directorio = Path.GetDirectoryName(rutaArchivo);
            if (!string.IsNullOrEmpty(directorio) && !Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);

            plt.SaveFig(rutaArchivo);
            Console.WriteLine($" Grafica de tiempos guardada en: {Path.GetFullPath(rutaArchivo)}");
        }

        
            
        }

    }
