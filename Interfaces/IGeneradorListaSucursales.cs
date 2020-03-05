using PatronAdaptador.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAdaptador.Interfaces
{
    interface IGeneradorListaSucursales
    {
        List<SucursalesDTO> ObtenerSucursales();
    }
}
