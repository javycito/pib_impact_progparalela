using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using PIBImpact.Models;

namespace PIBImpact.Analysis
{
    public static class ReporteGenerador
    {
        public static void GenerarReporteCsv(List<ResultadoSimulacion> resultados, string? rutaArchivo = null, int topSectores = 5)
    {
        // Definir ruta segura relativa a la raíz del proyecto
        if (string.IsNullOrEmpty(rutaArchivo))
        {
            rutaArchivo = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "metrics", "reporte_global.csv");
        }

        // Asegurar que el directorio exista
        string? directorio = Path.GetDirectoryName(rutaArchivo);
        if (!string.IsNullOrEmpty(directorio) && !Directory.Exists(directorio))
            Directory.CreateDirectory(directorio);

        // Calcular métricas
        double pibTotal = ResultAnalyzer.CalcularPibTotalAfectado(resultados);
        var sectoresImpactados = ResultAnalyzer.ObtenerSectoresMasImpactados(resultados, topSectores);

        // Configurar escritura CSV
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
            Delimiter = ","
        };

        using (var writer = new StreamWriter(rutaArchivo))
        using (var csv = new CsvWriter(writer, config))
        {
            csv.WriteField("Metrica");
            csv.WriteField("Valor");
            csv.NextRecord();

            csv.WriteField("PIB Total Afectado");
            csv.WriteField(pibTotal);
            csv.NextRecord();

            csv.WriteField("Top Sectores Más Impactados");
            csv.NextRecord();

            foreach (var sector in sectoresImpactados)
            {
                csv.WriteField(sector.Sector);
                }
            }
        }
        



            }
        }
