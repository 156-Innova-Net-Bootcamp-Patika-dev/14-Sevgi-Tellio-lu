using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagament.Core.DTO
{
    public class TenantDto:BaseDto
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Lastname { get; set; }
        public int IdentificationNumber { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public bool IsHaveCar { get; set; }
        public String CarPlateNumber { get; set; }
    }
}
