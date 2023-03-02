public class FaturamentoPercent
{
    public string estado { get; set; }
    public double porcentagem { get; set; }

    public FaturamentoPercent(string estado, double porcentagem)
    {
        this.estado = estado;
        this.porcentagem = porcentagem;
    }
}
