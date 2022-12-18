using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerCountrySecurityProfile
    {
        public decimal? CountrySecurityProfileId { get; set; }
        public string? ModuleId { get; set; }
        public string? ViewAll { get; set; }
        public string? Name { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? EnabledFlag { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? LastUpdateLogin { get; set; }
        public string? Sguid { get; set; }
        public string? SeedDataSource { get; set; }
    }
}
