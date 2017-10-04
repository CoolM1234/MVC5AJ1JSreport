using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace MVC5AJ1.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}