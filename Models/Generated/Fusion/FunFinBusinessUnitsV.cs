using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class FunFinBusinessUnitsV
    {
        public decimal? BuId { get; set; }
        public string? BuName { get; set; }
        public decimal? LocationId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? ManagerId { get; set; }
        public decimal? LegalEntityId { get; set; }
        public decimal? PrimaryLedgerId { get; set; }
        public decimal? DefaultSetId { get; set; }
        public string? ShortCode { get; set; }
        public string? DefaultCurrencyCode { get; set; }
        public string? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
    }
}
