namespace GenisysATM
{
    partial class frmBalanceCuenta
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
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblNumeroCuentaCliente = new System.Windows.Forms.Label();
            this.lblMonto = new MaterialSkin.Controls.MaterialLabel();
            this.lblLimiteTarjeta = new MaterialSkin.Controls.MaterialLabel();
            this.txtMontoCuenta = new System.Windows.Forms.TextBox();
            this.txtLimiteTarjeta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(90, 115);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(0, 13);
            this.lblNombreCliente.TabIndex = 0;
            // 
            // lblNumeroCuentaCliente
            // 
            this.lblNumeroCuentaCliente.AutoSize = true;
            this.lblNumeroCuentaCliente.Location = new System.Drawing.Point(90, 187);
            this.lblNumeroCuentaCliente.Name = "lblNumeroCuentaCliente";
            this.lblNumeroCuentaCliente.Size = new System.Drawing.Size(0, 13);
            this.lblNumeroCuentaCliente.TabIndex = 1;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Depth = 0;
            this.lblMonto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMonto.Location = new System.Drawing.Point(399, 115);
            this.lblMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(53, 19);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto";
            // 
            // lblLimiteTarjeta
            // 
            this.lblLimiteTarjeta.AutoSize = true;
            this.lblLimiteTarjeta.Depth = 0;
            this.lblLimiteTarjeta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLimiteTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLimiteTarjeta.Location = new System.Drawing.Point(399, 183);
            this.lblLimiteTarjeta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLimiteTarjeta.Name = "lblLimiteTarjeta";
            this.lblLimiteTarjeta.Size = new System.Drawing.Size(51, 19);
            this.lblLimiteTarjeta.TabIndex = 3;
            this.lblLimiteTarjeta.Text = "Limite";
            // 
            // txtMontoCuenta
            // 
            this.txtMontoCuenta.Location = new System.Drawing.Point(522, 113);
            this.txtMontoCuenta.Name = "txtMontoCuenta";
            this.txtMontoCuenta.Size = new System.Drawing.Size(180, 20);
            this.txtMontoCuenta.TabIndex = 4;
            // 
            // txtLimiteTarjeta
            // 
            this.txtLimiteTarjeta.Location = new System.Drawing.Point(522, 184);
            this.txtLimiteTarjeta.Name = "txtLimiteTarjeta";
            this.txtLimiteTarjeta.Size = new System.Drawing.Size(180, 20);
            this.txtLimiteTarjeta.TabIndex = 5;
            // 
            // frmBalanceCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLimiteTarjeta);
            this.Controls.Add(this.txtMontoCuenta);
            this.Controls.Add(this.lblLimiteTarjeta);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblNumeroCuentaCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Name = "frmBalanceCuenta";
            this.Text = "Balance de Cuenta";
            this.Load += new System.EventHandler(this.frmBalanceCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblNumeroCuentaCliente;
        private MaterialSkin.Controls.MaterialLabel lblMonto;
        private MaterialSkin.Controls.MaterialLabel lblLimiteTarjeta;
        private System.Windows.Forms.TextBox txtMontoCuenta;
        private System.Windows.Forms.TextBox txtLimiteTarjeta;
    }
}