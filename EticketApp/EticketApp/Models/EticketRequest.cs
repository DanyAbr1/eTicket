using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticketApp.Models
{
    public class EticketRequest
    {
        public GeneralInformation generalInformation { get; set; }
        public MigratorialInformation migratorialInformation { get; set;}
        public CustomsInformation customsInformation { get; set; }
        public PublicHealthInformation publicHealthInformation { get; set; }
    }
}
