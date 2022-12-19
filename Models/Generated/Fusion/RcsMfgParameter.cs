using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class RcsMfgParameter
    {
        public decimal? OrganizationId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? LastUpdateLogin { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public decimal? MfgCalendar { get; set; }
        public string? DefSupplySubinv { get; set; }
        public string? DefSupplyLocator { get; set; }
        public string? DefCompltnSubinv { get; set; }
        public string? DefCompltnLocator { get; set; }
        public decimal? StartingOprnSeq { get; set; }
        public decimal? OprnSeqIncrement { get; set; }
        public string? WorkOrderPrefix { get; set; }
        public decimal? PhntmOprnInherit { get; set; }
        public decimal? DefTransMode { get; set; }
        public decimal? DefTransQty { get; set; }
        public string? IncCompYieldFlag { get; set; }
        public string? DefOvercompltnTol { get; set; }
        public decimal? QtyChngBackflush { get; set; }
        public string? DefWoTravelerTmplt { get; set; }
        public string? DefLabelTmplt { get; set; }
        public string? AutoAsscSerNumWo { get; set; }
        public decimal? WoDocSeqId { get; set; }
        public string? WoDocSeqCatCode { get; set; }
        public decimal? WoStartingNumber { get; set; }
        public string? PurchaseReqCreateTime { get; set; }
        public string? DefMntSchedMethod { get; set; }
        public string? StartstopCaptureLvl { get; set; }
        public string? BackflushLotSelection { get; set; }
        public string? MtlReportingLvl { get; set; }
        public string? ForecastHorizon { get; set; }
        public string? GenWoHorizon { get; set; }
        public string? PickSlipGroupingRule { get; set; }
        public string? PrintPickSlipsFlag { get; set; }
        public string? IncludePullCompFlag { get; set; }
        public string? IssuePushCompFlag { get; set; }
        public string? PrintLabelExternally { get; set; }
        public string? AllowDirectPurchWo { get; set; }
        public string? EnableProcessFlag { get; set; }
        public string? DefWorkMethod { get; set; }
        public string? EnableIotFlag { get; set; }
        public string? ManualIssueAssyWoFlag { get; set; }
        public string? AllowNegIssWoSnFlag { get; set; }
    }
}
