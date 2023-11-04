using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayeshyar.Backend.Core.Entities
{
    public   class BarberShopOwner
    {
        public string MobileNumber { get; set; }

        public BarberShopOwner(string mobileNumber)
        {
            MobileNumber = mobileNumber;
        }

        public  string? Fullname   { get; set; }
        public string? Address { get; set; }

    }
}
