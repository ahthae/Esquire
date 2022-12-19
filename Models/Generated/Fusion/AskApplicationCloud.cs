using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AskApplicationCloud
    {
        public decimal? Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public decimal? EnvironmentTypeId { get; set; }
        public string? Type { get; set; }
        public string? ContactPerson { get; set; }
        public string? Customer { get; set; }
        public string? Tenant { get; set; }
        public string? Status { get; set; }
        public decimal? OvmTemplateId { get; set; }
        public decimal? DataCenterId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public decimal? EnterpriseId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? DeployedAt { get; set; }
    }
}
