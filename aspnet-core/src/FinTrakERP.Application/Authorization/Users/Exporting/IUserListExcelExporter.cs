using System.Collections.Generic;
using FinTrakERP.Authorization.Users.Dto;
using FinTrakERP.Dto;

namespace FinTrakERP.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}