using System.Threading.Tasks;
using FinTrakERP.Sessions.Dto;

namespace FinTrakERP.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
