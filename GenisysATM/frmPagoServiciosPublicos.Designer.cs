namespace GenisysATM
{
    partial class frmPagoServiciosPublicos
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
            this.lblServicioPublico = new MaterialSkin.Controls.MaterialLabel();
            this.cbServiciosPublicos = new System.Windows.Forms.ComboBox();
            this.lblMontoPagoServicioPublico = new MaterialSkin.Controls.MaterialLabel();
            this.txtMontoPagoServicioPublico = new System.Windows.Forms.TextBox();
            this.btnPagarServicioPublico = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lblServicioPublico
            // 
            this.lblServicioPublico.AutoSize = true;
            this.lblServicioPublico.Depth = 0;
            this.lblServicioPublico.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblServicioPublico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblServicioPublico.Location = new System.Drawing.Point(208, 150);
            this.lblServicioPublico.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServicioPublico.Name = "lblServicioPublico";
            this.lblServicioPublico.Size = new System.Drawing.Size(117, 19);
            this.lblServicioPublico.TabIndex = 0;
            this.lblServicioPublico.Text = "Servicio Publico";
            // 
            // cbServiciosPublicos
            // 
            this.cbServiciosPublicos.FormattingEnabled = true;
            this.cbServiciosPublicos.Location = new System.Drawing.Point(370, 150);
            this.cbServiciosPublicos.Name = "cbServiciosPublicos";
            this.cbServiciosPublicos.Size = new System.Drawing.Size(173, 21);
            this.cbServiciosPublicos.TabIndex = 1;
            // 
            // lblMontoPagoServicioPublico
            // 
            this.lblMontoPagoServicioPublico.AutoSize = true;
            this.lblMontoPagoServicioPublico.Depth = 0;
            this.lblMontoPagoServicioPublico.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMontoPagoServicioPublico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMontoPagoServicioPublico.Location = new System.Drawing.Point(212, 210);
            this.lblMontoPagoServicioPublico.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMontoPagoServicioPublico.Name = "lblMontoPagoServicioPublico";
            this.lblMontoPagoServicioPublico.Size = new System.Drawing.Size(53, 19);
            this.lblMontoPagoServicioPublico.TabIndex = 2;
            this.lblMontoPagoServicioPublico.Text = "Monto";
            // 
            // txtMontoPagoServicioPublico
            // 
            this.txtMontoPagoServicioPublico.Location = new System.Drawing.Point(370, 208);
            this.txtMontoPagoServicioPublico.Name = "txtMontoPagoServicioPublico";
            this.txtMontoPagoServicioPublico.Size = new System.Drawing.Size(173, 20);
            this.txtMontoPagoServicioPublico.TabIndex = 3;
            // 
            // btnPagarServicioPublico
            // 
            this.btnPagarServicioPublico.AutoSize = true;
            this.btnPagarServicioPublico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPagarServicioPublico.Depth = 0;
            this.btnPagarServicioPublico.Location = new System.Drawing.Point(287, 307);
            this.btnPagarServicioPublico.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPagarServicioPublico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPagarServicioPublico.Name = "btnPagarServicioPublico";
            this.btnPagarServicioPublico.Primary = false;
            this.btnPagarServicioPublico.Size = new System.Drawing.Size(57, 36);
            this.btnPagarServicioPublico.TabIndex = 4;
            this.btnPagarServicioPublico.Text = "Pagar";
            this.btnPagarServicioPublico.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(396, 307);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(49, 36);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPagoServiciosPublicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPagarServicioPublico);
            this.Controls.Add(this.txtMontoPagoServicioPublico);
            this.Controls.Add(this.lblMontoPagoServicioPublico);
            this.Controls.Add(this.cbServiciosPublicos);
            this.Controls.Add(this.lblServicioPublico);
            this.Name = "frmPagoServiciosPublicos";
            this.Text = "Pago de Servicios Publicos";
            this.Load += new System.EventHandler(this.frmPagoServiciosPublicos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblServicioPublico;
        private System.Windows.Forms.ComboBox cbServiciosPublicos;
        private MaterialSkin.Controls.MaterialLabel lblMontoPagoServicioPublico;
        private System.Windows.Forms.TextBox txtMontoPagoServicioPublico;
        private MaterialSkin.Controls.MaterialFlatButton btnPagarServicioPublico;
        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
    }
}