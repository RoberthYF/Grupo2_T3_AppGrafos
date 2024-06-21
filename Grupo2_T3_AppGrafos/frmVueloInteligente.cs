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
    public partial class frmVueloInteligente : Form
    {
        Grafo grafo;
      
        public frmVueloInteligente(Grafo grafo)
        {
            InitializeComponent();
            this.grafo = grafo;
        }
    }
}
