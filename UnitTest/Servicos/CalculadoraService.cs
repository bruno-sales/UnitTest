using System;
using Program.Interfaces;
using Program.Modelos;

namespace Program.Servicos
{
    /// <summary>
    /// Serviço de calculos basicos de matemática
    /// </summary>
    public class CalculadoraService : ICalculadoraService
    {
        public int Soma(NumeroModel model) => model.Numero1 + model.Numero2;

        public int Subtracao(NumeroModel model) => model.Numero1 - model.Numero2;

        public int Multiplicacao(NumeroModel model) => model.Numero1 * model.Numero2;

        public int Divisao(NumeroModel model)
        {
            throw new NotImplementedException();
        }
    }
}
