using System.Collections.Generic;
using Abp;
using FinTrakERP.Chat.Dto;
using FinTrakERP.Dto;

namespace FinTrakERP.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
