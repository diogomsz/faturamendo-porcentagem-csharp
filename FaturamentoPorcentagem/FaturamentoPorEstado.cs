namespace FaturamentoPorcentagem;

public class FaturamentoPorEstado
{
    public string estado { get; set; }
    public double valor { get; set; }

    public FaturamentoPorEstado(string estado, double valor)
    {
        this.estado = estado;
        this.valor = valor;
    }
}