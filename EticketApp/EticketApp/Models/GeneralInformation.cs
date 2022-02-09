using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticketApp.Models
{
    public class GeneralInformation
    {
        public string Cedula { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string AddressResidence { get; set; }
        public string City { get; set; }
        public string ContryResidence { get; set; }
        public string State { get; set; }
        public bool InOutCountry { get; set; }
        public string PostalCode { get; set; }
    }
}
