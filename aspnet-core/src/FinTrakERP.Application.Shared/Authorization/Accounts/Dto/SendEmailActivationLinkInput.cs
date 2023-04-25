using System.ComponentModel.DataAnnotations;

namespace FinTrakERP.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}