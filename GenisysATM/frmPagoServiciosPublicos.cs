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
    public partial class frmPagoServiciosPublicos : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;

        public frmPagoServiciosPublicos()
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPagoServiciosPublicos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(@"server = (local)\chrisfiallos;" +
                    "integrated security = true; database = GenisysATM_V2"))
            {
                string query = "select descripcion from ATM.ServicioPublico";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            cbServiciosPublicos.DisplayMember = "Descripcion";
        }
    }
}
