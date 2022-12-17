using System;
using System.Collections.Generic;

namespace esquire.Models
{
    public record BusinessUnit(double? BU_ID,
        string? BU_NAME,
        double? LOCATION_ID,
        double? BUSINESS_GROUP_ID,
        DateTime? DATE_FROM,
        DateTime? DATE_TO,
        double? MANAGER_ID,
        double? LEGAL_ENTITY_ID,
        double? PRIMARY_LEDGER_ID,
        double? DEFAULT_SET_ID,
        string? SHORT_CODE,
        string? ENABLED_FOR_HR_FLAG,
        double? FIN_BUSINESS_UNIT_ID,
        string? DEFAULT_CURRENCY_CODE,
        string? PROFIT_CENTER_FLAG,
        string? STATUS,
        DateTime? CREATION_DATE,
        string? LAST_UPDATED_BY,
        string? LAST_UPDATE_DATE,
        string? LAST_UPDATE_LOGIN);
}
    