using Xamarin.Forms.Internals;

namespace FinTrakERP.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}