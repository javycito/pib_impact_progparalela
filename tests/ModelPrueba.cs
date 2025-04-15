using Xunit;
using PBImpact.Models;

namespace PBImpact.Tests
{
    public class PaisesPrueba
    {
        private Pais CrearPaisPrueba()
        {
            return new Pais { Nombre = "Brasil", PIB = 1000.50m };
        }

        [Fact]
        public void DeberiaRetornarNombreCorrecto()
        {
            var pais = CrearPaisPrueba();
            var nombre = pais.Nombre;
            Assert.Equal("Brasil", nombre);
        }

        [Fact]
        public void DeberiaRetornarPIBCorrecto()
        {
            var pais = CrearPaisPrueba();
            var pib = pais.PIB;
            Assert.Equal(1000m, pib);
        }
    }
}
