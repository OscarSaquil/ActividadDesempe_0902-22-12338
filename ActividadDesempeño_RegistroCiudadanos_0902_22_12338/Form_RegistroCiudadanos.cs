using Logica;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ActividadDesempeño_RegistroCiudadanos_0902_22_12338
{

    public partial class Form_RegistroCiudadanos : Form
    {
        //Conexion a la BD
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.CadenaConexion_CiudadanosRegistrados);


        public Form_RegistroCiudadanos()
        {
            InitializeComponent();
            
        }

        private void IconoRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        //BotonRegistrar
        private void Button1_Click(object sender, EventArgs e)
        {

                string query = "INSERT INTO RegistroCiudadanos (CUI, Nombre, Apellido) VALUES (@CUI, @Nombre, @Apellido)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CUI",txtCUI);
                command.Parameters.AddWithValue("@PrimerNombre", txtPNombre.Text);
                command.Parameters.AddWithValue("@SegundoNombre", txtSnombre.Text);
                command.Parameters.AddWithValue("@TercerNombre", txtTnombre.Text);
                command.Parameters.AddWithValue("@PrimerApellido", txtPapellido);
                command.Parameters.AddWithValue("@SegundoApellido", txtSapellido);
                command.Parameters.AddWithValue("@ApellidoCasada", txtApellidoCasada.Text);
                command.Parameters.AddWithValue("@FechaNacimiento", Fecha.Value);
                command.Parameters.AddWithValue("@Estado/Departamento", txtDepartamento);
                command.Parameters.AddWithValue("@Ciudad/Municipio", txtMunicipio);
                
        }
    }
}
