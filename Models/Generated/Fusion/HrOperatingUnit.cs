using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class HrOperatingUnit
    {
        public decimal? BusinessGroupId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? DefaultLegalContextId { get; set; }
        public string? Name { get; set; }
        public decimal? OrganizationId { get; set; }
        public decimal? SetOfBooksId { get; set; }
        public string? ShortCode { get; set; }
        public string? UsableFlag { get; set; }
    }
}
