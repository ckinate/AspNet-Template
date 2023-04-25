using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using FinTrakERP.Dto;

namespace FinTrakERP.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
