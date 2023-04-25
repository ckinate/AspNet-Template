using System.Threading.Tasks;
using Abp.Dependency;

namespace FinTrakERP.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}