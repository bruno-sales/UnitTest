using FluentAssertions;
using Moq;
using Program;
using Program.Interfaces;
using Program.Modelos;
using UnitTests._301___Modelos_e_Estruturacao.Builders;
using Xunit;

namespace UnitTests._301___Modelos_e_Estruturacao.Behaviours
{
    // Framework utilizado: XUnit

    public class SomaTests
    {

        private readonly Mock<ICalculadoraService> _calculadoraService;
        private readonly Manager _manager;

        public SomaTests()
        {
            _calculadoraService = new Mock<ICalculadoraService>();

            // Passagem de objeto de mock
            _manager = new Manager(_calculadoraService.Object);
        }

        [Fact]
        public void SomaEntreDoisNumeros()
        {
            // Area de inicialização de valores
            var numModel = new NumeroModelBuilder().BuildDefault().Create();

            // Inicializacao de mocks
            _calculadoraService.Setup(i => i.Soma(numModel))
                .Returns(numModel.Numero1 + numModel.Numero2);

            // Area de ações
            var somaResult = _manager.SomaEntreNumeros(numModel);

            // Area de validações
            if (numModel.Numero2 < 0)
            {
                somaResult.Should().BeLessThan(numModel.Numero1);
            }
            else if (numModel.Numero2 > 0)
            {
                somaResult.Should().BeGreaterThan(numModel.Numero1);
            }
            else
            {
                somaResult.Should().Be(numModel.Numero1);
            }
        }
    }
}
