using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class FndFormFunctionsVl
    {
        public string? RowId { get; set; }
        public decimal? FunctionId { get; set; }
        public string? FunctionName { get; set; }
        public decimal? ObjectId { get; set; }
        public string? ModuleId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? UserFunctionName { get; set; }
        public string? Description { get; set; }
        public string? FunctionSecurityOnly { get; set; }
        public string? ChangeSinceLastRefresh { get; set; }
    }
}
