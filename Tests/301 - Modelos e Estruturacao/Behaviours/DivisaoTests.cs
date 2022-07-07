using FluentAssertions;
using Moq;
using Program;
using Program.Interfaces;
using UnitTests._301___Modelos_e_Estruturacao.Builders;
using Xunit;

namespace UnitTests._301___Modelos_e_Estruturacao.Behaviours
{

    // Framework utilizado: Xunit

    public class DivisaoTests
    {
        private readonly Mock<ICalculadoraService> _calculadoraService;
        private readonly Manager _manager;

        public DivisaoTests()
        {
            _calculadoraService = new Mock<ICalculadoraService>();

            // Passagem de objeto de mock
            _manager = new Manager(_calculadoraService.Object);
        }

        [Fact(DisplayName = "Uma divisao por zero deve ser zero")]
        public void DivisaoPorZero()
        {
            // Area de inicialização de valores
            var numModel = new NumeroModelBuilder()
                .BuildDefault()
                .WithNumero2(0)
                .Create();

            // Inicializacao de mocks
            _calculadoraService.Setup(i => i.Divisao(numModel)).Returns(0);

            // Area de ações
            var divisaoResult = _manager.DivisaoEntreNumeros(numModel);

            // Area de validações
            divisaoResult.Should().Be(0);
        }
    }
}
