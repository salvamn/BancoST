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
            bool nombre = Utilerias.ValidandoCadena(txtNombre.Text.Trim());
            bool apellido = Utilerias.ValidandoCadena(txtApellido.Text.Trim());
            string monto = txtMonto.Text.Trim();
            int montoValidado = 0;
            bool cantidadCuotas = Utilerias.ValidandoCantidadCuotas(Convert.ToInt32(numericCantidadCuotas.Value));

            if (nombre == false) // VALIDANDO CAMPO NOMBRE
            {
                errorProvider.SetIconPadding(txtNombre, -20);
                errorProvider.SetError(txtNombre, "El campo nombre no puede estar vacio");
            }
            else
                errorProvider.Clear();
           

            if (apellido == false) 
            {
                errorProvider.SetIconPadding(txtApellido, -20);
                errorProvider.SetError(txtApellido, "El campo apellido no puede estar vacio.");
            }
            else
                errorProvider.Clear();

            if (cantidadCuotas == false)
            {
                errorProvider.SetIconPadding(numericCantidadCuotas, -40);
                errorProvider.SetError(numericCantidadCuotas, "Las cuotas ingresadas estan fuera de los limites permitidos.");
            }
            else
                errorProvider.Clear();

            //-------------------------- VALIDANDO MONTO
            if (txtMonto.Text.Equals(""))
            {
                errorProvider.SetIconPadding(txtMonto, -20);
                errorProvider.SetError(txtMonto, "Este campo no puede estar vacio.");
            }
            else
            {
                if(Utilerias.ValidandoMonto(monto) == false)
                {
                    errorProvider.SetIconPadding(txtMonto, -20);
                    errorProvider.SetError(txtMonto, "Esta campo no puede contener letras.");
                }
                else
                {
                    montoValidado = Convert.ToInt32(monto);
                    if(Utilerias.ValidandoMontoMinimo(montoValidado) == false)
                    {
                        errorProvider.SetIconPadding(txtMonto, -20);
                        errorProvider.SetError(txtMonto, "El monto solicitado debe ser mayor a $ 500.000");
                    }
                    else
                    {
                        if (nombre && apellido && int.Parse(txtMonto.Text) >= 500_000 && cantidadCuotas)
                        {

                            errorProvider.Clear();
                            montoValidado = int.Parse(txtMonto.Text);
                            int cuotas = Convert.ToInt32(numericCantidadCuotas.Value);
                            Double porcentajeInteres = Utilerias.CalcularPorcentajeInteres(cuotas);
                            int cuotaLimpia = Utilerias.CalcularCuotaLimpia(montoValidado, cuotas);
                            Double cuotaInteres = Utilerias.CalcularCuotaConIntereses(cuotaLimpia, porcentajeInteres);
                            int montoFinal = Utilerias.CalcularMontoFinal((int)cuotaInteres, cuotas);

                            txtPagoTotal.Enabled = true;
                            txtPagoTotal.ReadOnly = false;
                            txtPagoTotal.Text = montoFinal.ToString();
                            txtPagoTotal.ReadOnly = true;

                            txtValorCuota.Enabled = true;
                            txtValorCuota.ReadOnly = false;
                            txtValorCuota.Text = Convert.ToInt32(cuotaInteres).ToString();
                            txtValorCuota.ReadOnly = true;
                        }
                    }
                }
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
            }
            catch (Exception) { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Close();
            this.Dispose();
        }

        private void SimuladorDeCredito_Load(object sender, EventArgs e)
        {

        }

        private void SimuladorDeCredito_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}


/*
if (nombre && apellido && int.Parse(txtMonto.Text) >= 500_000 && cantidadCuotas)
{

    errorProvider.Clear();
    montoValidado = int.Parse(txtMonto.Text);
    int cuotas = Convert.ToInt32(numericCantidadCuotas.Value);
    Double porcentajeInteres = Utilerias.CalcularPorcentajeInteres(cuotas);
    int cuotaLimpia = Utilerias.CalcularCuotaLimpia(montoValidado, cuotas);
    Double cuotaInteres = Utilerias.CalcularCuotaConIntereses(cuotaLimpia, porcentajeInteres);
    int montoFinal = Utilerias.CalcularMontoFinal((int)cuotaInteres, cuotas);

    txtPagoTotal.Enabled = true;
    txtPagoTotal.ReadOnly = false;
    txtPagoTotal.Text = montoFinal.ToString();
    txtPagoTotal.ReadOnly = true;

    txtValorCuota.Enabled = true;
    txtValorCuota.ReadOnly = false;
    txtValorCuota.Text = cuotaInteres.ToString();
    txtValorCuota.ReadOnly = true;
}
else
{
    errorProvider.SetIconPadding(txtMonto, -20);
    errorProvider.SetError(txtMonto, "Ingrese un valor mayo o igual a $ 500.000");
}
*/