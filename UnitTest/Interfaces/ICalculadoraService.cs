using Program.Modelos;

namespace Program.Interfaces
{
    /// <summary>
    /// Interface para operações basicas de matematica
    /// </summary>
    public interface ICalculadoraService
    {
        /// <summary>
        /// Soma dois numeros inteiros
        /// </summary>
        /// <param name="model">Modelo com os numeros sob quais ocorrerá a operação</param>
        /// <returns>num1 + num2</returns>
        int Soma(NumeroModel model);

        /// <summary>
        /// Subtrai dois numeros inteiros
        /// </summary>
        /// <param name="model">Modelo com os numeros sob quais ocorrerá a operação</param>
        /// <returns>num1 - num2</returns>
        int Subtracao(NumeroModel model);

        /// <summary>
        /// Multiplica dois numeros inteiros
        /// </summary>
        /// <param name="model">Modelo com os numeros sob quais ocorrerá a operação</param>
        /// <returns>num1 * num2</returns>
        int Multiplicacao(NumeroModel model);

        /// <summary>
        /// Divide dois numeros inteiros
        /// </summary>
        /// <param name="model">Modelo com os numeros sob quais ocorrerá a operação</param>
        /// <returns>num1 / num2</returns>
        int Divisao(NumeroModel model);
    }
}
