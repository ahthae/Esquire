﻿using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerLegalEmployer
    {
        public decimal? LegalEntityId { get; set; }
        public decimal? OrganizationId { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
    }
}
