using Application.Interfaces;

namespace Infrastructure.Repositories;

public static class ServiceRegistration
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IHospedagemRepository, HospedagemRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
    }
}