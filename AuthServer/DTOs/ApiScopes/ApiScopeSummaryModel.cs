using System.ComponentModel.DataAnnotations;

namespace AuthServer.DTOs.ApiScopes;

public class ApiScopeSummaryModel
{
    [Required]
    public string Name { get; set; }
    public string DisplayName { get; set; }
}