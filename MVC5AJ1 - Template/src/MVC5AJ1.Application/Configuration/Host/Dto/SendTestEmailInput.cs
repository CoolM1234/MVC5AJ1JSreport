using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using MVC5AJ1.Authorization.Users;

namespace MVC5AJ1.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}