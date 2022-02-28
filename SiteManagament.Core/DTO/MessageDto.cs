using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagament.Core.DTO
{
   public class MessageDto:BaseDto
    {
        public int Id { get; set; }
        public string PostingMessage { get; set; }
        public string ReceivingMessage { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
    }
}
