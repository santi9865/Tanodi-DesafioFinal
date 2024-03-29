﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanodi_DesafioFinal.Modelo
{
    class Tienda
    {
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }

        private List<Vendedor> _vendedores;

        private List<Prenda> _prendas;

        public Tienda(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;

            _vendedores = new List<Vendedor>();
            _prendas = new List<Prenda>();
        }

        public void NuevaPrenda(Prenda prenda)
        {
            _prendas.Add(prenda);
        }

        public void NuevoVendedor(Vendedor vendedor)
        {
            _vendedores.Add(vendedor);
        }

        public Vendedor GetVendedor(int codigo)
        {
            foreach(Vendedor vendedor in _vendedores)
            {
                if(vendedor.Codigo == codigo)
                {
                    return vendedor;
                }
            }

            return null;
        }

        public int GetStock(Prenda pedido)
        {
            foreach(Prenda prenda in _prendas)
            {
                if(pedido.EsPremium == prenda.EsPremium)
                {
                    if (pedido is Camisa camisaPedido && prenda is Camisa camisaPrenda)
                    {
                        if(camisaPedido.CuelloMao == camisaPrenda.CuelloMao && camisaPedido.Manga == camisaPrenda.Manga)
                        {
                            return camisaPrenda.Stock;
                        }
                    }
                    else if(pedido is Pantalon pantalonPedido && prenda is Pantalon pantalonPrenda)
                    {
                        if(pantalonPedido.EsChupin == pantalonPrenda.EsChupin)
                        {
                            return pantalonPrenda.Stock;
                        }
                    }
                }
            }

            return -1;
        }

    }
}
