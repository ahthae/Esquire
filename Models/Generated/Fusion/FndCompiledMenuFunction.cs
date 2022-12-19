using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class FndCompiledMenuFunction
    {
        public decimal? EnterpriseId { get; set; }
        public decimal? SandboxId { get; set; }
        public decimal? MenuId { get; set; }
        public decimal? FunctionId { get; set; }
        public string? Flag { get; set; }
        public string? ChangeSinceLastRefresh { get; set; }
    }
}
