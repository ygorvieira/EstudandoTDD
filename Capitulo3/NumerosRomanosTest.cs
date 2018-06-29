using NUnit.Framework;

namespace Capitulo3
{
    [TestFixture]
    public class NumerosRomanosTest
    {
        [Test]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }

        [Test]
        public void DeveEntenderOSimboloV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }

        [Test]
        public void DeveEntenderDoisSimbolosComoII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("II");
            Assert.AreEqual(2, numero);
        }

        [Test]
        public void DeveEntenderQuatroSimbolosDoisADoisComoXXII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXII");
            Assert.AreEqual(22, numero);
        }

        [Test]
        public void DeveEntenderSimbolosDiferentesComoIX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("IX");
            Assert.AreEqual(9, numero);
        }
    }
}
