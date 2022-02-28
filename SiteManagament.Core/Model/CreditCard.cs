using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagament.Core.Entity
{
   public class CreditCard:BaseEntity
    {
        public int Id { get; set; }
        public string CreditCardOwner { get; set; }
        public int CreditCardNo { get; set; }
        public double Balance { get; set; }
    }
}
