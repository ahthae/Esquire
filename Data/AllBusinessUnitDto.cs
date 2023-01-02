using System.ComponentModel;

namespace esquire.Data;

public class AllBusinessUnitDto : IDto
{
    [DisplayName("PER User Name")]
    public string? Username { get; set; }
    [DisplayName("Business Unit")]
    public string? Name { get; set; }
}