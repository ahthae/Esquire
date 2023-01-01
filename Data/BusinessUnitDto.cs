using System;
using System.ComponentModel;

namespace esquire.Data;

public class BusinessUnitDto
{
    [DisplayName("Business Unit ID.")] public decimal? BuId { get; set; }
    [DisplayName("Business Unit Name")] public string? BuName { get; set; }
    [DisplayName("Business Group ID.")] public decimal? BusinessGroupId { get; set; }
    [DisplayName("Creation Date")] public DateTime? CreationDate { get; set; }
    [DisplayName("Date From")] public DateTime? DateFrom { get; set; }
    [DisplayName("Date To")] public DateTime? DateTo { get; set; }
    [DisplayName("Default Currency Code")] public string? DefaultCurrencyCode { get; set; }
    [DisplayName("Default Set ID.")] public decimal? DefaultSetId { get; set; }
    [DisplayName("Enabled for HR?")] public string? EnabledForHrFlag { get; set; }
    [DisplayName("Financial Business Unit ID.")] public decimal? FinBusinessUnitId { get; set; }
    [DisplayName("Last Update DAte")] public string? LastUpdateDate { get; set; }
    [DisplayName("Last Update Login")] public string? LastUpdateLogin { get; set; }
    [DisplayName("Last Updated By")] public string? LastUpdatedBy { get; set; }
    [DisplayName("Legal Entity ID.")] public decimal? LegalEntityId { get; set; }
    [DisplayName("Location ID.")] public decimal? LocationId { get; set; }
    [DisplayName("Manager ID.")] public decimal? ManagerId { get; set; }
    [DisplayName("Primary Ledger ID.")] public decimal? PrimaryLedgerId { get; set; }
    [DisplayName("Profit Center?")] public string? ProfitCenterFlag { get; set; }
    [DisplayName("Short Code")] public string? ShortCode { get; set; }
    [DisplayName("Status")] public string? Status { get; set; }
}