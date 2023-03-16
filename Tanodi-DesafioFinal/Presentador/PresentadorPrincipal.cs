using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanodi_DesafioFinal.Modelo;

namespace Tanodi_DesafioFinal.Presentador
{
    class PresentadorPrincipal
    {
        private IVistaCotizador _vistaCotizador;

        private Prenda _prendaActual;

        private Tienda _tienda;

        private Vendedor _vendedorActual;

        public PresentadorPrincipal(IVistaCotizador vista)
        {
            _vistaCotizador = vista;

            CrearTiendaYVendedorFicticios();
        }

        private void CrearTiendaYVendedorFicticios()
        {
            _tienda = new Tienda("Talla Grande", "27 de Abril 563, Villa Mercedes");
            _vendedorActual = new Vendedor("Manuel", "Contilla", 2346, _tienda);
            _tienda.NuevoVendedor(_vendedorActual);

            _vistaCotizador.ActualizarTienda(_tienda.Nombre, _tienda.Direccion);
            _vistaCotizador.ActualizarVendedor(_vendedorActual.Nombre, _vendedorActual.Apellido, _vendedorActual.Codigo.ToString());
        }

        public void AñadirPrenda(TipoPrenda tipoPrenda, bool cuelloMao, TipoManga manga, bool esChupin, bool esPremium ,string stock, string precioUnitario )
        {
            int stockInt = 0;
            float precioUnitarioFloat = 0;

            if(Validador.ValidarInt(stock, ref stockInt))
            {
                if(stockInt < 1)
                {
                    _vistaCotizador.MostrarError("El stock disponible debe ser mayor a 0.");
                }
            }
            else
            {
                _vistaCotizador.MostrarError("El número del stock es inválido.");
            }

            if(Validador.ValidarFloat(precioUnitario, ref precioUnitarioFloat))
            {
                if(!(precioUnitarioFloat > 0))
                {
                    _vistaCotizador.MostrarError("El precio unitario debe ser mayor a 0.");
                }
            }
            else
            {
                _vistaCotizador.MostrarError("El número del precio unitario es inválido.");
            }

            if(stockInt > 0 && precioUnitarioFloat > 0)
            {
                switch(tipoPrenda)
                {
                    case TipoPrenda.Camisa:
                        _prendaActual = new Camisa(cuelloMao, manga, esPremium, precioUnitarioFloat, stockInt);
                        break;
                    case TipoPrenda.Pantalon:
                        _prendaActual = new Pantalon(esPremium, precioUnitarioFloat, esChupin, stockInt);
                        break;
                }

                _vistaCotizador.ActivarCotizacion();
            }
        }


        public void Cotizar(string cantidad)
        {
            int cantidadPrendas = 0;

            if(Validador.ValidarInt(cantidad, ref cantidadPrendas))
            {
                if(cantidadPrendas < 1)
                {
                    _vistaCotizador.MostrarError("La cantidad a cotizar debe ser mayor a 0.");
                }
                else
                {
                    if(cantidadPrendas > _prendaActual.Stock)
                    {
                        _vistaCotizador.MostrarError("No hay stock suficiente para la cantidad seleccionada.");
                    }
                    else
                    {
                        Cotizacion ultimaCotizacion = _vendedorActual.NuevaCotizacion(_prendaActual, cantidadPrendas);

                        _vistaCotizador.MostrarMontoTotal(ultimaCotizacion.Resultado);
                    }
                }
            }
            else
            {
                _vistaCotizador.MostrarError("La cantidad de prendas no es un número válido.");
            }
        }

        public void AbrirHistorial()
        {
            if(_vendedorActual.HistorialCotizaciones.Count > 0)
            {
                HistorialCotizaciones historialCotizaciones = new HistorialCotizaciones();
                historialCotizaciones.Show();
                foreach(Cotizacion cotizacion in _vendedorActual.HistorialCotizaciones)
                {
                    historialCotizaciones.AgregarCotizacion(cotizacion);
                }

                historialCotizaciones.Text = "Historial Cotizaciones - Código Vendedor: " + _vendedorActual.Codigo.ToString();
            }
            else
            {
                _vistaCotizador.MostrarError("El historial de cotizaciones está vacío.");
            }
        }
    }

    public enum TipoPrenda
    {
        Camisa,
        Pantalon
    }
}
