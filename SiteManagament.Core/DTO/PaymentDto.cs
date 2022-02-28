using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagament.Core.DTO
{
   public class PaymentDto:BaseDto
    {
        public int Id { get; set; }
        public string Invoice { get; set; }
        public string Dues { get; set; }
        public int Price { get; set; }
        public string PaymentMethod { get; set; }
    }
}
