using System;
using System.ComponentModel.DataAnnotations;
namespace BankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransId { get; set; }

        [Required (ErrorMessage = "Transaction amount cannot be blank")]
        public decimal? Amount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }

        public UserReg Creator { get; set; }
    }
}