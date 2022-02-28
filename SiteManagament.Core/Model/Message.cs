using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagament.Core.Entity
{
   public class Message:BaseEntity
    {
        public int Id { get; set; }
        public string PostingMessage { get; set; }
        public string ReceivingMessage { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public Tenant tenant { get; set; }


    }
}
