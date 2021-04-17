
namespace BancoST
{
    partial class SimuladorDeCredito
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.numericCantidadCuotas = new System.Windows.Forms.NumericUpDown();
            this.btnIniciarSimulacion = new System.Windows.Forms.Button();
            this.txtPagoTotal = new System.Windows.Forms.TextBox();
            this.txtValorCuota = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "C.Cuotas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto total a pagar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "V.Cuota";
            // 
            // txtNombre
            // 
            this.errorProvider.SetIconPadding(this.txtNombre, -20);
            this.txtNombre.Location = new System.Drawing.Point(154, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(355, 38);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.errorProvider.SetIconPadding(this.txtApellido, -20);
            this.txtApellido.Location = new System.Drawing.Point(155, 95);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(355, 38);
            this.txtApellido.TabIndex = 7;
            // 
            // txtMonto
            // 
            this.errorProvider.SetIconPadding(this.txtMonto, -20);
            this.txtMonto.Location = new System.Drawing.Point(155, 153);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(355, 38);
            this.txtMonto.TabIndex = 8;
            // 
            // numericCantidadCuotas
            // 
            this.errorProvider.SetIconPadding(this.numericCantidadCuotas, -20);
            this.numericCantidadCuotas.Location = new System.Drawing.Point(153, 236);
            this.numericCantidadCuotas.Name = "numericCantidadCuotas";
            this.numericCantidadCuotas.Size = new System.Drawing.Size(181, 38);
            this.numericCantidadCuotas.TabIndex = 9;
            // 
            // btnIniciarSimulacion
            // 
            this.btnIniciarSimulacion.Location = new System.Drawing.Point(21, 318);
            this.btnIniciarSimulacion.Name = "btnIniciarSimulacion";
            this.btnIniciarSimulacion.Size = new System.Drawing.Size(488, 46);
            this.btnIniciarSimulacion.TabIndex = 10;
            this.btnIniciarSimulacion.Text = "Iniciar Simulacion";
            this.btnIniciarSimulacion.UseVisualStyleBackColor = true;
            this.btnIniciarSimulacion.Click += new System.EventHandler(this.btnIniciarSimulacion_Click);
            // 
            // txtPagoTotal
            // 
            this.errorProvider.SetIconPadding(this.txtPagoTotal, -20);
            this.txtPagoTotal.Location = new System.Drawing.Point(280, 385);
            this.txtPagoTotal.Name = "txtPagoTotal";
            this.txtPagoTotal.ReadOnly = true;
            this.txtPagoTotal.Size = new System.Drawing.Size(229, 38);
            this.txtPagoTotal.TabIndex = 11;
            // 
            // txtValorCuota
            // 
            this.errorProvider.SetIconPadding(this.txtValorCuota, -20);
            this.txtValorCuota.Location = new System.Drawing.Point(140, 441);
            this.txtValorCuota.Name = "txtValorCuota";
            this.txtValorCuota.ReadOnly = true;
            this.txtValorCuota.Size = new System.Drawing.Size(369, 38);
            this.txtValorCuota.TabIndex = 12;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(17, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(449, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Se admiten cuotas desde 1 hasta 36 cuotas como maximo.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(19, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "El monto minimo es de $ 500.000 pesos.";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(20, 503);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(489, 44);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // SimuladorDeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(539, 559);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorCuota);
            this.Controls.Add(this.txtPagoTotal);
            this.Controls.Add(this.btnIniciarSimulacion);
            this.Controls.Add(this.numericCantidadCuotas);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimuladorDeCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de creditos";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.NumericUpDown numericCantidadCuotas;
        private System.Windows.Forms.Button btnIniciarSimulacion;
        private System.Windows.Forms.TextBox txtPagoTotal;
        private System.Windows.Forms.TextBox txtValorCuota;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

