using System;
using Program.Interfaces;
using Program.Modelos;

namespace Program
{
    public class Manager
    {
        private readonly ICalculadoraService _calculadoraService;

        public Manager(ICalculadoraService calculadoraService)
        {
            _calculadoraService = calculadoraService;
        }

        public int SomaEntreNumeros(NumeroModel model)
        {
            return _calculadoraService.Soma(model);
        }

        public int SubtracaoEntreNumeros(NumeroModel model)
        {
            return _calculadoraService.Subtracao(model);
        }

        public int MultiplicacaoEntreNumeros(NumeroModel model)
        {
            return _calculadoraService.Multiplicacao(model);
        }

        public int DivisaoEntreNumeros(NumeroModel model)
        {
            if (model.Numero2 == 0) return 0;

            return _calculadoraService.Divisao(model);
        }


        public void DoStuff()
        {
            Console.Write("Informe seu primeiro número: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe seu segundo número: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("===================================================================");

            var numModel = new NumeroModel(num1, num2);

            var soma = SomaEntreNumeros(numModel);
            var subtracao = SubtracaoEntreNumeros(numModel);
            var multiplicao = MultiplicacaoEntreNumeros(numModel);

            Console.WriteLine("A soma entre seus numeros: " + soma);
            Console.WriteLine("A subtração entre seus numeros: " + subtracao);
            Console.WriteLine("A multiplicação entre seus numeros: " + multiplicao);

            Console.WriteLine("===================================================================");
        }

    }
}
