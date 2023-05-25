using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadDesempeño_RegistroCiudadanos_0902_22_12338
{
    public partial class Form_inicio : Form
    {
        //Conexion a la BD
        SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");
        public Form_inicio()
        {
            InitializeComponent();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            Form_ConsultaCiudadanos Consulta = new Form_ConsultaCiudadanos();
            Consulta.Show();
        }
        private void BtnRegistroCiudadano_Click(object sender, EventArgs e)
        {
            Form_RegistroCiudadanos form_RegistroCiudadanos = new Form_RegistroCiudadanos();
            form_RegistroCiudadanos.Show();
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        
    }
}
