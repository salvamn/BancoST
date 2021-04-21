using ClasesUtiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BancoST
{
    public partial class SimuladorDeCredito : Form
    {
        public SimuladorDeCredito()
        {
            InitializeComponent();
            txtPagoTotal.Enabled = false;
            txtValorCuota.Enabled = false;
        }
        // CODIGO PARA MOVER EL FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // CODIGO PARA MOVER EL FORM

        private void btnIniciarSimulacion_Click(object sender, EventArgs e)
        {
            // SOLUCION DEFINITIVA
            errorProviderNombre.SetIconPadding(txtNombre, -20);
            errorProviderApellido.SetIconPadding(txtApellido, -20);
            errorProviderMonto.SetIconPadding(txtMonto, -20);
            errorProviderCuota.SetIconPadding(numericCantidadCuotas, -40);

            bool validarNombre = txtNombre.Text.Trim().Equals("");
            bool validarApellido = txtApellido.Text.Trim().Equals("");
            bool validaMonto = txtMonto.Text.Trim().Equals("");
            bool validaCuotas = Utilerias.ValidandoCantidadCuotas((int)numericCantidadCuotas.Value);

            int montoConvertido = 0;
            bool montoValidado = false;


            if (validarNombre)
                errorProviderNombre.SetError(txtNombre, "Este campo no puede estar vacio.");
            else
                errorProviderNombre.Clear();


            if (validarApellido)
                errorProviderApellido.SetError(txtApellido, "Este campo no puede estar vacio.");
            else
                errorProviderApellido.Clear();


            if (validaMonto)
                errorProviderMonto.SetError(txtMonto, "Este campo no puede estar vacio");
            else
            {
                if (Utilerias.ValidandoMonto(txtMonto.Text.Trim()) == false)
                    errorProviderMonto.SetError(txtNombre, "Este campo no puede contener letras.");
                else
                {
                    montoConvertido = int.Parse(txtMonto.Text.Trim());
                    if (montoConvertido < 500_000)
                        errorProviderMonto.SetError(txtMonto, "El monto minimo es de $ 500.000 pesos.");
                    else
                    {
                        montoValidado = true;
                        errorProviderMonto.Clear();
                    }
                }
            }


            if (validaCuotas == false)
                errorProviderCuota.SetError(numericCantidadCuotas, "La cuotas ingresadas estan fuera de rango");
            else
                errorProviderCuota.Clear();



            if (!validarNombre && !validarApellido && montoValidado && validaCuotas)
            {
                errorProviderNombre.Clear();
                errorProviderApellido.Clear();
                errorProviderMonto.Clear();

                int cuotas = Convert.ToInt32(numericCantidadCuotas.Value);
                double sacarInteresCuota = Utilerias.CalcularPorcentajeInteres(cuotas);
                int cuotaLimpia = Utilerias.CalcularCuotaLimpia(montoConvertido, cuotas);
                double cuotaInteres = Utilerias.CalcularCuotaConIntereses(cuotaLimpia, sacarInteresCuota);

                int montoFinal = Utilerias.CalcularMontoFinal((int)cuotaInteres, cuotas);
                int valorXCuota = (int)cuotaInteres;

                txtPagoTotal.Enabled = true;
                txtPagoTotal.ReadOnly = false;
                txtPagoTotal.Text = montoFinal.ToString();
                txtPagoTotal.ReadOnly = true;

                txtValorCuota.Enabled = true;
                txtValorCuota.ReadOnly = false;
                txtValorCuota.Text = Convert.ToInt32(valorXCuota).ToString();
                txtValorCuota.ReadOnly = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtMonto.Text = "";
                txtPagoTotal.Text = "";
                txtValorCuota.Text = "";
                numericCantidadCuotas.Value = 0;
                errorProviderNombre.Clear();
            }
            catch (Exception) { }
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Dispose();
            Close();
        }


        private void SimuladorDeCredito_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}