using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagament.Core.DTO
{
   public class CreditCardDto:BaseDto
    {
        public int Id { get; set; }
        public string CreditCardOwner { get; set; }
        public int CreditCardNo { get; set; }
        public double Balance { get; set; }
    }
}
