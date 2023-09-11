using AuthServer.DTOs.ApiScopes;

namespace AuthServer.Data.ApiScopes;

public interface IApiScopeRepository
{
    Task<IEnumerable<ApiScopeSummaryModel>> GetAllAsync(string filter = null);
    Task<ApiScopeModel> GetbyIdAsync(string id);
    Task CreateAsync(ApiScopeModel model);
    Task UpdateAsync(ApiScopeModel model);
    Task DeleteAsync(string id);
}
