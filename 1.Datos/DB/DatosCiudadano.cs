using ActividadDesempeño_RegistroCiudadanos_0902_22_12338;
using Microsoft.Win32.SafeHandles;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _1.Datos.DB
{
    public class DatosCiudadano
    {
       SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaConexion_CiudadanosRegistrados"].ConnectionString);
       Ciudadano objCiudadano = new Ciudadano();
        public DataTable D_RegitroCiudadano()
        {
            SqlCommand _command = new SqlCommand("RegistroCiudadanos", conn);
            _command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter _adapter = new SqlDataAdapter(_command);
            DataTable dt = new DataTable();
            _adapter.Fill(dt);
            return dt;
        }
    }
}
