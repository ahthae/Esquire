using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class GlLedgerLeV
    {
        public decimal? LedgerId { get; set; }
        public string? LedgerCategoryCode { get; set; }
        public string? CurrencyCode { get; set; }
        public decimal? ChartOfAccountsId { get; set; }
        public string? PeriodSetName { get; set; }
        public string? AccountedPeriodType { get; set; }
        public string? SlaAccountingMethodCode { get; set; }
        public string? SlaAccountingMethodType { get; set; }
        public string? BalSegValueOptionCode { get; set; }
        public string? BalSegColumnName { get; set; }
        public decimal? BalSegValueSetId { get; set; }
        public decimal? ConfigurationId { get; set; }
        public string? AcctgEnvironmentCode { get; set; }
        public string? LedgerName { get; set; }
        public decimal? LedgerShortName { get; set; }
        public decimal? LegalEntityId { get; set; }
        public string? LegalEntityName { get; set; }
        public string? LocationCode { get; set; }
        public string? LocationDescription { get; set; }
        public decimal? LocationId { get; set; }
        public decimal? PrimaryLedgerId { get; set; }
        public string? RelationshipEnabledFlag { get; set; }
    }
}
