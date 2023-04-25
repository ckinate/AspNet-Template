using System.Collections.Generic;
using FinTrakERP.Authorization.Users.Importing.Dto;
using FinTrakERP.Dto;

namespace FinTrakERP.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
