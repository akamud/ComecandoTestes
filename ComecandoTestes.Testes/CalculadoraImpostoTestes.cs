using ComecandoTestes.ImpostoRenda;
using FakeItEasy;
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
            var fakeServicoIR = A.Fake<IServicoImpostoRenda>();
            A.CallTo(() => fakeServicoIR.ObterAliquota(3000)).Returns(10);
            var calculadoraImposto = new CalculadoraImposto(fakeServicoIR);
            
            // Act
            var resultado = await calculadoraImposto.CalcularSalarioLiquido(3000);
            
            // Assert
            resultado.Should().Be(2700);
        }
    }
}