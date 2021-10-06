using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSystem.Business.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long MobilePhone { get; set; }
    }
}
