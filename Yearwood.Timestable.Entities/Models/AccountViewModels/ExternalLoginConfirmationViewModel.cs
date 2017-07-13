using System.ComponentModel.DataAnnotations;

namespace Yearwood.Timestable.Entities.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
