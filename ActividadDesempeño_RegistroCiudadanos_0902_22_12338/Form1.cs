using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadDesempeño_RegistroCiudadanos_0902_22_12338
{
    public partial class Form_ConsultaCiudadanos : Form
    {
        public Form_ConsultaCiudadanos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_ConsultaCiudadanos_Load(object sender, EventArgs e)
        {

        }
        Ciudadano Entidad = new Ciudadano();
        N_DatosCiudadano Negocio = new N_DatosCiudadano();

        void RegistrarEmpleado()
        {
            DataTable dt = Negocio.N_RegistroCiudadano();
            dataGridView1.DataSource = dt;
        }
    }
}
