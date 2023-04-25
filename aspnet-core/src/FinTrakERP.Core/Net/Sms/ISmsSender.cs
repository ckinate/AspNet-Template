using System.Threading.Tasks;

namespace FinTrakERP.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}