using Simulacion.Entidades;
using Simulacion.Entidades.Interfaces;
using Simulacion.Entidades.Randoms;
using Simulacion_TP4.Entidades.Montecarlo;
using Simulacion_TP4.InterfacesUsuario;
using Simulacion_TP4.Montecarlo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_TP4.Controlador
{
    internal class SimulacionMontecarloController
    {
        BindingList<ActividadEnsamble> listadoSimulacion;
        public SimulacionMontecarloService montecarloService;

        public SimulacionMontecarloController(BindingList<ActividadEnsamble> lista, IGeneradorVA vA1, IGeneradorVA vA2, IGeneradorVA vA3, IGeneradorVA vA4, IGeneradorVA vA5)
        {
            this.listadoSimulacion = lista;
            this.montecarloService = new SimulacionMontecarloService(vA1, vA2, vA3, vA4, vA5);
        }

        public void generarSimulacion(double cantidad, ToolStripProgressBar progressBar)
        {

            int cantidadSegmentosBusqueda = this.CalcularSegmentosBusqueda(cantidad);
            double cantidadPendienteBuscar = cantidad;
            double amplitudSegmentoBusqueda = Math.Truncate(cantidad / cantidadSegmentosBusqueda);

            // Configuro la progressBar
            progressBar.Value = 0;
            progressBar.Step = (int)amplitudSegmentoBusqueda;
            progressBar.Maximum = (int)cantidad;

            for (var i = 1; i <= cantidadSegmentosBusqueda; i++)
            {
                for (var j = 1; j <= amplitudSegmentoBusqueda; j++)
                {
                    listadoSimulacion.Add(this.montecarloService.SimularSiguienteActividad());
                }
                cantidadPendienteBuscar -= amplitudSegmentoBusqueda;
                progressBar.PerformStep();
            }

            if (cantidadPendienteBuscar > 0)
            {
                for (var j = 1; j <= cantidadPendienteBuscar; j++)
                {
                    listadoSimulacion.Add(this.montecarloService.SimularSiguienteActividad());
                }
            }
            progressBar.Value = (int)cantidad;
        }


        /// <summary>
        /// Metodo auxiliar que permite calcular en cuantos segmentos dividir la generacion de un listado de gran cantidad de variables aleatorias.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        private int CalcularSegmentosBusqueda(double cantidad)
        {
            int cantidadSegmentosBusqueda = cantidad / 10000 >= 1 ? (int)Math.Truncate(cantidad / 10000) : 1;
            return cantidadSegmentosBusqueda;
        }

    }
}
