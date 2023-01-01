using System.ComponentModel;

namespace esquire.Data;

public class BusinessUnitDataSecurityDto
{
    [DisplayName("PER User Name")]
    public string? Username { get; set; }
    [DisplayName("Role Name")]
    public string? RoleName { get; set; }
    [DisplayName("Business Unit")]
    public string? BuName { get; set; }
}