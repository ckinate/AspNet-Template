using Abp.AutoMapper;
using FinTrakERP.Organizations.Dto;

namespace FinTrakERP.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}