using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerLdapUser
    {
        public string? AtompubId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? Commonname { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? CredentialsEmailAddress { get; set; }
        public string? Email { get; set; }
        public string? ExternalId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? LastUpdatedBy { get; set; }
        public decimal? LdapRequestId { get; set; }
        public decimal? LdapUserId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? PreferredLanguage { get; set; }
        public decimal? RequestId { get; set; }
        public string? RequestStatus { get; set; }
        public string? RequestType { get; set; }
        public string? RequestorUserGuid { get; set; }
        public string? SendCredentialsEmail { get; set; }
        public string? UserCategory { get; set; }
        public string? UserGuid { get; set; }
        public string? Username { get; set; }
    }
}
