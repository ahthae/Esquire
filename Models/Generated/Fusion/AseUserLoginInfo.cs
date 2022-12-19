using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AseUserLoginInfo
    {
        public string? UserGuid { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
    }
}
