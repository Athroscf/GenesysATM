﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

namespace GenisysATM
{
    public partial class frmMenuPrincipal : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public frmMenuPrincipal()
        {
            InitializeComponent();

            // Implementar temas y colores
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700, Primary.Blue200,
                Accent.Orange400, TextShade.WHITE
            );
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmMenuCliente mc = new frmMenuCliente();
            mc.Show();
        }

        private void btnServiciosPublicos_Click(object sender, EventArgs e)
        {
            frmPagoServiciosPublicos psp = new frmPagoServiciosPublicos();
            psp.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmInicio i = new frmInicio();
            MessageBox.Show("Gracias por utilizar el sistema! Lo esperamos.");
            this.Close();
            i.Show();
        }
    }
}
