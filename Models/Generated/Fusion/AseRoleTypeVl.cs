using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AseRoleTypeVl
    {
        public decimal? RoleTypeId { get; set; }
        public string? RoleTypeCode { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? RoleTypeName { get; set; }
        public string? Language { get; set; }
        public string? SourceLang { get; set; }
    }
}
