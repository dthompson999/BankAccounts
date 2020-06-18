using System.ComponentModel.DataAnnotations;
namespace BankAccounts.Models
{
    public class UserLog
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}