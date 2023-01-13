using esquire.Data;

namespace esquire.Entities;

internal class BusinessUnit : EntityBase
{
    public BusinessUnit(BusinessUnitDto dto)
    {
        Dto = dto;
    }

    public IDto Dto { get; set; }
}