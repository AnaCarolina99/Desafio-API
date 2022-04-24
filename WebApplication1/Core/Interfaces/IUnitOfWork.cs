namespace Application.Interfaces;

public interface IUnitOfWork
{
    IHospedagemRepository  Hospedagem { get; }
}