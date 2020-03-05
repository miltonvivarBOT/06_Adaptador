using PatronAdaptador.DTO;
using PatronAdaptador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAdaptador.Adaptador
{
    class ListaSucursalesServices : IGeneradorListaSucursales
    {
        public List<SucursalesDTO> ObtenerSucursales()
        {
            List<SucursalesDTO> lstSucursales = new List<SucursalesDTO>();
            SucursalesDTO sucursalUno = new SucursalesDTO { Id = 1, Sucursal = "Primera", TotalVenta = 2000M };
            SucursalesDTO sucursalDos = new SucursalesDTO { Id = 2, Sucursal = "Primera", TotalVenta = 2000M };
            SucursalesDTO sucursalTres = new SucursalesDTO { Id = 3, Sucursal = "Primera", TotalVenta = 2000M };

            lstSucursales.Add(sucursalUno);
            lstSucursales.Add(sucursalDos);
            lstSucursales.Add(sucursalTres);

            return lstSucursales;
        }
    }
}
