using ComecandoTestes.ImpostoRenda;
using FakeItEasy;
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
            Assert.AreEqual(2700, resultado);
        }
    }
}