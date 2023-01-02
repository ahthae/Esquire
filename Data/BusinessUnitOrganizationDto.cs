using System;
using System.ComponentModel;

namespace esquire.Data;

public class BusinessUnitOrganizationDto : IDto
{
    [DisplayName("Organization Id.")]
    public decimal? OrganizationId { get; set; }
    [DisplayName("Org. Name (Business Unit Name)")]
    public string? Name { get; set; }
    [DisplayName("Business Group ID.")] 
    public decimal? BusinessGroupId { get; set; }
    [DisplayName("Org. Date To")] 
    public DateTime? DateTo { get; set; }
}