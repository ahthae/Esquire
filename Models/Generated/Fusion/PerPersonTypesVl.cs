using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerPersonTypesVl
    {
        public string? RowId { get; set; }
        public decimal? PersonTypeId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? ActiveFlag { get; set; }
        public string? DefaultFlag { get; set; }
        public string? SystemPersonType { get; set; }
        public string? UserPersonType { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? SeededPersonTypeKey { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? ModuleId { get; set; }
        public string? Sguid { get; set; }
    }
}
