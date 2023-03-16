using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tanodi_DesafioFinal.Presentador;
using Tanodi_DesafioFinal.Modelo;

namespace Tanodi_DesafioFinal
{
    public partial class HistorialCotizaciones : Form, IHistorialCotizador
    {
        private const int Yoffset = 115;
        private int cotizaciones = 0;

        public HistorialCotizaciones()
        {
            InitializeComponent();
        }

        public void AgregarCotizacion(Cotizacion cotizacion)
        {
            Label lblID = AgregarLabel("ID: " + cotizacion.ID.ToString());
            lblID.Location = new Point(30, 20 + Yoffset * cotizaciones);

            Label lblFecha = AgregarLabel("Fecha: " + cotizacion.FechaYHora.Day + "/" + cotizacion.FechaYHora.Month + "/" + cotizacion.FechaYHora.Year);
            lblFecha.Location = new Point(100, 20 + Yoffset * cotizaciones);

            Label lblHora = AgregarLabel("Hora: " + cotizacion.FechaYHora.Hour.ToString() + ":" + cotizacion.FechaYHora.Minute.ToString());
            lblHora.Location = new Point(230, 20 + Yoffset * cotizaciones);

            Label lblCantidad = AgregarLabel("Cantidad: " + cotizacion.Cantidad.ToString());
            lblCantidad.Location = new Point(340, 20 + Yoffset * cotizaciones);

            Label lblResultado = AgregarLabel("Total: $" + cotizacion.Resultado.ToString("0.00"));
            lblResultado.Location = new Point(450, 20 + Yoffset * cotizaciones);

            Label lblDescripcion = AgregarLabel(ConstruirDescripcionPrenda(cotizacion.Prenda), false);
            lblDescripcion.Size = new Size(550, 60);
            lblDescripcion.Location = new Point(30, 50 + Yoffset * cotizaciones);

            Label lblSeparador = AgregarSeparador();
            lblSeparador.Location = new Point(0, Yoffset * (cotizaciones + 1));

            cotizaciones++;
        }

        private Label AgregarSeparador()
        {
            Label label = new Label();

            label.AutoSize = false;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Name = "separador";
            label.Text = "";
            label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label.Size = new Size(584, 2);

            panel1.Controls.Add(label);

            return label;
        }

        private Label AgregarLabel(string dato, bool autosize = true)
        {
            Label label = new Label();

            label.AutoSize = autosize;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Name = "label";
            label.Text = dato;

            panel1.Controls.Add(label);

            return label;
        }

        private string ConstruirDescripcionPrenda(Prenda prenda)
        {
            string descripcion = "Descripcion: ";

            if (prenda is Camisa camisa)
            {
                descripcion += "Camisa ";

                if(camisa.CuelloMao)
                {
                    descripcion += "con ";
                }
                else
                {
                    descripcion += "sin ";
                }

                descripcion += "cuello Mao y con mangas ";

                if(camisa.Manga == TipoManga.Corta)
                {
                    descripcion += "cortas ";
                }
                else
                {
                    descripcion += "largas ";
                }
            }
            else if(prenda is Pantalon pantalon)
            {
                descripcion += "Pantalón ";

                if(pantalon.EsChupin)
                {
                    descripcion += "chupín ";
                }
            }

            descripcion += ", de calidad ";

            if(prenda.EsPremium)
            {
                descripcion += "premium ";
            }
            else
            {
                descripcion += "normal ";
            }

            descripcion += " y con un precio unitario de $" + prenda.PrecioUnitario.ToString("0.00") + ".";

            return descripcion;
        }

    }
}
