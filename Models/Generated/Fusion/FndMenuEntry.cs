using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class FndMenuEntry
    {
        public decimal? EnterpriseId { get; set; }
        public decimal? SandboxId { get; set; }
        public decimal? MenuId { get; set; }
        public decimal? SubMenuId { get; set; }
        public decimal? FunctionId { get; set; }
        public string? ChangeSinceLastRefresh { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? SeedDataSource { get; set; }
    }
}
