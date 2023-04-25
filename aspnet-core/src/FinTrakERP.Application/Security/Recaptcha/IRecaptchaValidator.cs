using System.Threading.Tasks;

namespace FinTrakERP.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}