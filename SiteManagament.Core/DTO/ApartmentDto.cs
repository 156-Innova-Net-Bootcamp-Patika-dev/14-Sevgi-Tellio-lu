using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagament.Core.DTO
{
   public class ApartmentDto:BaseDto
    {
        public int Id { get; set; }
        public string ApartmentBlock { get; set; }
        public bool ApartmentStatus { get; set; }
        public string ApartmentType { get; set; }
        public string FloorLocation { get; set; }
        public string ApartmentNumber { get; set; }
        public string ApartmentOwner { get; set; }
    }
}
