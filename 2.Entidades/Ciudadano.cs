using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadDesempeño_RegistroCiudadanos_0902_22_12338
{
    //Registro de ciudadano

    public class Ciudadano
    {
        public string CUI { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string TercerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string ApellidoCasada { get; set; }
        public string Fecha { get; set; }
        public string Estado_Dep { get; set;}
        public string Ciudad_Municipio { get; set;}
        public string CorreoElectronico { get; set; }
        public string ConfirmacionCorreo { get; set;}
    }
}
