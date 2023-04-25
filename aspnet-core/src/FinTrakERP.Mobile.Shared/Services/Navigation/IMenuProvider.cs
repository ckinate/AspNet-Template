using System.Collections.Generic;
using MvvmHelpers;
using FinTrakERP.Models.NavigationMenu;

namespace FinTrakERP.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}