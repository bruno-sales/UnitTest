using Program.Servicos;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager(new CalculadoraService());
            manager.DoStuff();
        }
    }
}
