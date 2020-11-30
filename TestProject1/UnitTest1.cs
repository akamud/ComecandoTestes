using ComecandoTestes;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Somar20Mais30DeveriaSer50()
        {
            Assert.AreEqual(50, Calculadora.Somar(20, 30));
        }
        
        [Test]
        public void Subtrair30Menos10DeveriaSer20()
        {
            Assert.AreEqual(20, Calculadora.Subtrair(30, 10));
        }
        
        [Test]
        public void Multiplicar20Vezes3DeveriaSer60()
        {
            Assert.AreEqual(60, Calculadora.Multiplicar(20, 3));
        }
        
        [Test]
        public void Dividir40Por4DeveriaSer10()
        {
            Assert.AreEqual(10, Calculadora.Dividir(40, 4));
        }
    }
}