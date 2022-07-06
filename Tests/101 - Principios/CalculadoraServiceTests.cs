using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program.Modelos;
using Program.Servicos;

namespace UnitTests._101___Principios
{

    // Framework utilizado: MSTest

    [TestClass]
    public class CalculadoraServiceTests
    {
        private CalculadoraService _service = new CalculadoraService();

        [TestMethod]
        public void OperacoesEntreDoisNumeros()
        {
            // Area de inicialização de valores
            var num1 = 10;
            var num2 = 20;
            var modelo = new NumeroModel(num1, num2);

            // Area de ações
            var somaResult = _service.Soma(modelo);
            var subtracaoResult = _service.Subtracao(modelo);
            var multiplicacaoResult = _service.Multiplicacao(modelo);

            // Area de validações
            Assert.AreEqual(somaResult, 30);
            Assert.AreEqual(subtracaoResult, -10);
            Assert.AreEqual(multiplicacaoResult, 200);
        }



        [TestMethod("Operações com dois numeros variaveis")]
        [DataRow(1, 2)]
        [DataRow(3, 5)]
        [DataRow(100, 100)]
        public void OperacoesEntreDoisNumerosVariaveis(int numero1, int numero2)
        {
            // Area de inicialização de valores
            var modelo = new NumeroModel(numero1, numero2);

            // Area de ações
            var somaResult = _service.Soma(modelo);
            var subtracaoResult = _service.Subtracao(modelo);
            var multiplicacaoResult = _service.Multiplicacao(modelo);

            // Area de validações
            Assert.IsTrue(somaResult == numero1 + numero2);
            Assert.IsTrue(subtracaoResult == numero1 - numero2);
            Assert.IsTrue(multiplicacaoResult == numero1 * numero2);
        }
    }
}
