using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XamarinForms.DataForm;

namespace EticketApp.Models
{
    public class MigratorialInformation
    {
        
        
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public Gender Genero { get; set; }
        public string LugarNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string NumeroPasaporte { get; set; }        
        public CivilStatus EstadoCivil { get; set; }
        public string Ocupacion { get; set; }
        public string Cedula { get; set; }
        public bool ExtrangeroEnRD{ get; set; } = false;
        public bool AirBnbEstancia { get; set; } = false;
        public bool HotelVEstancia { get; set; } = false;
        public string Provincia { get; set; }
        public string Municipio { get; set; }
        public string Sector { get; set; }
        public string Direccion { get; set; }
        public string PuertoEmbarque { get; set; }
        public string NumeroVuelo { get; set; }
        public DateTime FechaVuelo { get; set; }
        public string PuertoDesembarque { get; set; }
        public string NombreAeroLinea { get; set; }
        public string NumeroConfirmacion { get; set; }
        public string Motivo { get; set; }
        public int TiempoEnDias { get; set; }
        public string Correo { get; set; }

    }

    public enum Gender
    {
        Masculino,
        Femenino,
        Otros
    }

    public enum CivilStatus
    {   [Description("Solter(a)")]   
        Soltero,
        [Description("Casada(a)")]
        Casado,
        Concubinato,
        [Description("Unión Libre")]
        UnionLibre,
        Otros
    }
}
