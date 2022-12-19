using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class FndObjectsVl
    {
        public string? RowId { get; set; }
        public decimal? ObjectId { get; set; }
        public string? ObjName { get; set; }
        public string? ModuleId { get; set; }
        public string? DatabaseObjectName { get; set; }
        public string? Pk1ColumnName { get; set; }
        public string? Pk2ColumnName { get; set; }
        public string? Pk3ColumnName { get; set; }
        public string? Pk4ColumnName { get; set; }
        public string? Pk5ColumnName { get; set; }
        public string? Pk1ColumnType { get; set; }
        public string? Pk2ColumnType { get; set; }
        public string? Pk3ColumnType { get; set; }
        public string? Pk4ColumnType { get; set; }
        public string? Pk5ColumnType { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public string? ObjectType { get; set; }
        public string? ObjectTag { get; set; }
        public string? ObjectStripeCondition { get; set; }
        public string? FilterColumnList { get; set; }
        public string? FunctionSecurityEnabled { get; set; }
        public string? ChangeSinceLastRefresh { get; set; }
    }
}
