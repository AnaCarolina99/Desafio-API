using System.Data.SqlClient;
using Application.Interfaces;
using Dapper;
using WebApplication1.Entities;

namespace Infrastructure.Repositories;


public class HospedagemRepository : IHospedagemRepository
{
    private readonly IConfiguration configuration;
    public HospedagemRepository(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
    public async Task<int> AddAsync(Hospedagem entity)
    {
        entity.AddedOn = DateTime.Now;
        var sql = "Insert into Hospedagem (codChale,estado,dataInicio,dataFim,AddedOn) VALUES (@codChale,@estado,@dataInicio,@dataFim,@AddedOn)";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.ExecuteAsync(sql, entity);
            return result;
        }
    }
    public async Task<int> DeleteAsync(int id)
    {
        var sql = "DELETE FROM Hospedagem WHERE codHospedagem = @codHospedagem";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.ExecuteAsync(sql, new { codHospedagem = id });
            return result;
        }
    }
    public async Task<IReadOnlyList<Hospedagem>> GetAllAsync()
    {
        var sql = "SELECT * FROM Hospedagem";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.QueryAsync<Hospedagem>(sql);
            return result.ToList();
        }
    }
    public async Task<Hospedagem> GetByIdAsync(int id)
    {
        var sql = "SELECT * FROM Hospedagem WHERE codHospedagem = @codHospedagem";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.QuerySingleOrDefaultAsync<Hospedagem>(sql, new { codHospedagem = id });
            return result;
        }
    }
    public async Task<int> UpdateAsync(Hospedagem entity)
    {
        entity.ModifiedOn = DateTime.Now;
        var sql = "UPDATE Hospedagem SET codChale = @codChale, estado = @estado, dataInicio = @dataInicio, dataFim = @dataFim, ModifiedOn = @ModifiedOn  WHERE Id = @codHospedagem";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.ExecuteAsync(sql, entity);
            return result;
        }
    }
}