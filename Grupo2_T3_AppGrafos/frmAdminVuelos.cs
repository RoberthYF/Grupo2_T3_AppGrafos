﻿using System;
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
    public partial class frmAdminVuelos : Form
    {
        Grafo grafo;

        public frmAdminVuelos(Grafo grafo)
        {
            InitializeComponent();
            this.grafo = grafo;
        }
    }
}
