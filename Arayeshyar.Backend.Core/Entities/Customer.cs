using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayeshyar.Backend.Core.Entities
{
    public class Customer
    {
        public string MobileNumber { get; set; }

        public Customer(string mobileNumber)
        {
            MobileNumber = mobileNumber;
        }

        public String? Fullname { get; set; }
        public string? Password { get; set; }
        public string?   Email   { get; set; }
        public string? Address { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
