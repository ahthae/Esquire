using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerUser
    {
        public string? ActiveFlag { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? UserId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? CreatedBy { get; set; }
        public string? CredentialsEmailSent { get; set; }
        public DateTime? EndDate { get; set; }
        public string? ExternalId { get; set; }
        public string? HrTerminated { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string? MultitenancyUsername { get; set; }
        public string? ObjectVersionNumber { get; set; }
        public decimal? PartyId { get; set; }
        public decimal? PersonId { get; set; }
        public DateTime? StartDate { get; set; }
        public string? Suspended { get; set; }
        public string? UserDataChecksum { get; set; }
        public string? UserDistinguishedName { get; set; }
        public string? UserGuid { get; set; }
        public string? Username { get; set; }
    }
}
