using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSystem.Business.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public long Number { get; set; }
        public decimal Balance { get; set; }
        public int Status { get; set; }
    }
}
