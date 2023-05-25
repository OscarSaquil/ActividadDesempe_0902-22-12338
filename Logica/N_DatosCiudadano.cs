using _1.Datos.DB;
using ActividadDesempeño_RegistroCiudadanos_0902_22_12338;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class N_DatosCiudadano
    {
        // instancia de la clase DatosCiudadano, para crear el objeto dentro de esta clase
         DatosCiudadano objDato = new DatosCiudadano();
         

        public DataTable N_RegistroCiudadano()
        {
            // Retorna la clase D_registroCiudadano atraves del objeto instanciado objDato
            return objDato.D_RegitroCiudadano();
        }
        
    }
}
