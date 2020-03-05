using PatronAdaptador.DTO;
using PatronAdaptador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAdaptador.Adaptador
{
    class JSONSucursalesService : IGeneradorJSonSucursales
    {
        private ListaSucursalesServices sucursalesServices;
        public JSONSucursalesService()
        {
            sucursalesServices = new ListaSucursalesServices();

        }
        public string ObtenerSucursales()
        {
            string cadenaJson = "";

            //string builderJson = "{\"Id\":\"{0}\",\"Sucursal\":\"{1}\",\"Totalventa\":\"{2}\"}";
            string builderJson = "Id:{0},Sucursal:{1},Totalventa:{2}";
            List<SucursalesDTO> lstSucursalesDTO = sucursalesServices.ObtenerSucursales();
            foreach (SucursalesDTO sucursal in lstSucursalesDTO)
            {
                if (cadenaJson != "") cadenaJson += ",";
                cadenaJson += "{" + string.Format(builderJson, sucursal.Id.ToString(), sucursal.Sucursal, sucursal.TotalVenta.ToString()) + "}";
            }
            return string.Format("[{0}]", cadenaJson);

        }
    }
}
