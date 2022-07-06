using AutoFixture;
using Program.Modelos;

namespace UnitTests._301___Modelos_e_Estruturacao.Builders
{
    public class NumeroModelBuilder
    {
        private readonly Fixture _fixture;
        private NumeroModel _model;

        public NumeroModelBuilder() => _fixture = new Fixture();

        public NumeroModelBuilder BuildDefault()
        {
            _model = new NumeroModel()
            {
                Numero1 = _fixture.Create<int>(),
                Numero2 = _fixture.Create<int>()
            };

            return this;
        }

        public NumeroModelBuilder WithNumero1(int numero1)
        {
            _model.Numero1 = numero1;

            return this;
        }
        public NumeroModelBuilder WithNumero2(int numero2)
        {
            _model.Numero2 = numero2;

            return this;
        }
        
        public NumeroModel Create() => _model;
    }
}
