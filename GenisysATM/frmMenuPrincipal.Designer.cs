namespace GenisysATM
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCliente = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnServiciosPublicos = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.AutoSize = true;
            this.btnCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCliente.Depth = 0;
            this.btnCliente.Location = new System.Drawing.Point(307, 132);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Primary = false;
            this.btnCliente.Size = new System.Drawing.Size(66, 36);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnServiciosPublicos
            // 
            this.btnServiciosPublicos.AutoSize = true;
            this.btnServiciosPublicos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServiciosPublicos.Depth = 0;
            this.btnServiciosPublicos.Location = new System.Drawing.Point(266, 206);
            this.btnServiciosPublicos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnServiciosPublicos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnServiciosPublicos.Name = "btnServiciosPublicos";
            this.btnServiciosPublicos.Primary = false;
            this.btnServiciosPublicos.Size = new System.Drawing.Size(148, 36);
            this.btnServiciosPublicos.TabIndex = 1;
            this.btnServiciosPublicos.Text = "Servicios Publicos";
            this.btnServiciosPublicos.UseVisualStyleBackColor = true;
            this.btnServiciosPublicos.Click += new System.EventHandler(this.btnServiciosPublicos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(316, 280);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(49, 36);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnServiciosPublicos);
            this.Controls.Add(this.btnCliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menú Principal Genisys ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnCliente;
        private MaterialSkin.Controls.MaterialFlatButton btnServiciosPublicos;
        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
    }
}