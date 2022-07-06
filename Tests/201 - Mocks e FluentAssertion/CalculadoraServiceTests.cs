using FluentAssertions;
using Moq;
using Program;
using Program.Interfaces;
using Program.Modelos;
using Xunit;

namespace UnitTests._201___Mocks_e_FluentAssertion
{

    // Framework utilizado: XUnit

    public class CalculadoraServiceTests
    {
        private readonly Mock<ICalculadoraService> _calculadoraService;
        private readonly Manager _manager;

        public CalculadoraServiceTests()
        {
            _calculadoraService = new Mock<ICalculadoraService>();

            // Passagem de objeto de mock
            _manager = new Manager(_calculadoraService.Object);
        }

        [Fact]
        public void DivisaoEntreDoisNumeros()
        {
            // Area de inicialização de valores
            var num1 = 20;
            var num2 = 10;
            var modelo = new NumeroModel(num1, num2);

            // Inicializacao de mocks
            _calculadoraService.Setup(i => i.Divisao(It.IsAny<NumeroModel>())).Returns(num1 / num2);

            // Area de ações
            var divisaoResult = _manager.DivisaoEntreNumeros(modelo);

            // Area de validações
            divisaoResult.Should().Be(2);
        }


        [Theory(DisplayName = "Operacoes com mock")]
        [InlineData(1, 2)]
        [InlineData(0, 5)]
        [InlineData(10, 1)]
        [InlineData(int.MinValue, int.MaxValue)]
        public void OperacoesEntreDoisNumeros(int num1, int num2)
        {
            // Area de inicialização de valores
            var modelo = new NumeroModel(num1, num2);

            // Inicializacao de mocks
            _calculadoraService.Setup(i => i.Soma(It.IsAny<NumeroModel>())).Returns(num1 + num2);
            _calculadoraService.Setup(i => i.Subtracao(It.IsAny<NumeroModel>())).Returns(0);
            _calculadoraService.Setup(i => i.Multiplicacao(It.IsAny<NumeroModel>())).Returns(num1 * num2);
            _calculadoraService.Setup(i => i.Divisao(It.IsAny<NumeroModel>())).Returns(-10);

            // Area de ações
            var somaResult = _manager.SomaEntreNumeros(modelo);
            var subtracaoResult = _manager.SubtracaoEntreNumeros(modelo);
            var multiplicacaoResult = _manager.MultiplicacaoEntreNumeros(modelo);
            var divisaoResult = _manager.DivisaoEntreNumeros(modelo);

            // Area de validações
            somaResult.Should().BeGreaterOrEqualTo(-1);
            subtracaoResult.Should().Be(0);
            multiplicacaoResult.Should().Be(num1 * num2);
            divisaoResult.Should().NotBe(num1 / num2);
        }
    }
}
