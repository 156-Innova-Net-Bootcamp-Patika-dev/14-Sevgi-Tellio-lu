using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagament.Core.Entity
{
   public class Payment:BaseEntity
    {
        public int Id { get; set; }
        public string Invoice { get; set; }
        public string Dues { get; set; }
        public int Price { get; set; }
        public string PaymentMethod { get; set; }
        public CreditCard creditCard { get; set; }
        public Apartment aparment { get; set; }
        public int ApartmentId { get; set; }

    } 
}
