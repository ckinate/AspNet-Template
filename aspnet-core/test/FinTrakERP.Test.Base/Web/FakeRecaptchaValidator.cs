using System.Threading.Tasks;
using FinTrakERP.Security.Recaptcha;

namespace FinTrakERP.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
