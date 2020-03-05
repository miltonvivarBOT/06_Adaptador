using PatronAdaptador.DTO;
using PatronAdaptador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAdaptador
{
    class ProcesadorService
    {
        private readonly IGeneradorListaSucursales generadorListaSucursales;
        private readonly IGeneradorJSonSucursales generadorJSonSucursales;

        public ProcesadorService(IGeneradorListaSucursales generadorListaSucursales, IGeneradorJSonSucursales generadorJSonSucursales)
        {
            this.generadorListaSucursales = generadorListaSucursales;
            this.generadorJSonSucursales = generadorJSonSucursales;
        }

        public void ProcesarConLista() {
            var lstSucursales = this.generadorListaSucursales.ObtenerSucursales();
            foreach (SucursalesDTO sucursales in lstSucursales)
            {
                Console.WriteLine("Id:{0}, Sucursal:{1}, Total Venta:{2}", sucursales.Id,sucursales.Sucursal,sucursales.TotalVenta);
            }

        }
        public void ProcesarConJson()
        {
            Console.WriteLine(this.generadorJSonSucursales.ObtenerSucursales());

        }
    }
}
