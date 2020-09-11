using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabNotasTests
{
    [TestClass]
    public class NotasFrequencias
    {
        private const string aprovado = "Aprovado";
        private const string reprovado = "Reprovado";

        [TestMethod]
        public void AprovacaoDisciplina()
        {
            string resultado = LabNotas.Program.ValidaNotaFrequencia(8, 0.7);
            Assert.AreEqual(resultado, aprovado);
        }

        [TestMethod]
        public void AprovacaoMinimaDisciplina()
        {
            string resultado = LabNotas.Program.ValidaNotaFrequencia(5, 0.6);
            Assert.AreEqual(resultado, aprovado);
        }

        [TestMethod]
        public void ReprovacaoDisciplina()
        {
            string resultado = LabNotas.Program.ValidaNotaFrequencia(4, 0.7);
            Assert.AreEqual(resultado, reprovado);
        }
    }
}
