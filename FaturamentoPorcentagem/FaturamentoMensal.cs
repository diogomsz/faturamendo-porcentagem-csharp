namespace FaturamentoPorcentagem;

public class FaturamentoMensal
{
    public static List<FaturamentoPercent> CalculaPorcentagem()
    {
        List<FaturamentoPercent> porcentagem = new();
        List<FaturamentoPorEstado> f = RetornaValorFaturamento();

        double somaTotal = f.Sum(x => x.valor);
        double porcentagemAux;

        f.ForEach(p =>
        {
            porcentagemAux = p.valor / somaTotal;
            porcentagem.Add(new FaturamentoPercent(p.estado, porcentagemAux));
        });

        return porcentagem;
    }

    private static List<FaturamentoPorEstado> RetornaValorFaturamento()
    {
        List<FaturamentoPorEstado> faturamentoEstadual = new()
{
    new FaturamentoPorEstado("SP", 67836.43),
    new FaturamentoPorEstado("RJ", 36678.66),
    new FaturamentoPorEstado("MG", 29229.88),
    new FaturamentoPorEstado("ES", 27165.48),
    new FaturamentoPorEstado("Outros", 19849.53),
};

        return faturamentoEstadual;
    }
}