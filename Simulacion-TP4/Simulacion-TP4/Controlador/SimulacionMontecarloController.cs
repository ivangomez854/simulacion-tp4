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
using System.Windows.Forms.DataVisualization.Charting;

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

        public void generarSimulacion(double cantidad, ToolStripProgressBar progressBar, Chart chartPromedios)
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
                    ActividadEnsamble actividad = this.montecarloService.SimularSiguienteActividad();
                    chartPromedios.Series[0].Points.AddXY(actividad.Orden, actividad.PromedioAcumuladoTiempoTotal);
                    listadoSimulacion.Add(actividad);
                }
                cantidadPendienteBuscar -= amplitudSegmentoBusqueda;
                progressBar.PerformStep();
            }

            if (cantidadPendienteBuscar > 0)
            {
                for (var j = 1; j <= cantidadPendienteBuscar; j++)
                {
                    ActividadEnsamble actividad = this.montecarloService.SimularSiguienteActividad();
                    chartPromedios.Series[0].Points.AddXY(actividad.Orden, actividad.PromedioAcumuladoTiempoTotal);
                    listadoSimulacion.Add(actividad);
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

        public double ObtenerTiempoMinimo()
        {
            return listadoSimulacion.Count > 0 ? montecarloService.TiempoMinimo : 0;
        }        
        
        public double ObtenerTiempoMaximo()
        {
            return listadoSimulacion.Count > 0 ? montecarloService.TiempoMaximo : 0;
        }

        public double ObtenerProbabilidadAntes45Dias()
        {
            return listadoSimulacion.Count > 0 ? Math.Round(montecarloService.CantidadAntes45Dias / listadoSimulacion.Count, 4) : 0;
        }

        public double ObtenerPromedioEnsamble()
        {
            return listadoSimulacion.Count > 0 ? Math.Round(montecarloService.TiempoPromedioActividades, 2) : 0;
        }

    }
}
