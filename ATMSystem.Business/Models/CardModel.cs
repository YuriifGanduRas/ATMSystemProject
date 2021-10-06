using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSystem.Business.Models
{
    public class CardModel
    {
        public int Id { get; set; }
        public long Number { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public int CvcCode { get; set; }
        public string Type { get; set; }
        public string Bank { get; set; }
        public DateTime ExplorationDate { get; set; }
    }
}
