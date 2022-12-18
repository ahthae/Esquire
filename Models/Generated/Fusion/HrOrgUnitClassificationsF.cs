﻿using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class HrOrgUnitClassificationsF
    {
        public decimal? OrgUnitClassificationId { get; set; }
        public string? ModuleId { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public decimal? ActionOccurrenceId { get; set; }
        public decimal? OrganizationId { get; set; }
        public string? ClassificationCode { get; set; }
        public string? LegislationCode { get; set; }
        public string? Status { get; set; }
        public decimal? SetId { get; set; }
        public string? CategoryCode { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? SeedDataSource { get; set; }
    }
}
