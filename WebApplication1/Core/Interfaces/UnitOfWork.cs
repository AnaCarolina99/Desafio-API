namespace Application.Interfaces;

public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(IHospedagemRepository hospedagemRepository)
    {
        Hospedagem = hospedagemRepository;
    }
    public IHospedagemRepository Hospedagem { get; }
}