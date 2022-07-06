namespace Program.Modelos
{
    /// <summary>
    /// Classe que encapsula os numeros digitados pelo usuario
    /// qual ocorrerá uma operação aritmética
    /// </summary>
    public class NumeroModel
    {
        /// <summary>
        /// O primeiro numero da operação
        /// </summary>
        public int Numero1 { get; set; }

        /// <summary>
        /// O primeiro numero da operação
        /// </summary>
        public int Numero2 { get; set; }

        public NumeroModel(int num1, int num2)
        {
            Numero1 = num1;
            Numero2 = num2;
        }

        public NumeroModel() {}
    }
}
