using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AsmScope
    {
        public decimal? ScopeId { get; set; }
        public decimal? BusinessObjectId { get; set; }
        public decimal? TaskListId { get; set; }
        public decimal? ApplicationId { get; set; }
        public string? MigrationOnly { get; set; }
        public decimal? EnterpriseId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? SeedDataSource { get; set; }
    }
}
