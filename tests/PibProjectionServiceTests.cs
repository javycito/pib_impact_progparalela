using PBImpact.Services;
using PBImpact.Models;
using Xunit;
using System.Collections.Generic;

namespace PBImpact.Tests
{
    public class PibProjectionServiceTests
    {
        [Fact]
        public void ProyectarPibAjustado5Years_RetornaListaCon5Elementos()
        {
            double pibOriginal = 1000;
            double tasaArancel = 0.1;
            double tasaCrecimiento = 0.02;

            var resultado = PibProjectionService.ProyectarPibAjustado5Years(pibOriginal, tasaArancel, tasaCrecimiento);

            Assert.Equal(5, resultado.Count);
        }
    }
}