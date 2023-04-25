using Microsoft.Extensions.Configuration;

namespace FinTrakERP.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
