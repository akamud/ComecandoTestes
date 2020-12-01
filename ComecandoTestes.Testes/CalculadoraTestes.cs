using NUnit.Framework;

namespace ComecandoTestes.Testes
{
    public class CalculadoraTestes
    {
        [Test]
        public void Somar20Mais30DeveriaSer50()
        {
            Assert.AreEqual(50, new Calculadora().Somar(20, 30));
        }
        
        [Test]
        public void Subtrair30Menos10DeveriaSer20()
        {
            Assert.AreEqual(20, new Calculadora().Subtrair(30, 10));
        }
        
        [Test]
        public void Multiplicar20Vezes3DeveriaSer60()
        {
            Assert.AreEqual(60, new Calculadora().Multiplicar(20, 3));
        }
        
        [Test]
        public void Dividir40Por4DeveriaSer10()
        {
            Assert.AreEqual(10, new Calculadora().Dividir(40, 4));
        }
    }
}