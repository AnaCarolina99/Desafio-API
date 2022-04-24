namespace WebApplication1.Entities;

public class Hospedagem
{
    public int codHospedagem
    {
        get; set; 
    }
    public int codChale
    {
        get; set;
    }
    public string estado
    {
        get; set;
    }
    public string dataInicio
    {
        get; set;
    }
    public string dataFim
    {
        get; set;
    }
    public int qtdPessoas
    {
        get; set;
    }
    public double desconto
    {
        get; set;
    }
    public double valorFinal
    {
        get; set;
    }
    public string localizacao
    {
        get; set;
    }

    public int capacidade
    {
        get; set;
    }
    public double valorAltaEstacao
    {
        get; set;
    }
    public double valorBaixaEstacao
    {
        get; set;
    }
    public int nomeItem
    {
        get; set;
    }
    public int codCliente
    {
        get; set;
    }
    public string nomeCliente
    {
        get; set;
    }
    public string rgCliente
    {
        get; set;
    }
    public string enderecoCliente
    {
        get; set;
    }
    public string bairroCliente
    {
        get; set;
    }
    public string cidadeCliente
    {
        get; set;
    }
    public string estadoCliente
    {
        get; set;
    }
    public string CEPCliente
    {
        get; set;
    }
    public string nascimentoCliente
    {
        get; set;
    }
    public int dataServico
    {
        get; set;
    }
    public int codServico
    {
        get; set;
    }
    public double valorServico
    {
        get; set;
    }
    public string descricaoItem
    {
        get; set;
    }
    public string nomeServico
    {
        get; set;
    }
    public int telefone
    {
        get; set;
    }
    public int tipoTelefone
    {
        get; set;
    }
    public DateTime AddedOn
    {
        get; set;
    }
    public DateTime ModifiedOn
    {
        get; set;
    }
}