using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace GenisysATM
{
    public partial class frmBalanceCuenta : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;

        public frmBalanceCuenta()
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

        private void frmBalanceCuenta_Load(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(@"server = (local)\chrisfiallos;" +
            //        "integrated security = true; database = GenisysATM_V2"))
            //{
            //    SqlCommand cmd = "Select Nombre"
            //}
        }
    }
}
