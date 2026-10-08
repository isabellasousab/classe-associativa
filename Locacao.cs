using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Locacao
{
    private Cliente _cliente = null!;
    private Veiculo _veiculo = null!;
    private DateOnly _dataRetirada;
    private int _quantidadeDias;
    private decimal _valorDiaria;

    public Cliente Cliente
    {
        get { return _cliente; }
        set { _cliente = value; }
    }

    public Veiculo Veiculo
    {
        get { return _veiculo; }
        set { _veiculo = value; }
    }

    public DateOnly DataRetirada
    {
        get { return _dataRetirada; }
        set { _dataRetirada = value; }
    }

    public int QuantidadeDias
    {
        get { return _quantidadeDias; }
        set { _quantidadeDias = value; }
    }

    public decimal ValorDiaria
    {

        get { return _valorDiaria; }
        set { _valorDiaria = value; }
    }

    public Locacao(Cliente cliente, Veiculo veiculo, DateOnly dataRetirada, int quantidadeDias, decimal ValorDiaria)
    {
        this.Cliente = cliente;
        this.Veiculo = veiculo;
        this.DataRetirada = dataRetirada;
        this.QuantidadeDias = quantidadeDias;
        this.ValorDiaria = ValorDiaria;
    }

    public decimal CalcularValorBruto()
    {
        decimal bruto = QuantidadeDias * ValorDiaria;
        return bruto;
    }

    public decimal CalcularDesconto()
    {
        decimal desconto;

        if (QuantidadeDias >= 15)
        {
            desconto = CalcularValorBruto() * 0.15m;
        }
        else if (QuantidadeDias >= 7)
        {
            desconto = CalcularValorBruto() * 0.10m;
        }
        else
        {
            Console.WriteLine("Não há desconto.");
            desconto = 0;
        }

        return desconto;
    }

    public decimal CalcularValorFinal()
    {
        decimal final = CalcularValorBruto() - CalcularDesconto();
        return final;
    }

    public void ExibirResumo()
    {
        Console.WriteLine("----CLIENTE----");
        Console.WriteLine($"Nome cliente: {Cliente.Nome}");
        Console.WriteLine($"CPF cliente: {Cliente.Cpf}");
        Console.WriteLine();
        Console.WriteLine("----VEÍCULO----");
        Console.WriteLine($"Modelo veículo: {Veiculo.Modelo}");
        Console.WriteLine($"Placa veículo: {Veiculo.Placa}");

        decimal bruto = CalcularValorBruto();
        decimal desconto = CalcularDesconto();
        decimal final = CalcularValorFinal();

        Console.WriteLine();

        Console.WriteLine("-----LOCAÇÃO-----");
        Console.WriteLine($"Data de retirada: {DataRetirada}");
        Console.WriteLine($"Quantidade de dias: {QuantidadeDias:F2}");
        Console.WriteLine($"Valor da diária: {ValorDiaria:F2}");
        Console.WriteLine($"Valor bruto: {bruto:F2}");
        Console.WriteLine($"Desconto: {desconto:F2}");
        Console.WriteLine($"Valor final: {final:F2}");

    }
}