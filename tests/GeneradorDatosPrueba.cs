

namespace PIBImpact.Tests
{
    public class GeneradorDatosPrueba
    {
        public static void CrearArchivoCSV(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
            {
                Console.WriteLine("Ruta del archivo no válida.");
                return;
            }

            try
            {
                var lineas = GenerarDatos();

                File.WriteAllLines(rutaArchivo, lineas);
                Console.WriteLine($"Archivo creado correctamente en: {rutaArchivo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error al crear el archivo CSV: {ex.Message}");
            }
        }

        private static List<string> GenerarDatos()
        {
            var datos = new List<string>
            {
                "Nombre,PIB",
                "Brasil,1000.50",
                "Chile,2000.75",
                "Uruguay,1500.10"
            };

            return datos;
        }
    }
}
