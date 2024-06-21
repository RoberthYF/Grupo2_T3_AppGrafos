using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo2_T3_AppGrafos
{
    public partial class FrmPrincipal : Form
    {
        public Grafo grafo = new Grafo();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Abrir formulario para Administración de vuelos
            frmAdminVuelos ventana = new frmAdminVuelos(grafo);
            ventana.Show();
        }

        private void btnInteligente_Click(object sender, EventArgs e)
        {
            // Abrir formulario para Vuelo Inteligente
            frmVueloInteligente ventana = new frmVueloInteligente(grafo);
            ventana.Show();
        }

        private void btnRedes_Click(object sender, EventArgs e)
        {
            frmRedes ventana = new frmRedes(grafo);
            ventana.Show();
            // Abrir formulario para Redes de vuelos
        }
    }
}
