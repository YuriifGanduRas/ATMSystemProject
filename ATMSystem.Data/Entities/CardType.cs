using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ATMSystem.Data.Entities
{
    public class CardType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Desription { get; set; }
        public List<Card> Cards { get; set; }
    }
}
