using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerPersonNamesF
    {
        public decimal? PersonNameId { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public decimal? PersonId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? LegislationCode { get; set; }
        public string? NameType { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleNames { get; set; }
        public string? Title { get; set; }
        public string? PreNameAdjunct { get; set; }
        public string? Suffix { get; set; }
        public string? KnownAs { get; set; }
        public string? PreviousLastName { get; set; }
        public string? Honors { get; set; }
        public string? MilitaryRank { get; set; }
        public string? DisplayName { get; set; }
        public string? FullName { get; set; }
        public string? ListName { get; set; }
        public string? OrderName { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string? CharSetContext { get; set; }
    }
}
