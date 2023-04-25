using Abp.Auditing;
using FinTrakERP.Configuration.Dto;

namespace FinTrakERP.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}