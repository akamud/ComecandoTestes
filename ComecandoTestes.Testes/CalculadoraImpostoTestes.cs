using ComecandoTestes.ImpostoRenda;
using FluentAssertions;
using NUnit.Framework;
using System.Threading.Tasks;

namespace ComecandoTestes.Testes
{
    public class CalculadoraImpostoTestes
    {
        [Test]
        public async Task CalcularSalarioLiquidoDeveDescontarAliquotaDoSalarioPassado()
        {
            // Arrange
            var calculadoraImposto = new CalculadoraImposto();
            
            // Act
            var resultado = await calculadoraImposto.CalcularSalarioLiquido(3000);
            
            // Assert
            resultado.Should().Be(2700);
        }
    }
}