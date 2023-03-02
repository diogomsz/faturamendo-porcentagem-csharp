namespace FaturamentoPorcentagem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<FaturamentoPercent> fp = FaturamentoMensal.CalculaPorcentagem();
            fp.ForEach(x =>
            {
                Console.WriteLine($"Estado: {x.estado} - Porcentagem de representação: {x.porcentagem:P}");
            });
        }
    }
}
