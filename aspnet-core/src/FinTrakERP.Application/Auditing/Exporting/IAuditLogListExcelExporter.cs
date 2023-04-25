using System.Collections.Generic;
using FinTrakERP.Auditing.Dto;
using FinTrakERP.Dto;

namespace FinTrakERP.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
