using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticketApp.Models
{
    public class GeneralInformation
    {
        //public string Cedula { get; set; }
        //public string Name { get; set; }
        //public string LastName { get; set; }
        //public DateTime BirthDay { get; set; }
        public string DireccionRecidencia { get; set; }
        public string Ciudad { get; set; }
        public string PaisRecidencia { get; set; }
        public string Estado { get; set; }
        public bool EntradaAlPais { get; set; }
        public bool EscalaOtrosPaises { get; set; }
        public string CodigoPostal { get; set; }
    }
}
