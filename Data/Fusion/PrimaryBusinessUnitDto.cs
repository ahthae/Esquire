using System.ComponentModel;

namespace esquire.Data.Fusion;

public class PrimaryBusinessUnitDto : IDto
{
    [DisplayName("PER User Name")]
    public string? Username { get; set; }
    [DisplayName("Organization ID.")]
    public decimal? OrganizationId { get; set; }
    [DisplayName("Business Unit")]
    public string? Name { get; set; }
}