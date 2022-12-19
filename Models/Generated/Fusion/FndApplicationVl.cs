using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class FndApplicationVl
    {
        public decimal? ApplicationId { get; set; }
        public string? ApplicationName { get; set; }
        public string? ApplicationShortName { get; set; }
        public string? Basepath { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? Description { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? LastUpdateLogin { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string? ModuleId { get; set; }
        public string? ProductCode { get; set; }
        public string? RowId { get; set; }
    }
}
