using PatronAdaptador.Adaptador;
using PatronAdaptador.Interfaces;
using System;

namespace PatronAdaptador
{
    class Principal
    {
        static void Main(string[] args)
        {
            IGeneradorListaSucursales listAdapter = new ListaSucursalesServices();
            IGeneradorJSonSucursales jsonAdapter = new JSONSucursalesService();
            ProcesadorService procesadorSrv = new ProcesadorService(listAdapter, jsonAdapter);

            procesadorSrv.ProcesarConLista();
            procesadorSrv.ProcesarConJson();
        }
    }
}
