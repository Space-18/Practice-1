using Practice.Application.Models;

namespace Practice.Application.Contracts.Insfrastructure
{
    public interface IRequestExternalApiService
    {
        Task<TleData> GetTleAPIData();
    }
}
