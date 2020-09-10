using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabNotasTests
{
    [TestClass]
    public class NotasFrequencias
    {
        private const string aprovado = "Aprovado";

        [TestMethod]
        public void AprovacaoDisciplina()
        {
            string resultado = LabNotas.Program.ValidaNotaFrequencia(5, 0.7);
            Assert.AreEqual(resultado, aprovado);
        }
    }
}
