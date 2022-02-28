using SiteManagament.Core.Entity;
using SiteManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagament.Core
{
    public class Tenant : BaseEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Lastname { get; set; }
        public String IdentificationNumber { get; set; }
        public String Email { get; set; }
        public string Password { get; set; }
        public String Phone { get; set; }
        public bool IsHaveCar { get; set; }
        public String CarPlateNumber { get; set; }
        public Apartment apartment { get; set; }
        public int ApartmentId { get; set; }
        public Payment payment { get; set; }
        public int PaymentId { get; set; }
        public Message message { get; set; }
        public int MessageId { get; set; }
        public CreditCard creditCard { get; set; }
        public int CreditCardId { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }

    }
}
