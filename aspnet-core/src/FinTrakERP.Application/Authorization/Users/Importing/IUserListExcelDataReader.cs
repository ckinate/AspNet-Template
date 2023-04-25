using System.Collections.Generic;
using FinTrakERP.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace FinTrakERP.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
