using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ATMSystem.Data.Entities
{
    public class Account
    {
        [Key]
        [ForeignKey("Card")]
        public int Id { get; set; }
        [Required]
        [CreditCard]
        public Int64 Number { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        public int StatusId { get; set; }
        public Card Card { get; set; }
        public AccountStatus AccountStatus { get; set; }
    }
}
