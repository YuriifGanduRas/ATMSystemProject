using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ATMSystem.Data.Entities
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [CreditCard]
        public long Number { get; set; }
        [Required]
        public int Password { get; set; }
        [Required]
        public int OwnerId { get; set; }
        [Required]
        public int CvcCode { get; set; }
        [Required]
        public int TypeId { get; set; }
        [Required]
        public int BankId { get; set; }
        [Required]
        public DateTime ExplorationDate { get; set; }
        public User User { get; set; }
        public CardType CardType { get; set; }
        public Bank Bank { get; set; }
        public Account Account { get; set; }
    }
}
