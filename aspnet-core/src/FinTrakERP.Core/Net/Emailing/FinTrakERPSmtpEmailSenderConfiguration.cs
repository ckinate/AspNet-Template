using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace FinTrakERP.Net.Emailing
{
    public class FinTrakERPSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public FinTrakERPSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}