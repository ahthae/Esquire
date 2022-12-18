using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class FunAllBusinessUnitsV
    {
        public decimal? BuId { get; set; }
        public string? BuName { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string? DefaultCurrencyCode { get; set; }
        public decimal? DefaultSetId { get; set; }
        public string? EnabledForHrFlag { get; set; }
        public decimal? FinBusinessUnitId { get; set; }
        public string? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? LastUpdatedBy { get; set; }
        public decimal? LegalEntityId { get; set; }
        public decimal? LocationId { get; set; }
        public decimal? ManagerId { get; set; }
        public decimal? PrimaryLedgerId { get; set; }
        public string? ProfitCenterFlag { get; set; }
        public string? ShortCode { get; set; }
        public string? Status { get; set; }
    }
}
