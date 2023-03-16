using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tanodi_DesafioFinal.Modelo;
using Tanodi_DesafioFinal.Presentador;

namespace Tanodi_DesafioFinal
{
    public partial class frmCotipro : Form, IVistaCotizador
    {
        private PresentadorPrincipal _presentador;

        public frmCotipro()
        {
            InitializeComponent();
            _presentador = new PresentadorPrincipal(this);
        }

        public void MostrarMontoTotal(float monto)
        {
            lblTotal.Text = "Monto Total: " + monto.ToString("0.00");
        }

        public void ActivarCotizacion()
        {
            gboxCotizacion.Enabled = true;
        }

        private void DesactivarCotizacion()
        {
            gboxCotizacion.Enabled = false;
            lblTotal.Text = "Monto Total: ";
        }

        public void MostrarError(string mensaje)
        {
            MessageBox.Show("Ha ocurrido un error.\n" + mensaje, "Error");
        }

        public void ActualizarTienda(string nombre, string direccion)
        {
            lblNombreTienda.Text = nombre;
            lblDireccionTienda.Text = direccion;

            //Alinear el label desde el borde derecho
            lblDireccionTienda.Location = new Point(584 - 30 - lblDireccionTienda.Size.Width, lblDireccionTienda.Location.Y);
        }

        public void ActualizarVendedor(string nombre, string apellido, string codigo)
        {
            lblNombreVendedor.Text = nombre + ", " + apellido;
            lblCodigoVendedor.Text = "Codigo: " +  codigo;
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            DesactivarCotizacion();
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            DesactivarCotizacion();
        }

        private void btnAnadirPrenda_Click(object sender, EventArgs e)
        {
            TipoPrenda tipoPrenda;

            if(rbtnCamisa.Checked)
            {
                tipoPrenda = TipoPrenda.Camisa;
            }
            else
            {
                tipoPrenda = TipoPrenda.Pantalon;
            }

            TipoManga tipoManga;

            if(cboxMangaCorta.Checked)
            {
                tipoManga = TipoManga.Corta;
            }
            else
            {
                tipoManga = TipoManga.Larga;
            }

            _presentador.AñadirPrenda(tipoPrenda, cboxCuelloMao.Checked, tipoManga, cboxChupin.Checked,
                rbtnCalidadPremium.Checked, txtStock.Text, txtPrecioUnitario.Text);
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            _presentador.Cotizar(txtCantidad.Text);
        }

        private void btnHistorialCotizaciones_Click(object sender, EventArgs e)
        {
            _presentador.AbrirHistorial();
        }
    }
}
