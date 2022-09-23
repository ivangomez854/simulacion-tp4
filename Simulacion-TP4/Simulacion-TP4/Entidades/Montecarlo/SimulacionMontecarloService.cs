using Simulacion.Entidades;
using Simulacion.Entidades.Interfaces;
using Simulacion.Entidades.Randoms;
using Simulacion_TP4.Entidades.Montecarlo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_TP4.Montecarlo
{
    internal class SimulacionMontecarloService
    {
        IGeneradorVA RndT1 { get; }
        IGeneradorVA RndT2 { get; }
        IGeneradorVA RndT3 { get; }
        IGeneradorVA RndT4 { get; }
        IGeneradorVA RndT5 { get; }

        public double TiempoMaximo { get; set; }
        public double TiempoMinimo { get; set; }
        public double TiempoPromedioActividades { get {
                return EstadoActual.Orden > 0 ? EstadoActual.PromedioAcumuladoTiempoTotal : 0;
            } }

        private ActividadEnsamble EstadoActual { get; set; }


        public SimulacionMontecarloService(IGeneradorVA rndT1, IGeneradorVA rndT2, IGeneradorVA rndT3, IGeneradorVA rndT4, IGeneradorVA rndT5)
        {
            RndT1 = rndT1;
            RndT2 = rndT2;
            RndT3 = rndT3;
            RndT4 = rndT4;
            RndT5 = rndT5;

            // Inicializo vector de estado nulo
            EstadoActual = new ActividadEnsamble(0, null, null, null, null, null);
            EstadoActual.AcumuladoTiempoTotal = 0;
            EstadoActual.PromedioAcumuladoTiempoTotal = 0;

            //Inicializo propiedades de sumarizacion
            TiempoMaximo = Double.MinValue;
            TiempoMinimo = Double.MaxValue;
        }

        public ActividadEnsamble SimularSiguienteActividad()
        {
                var orden = EstadoActual.Orden + 1;
                // Obtengo los tiempos de cada tarea
                var tiempo1 = RndT1.ObtenerSiguiente();
                var tiempo2 = RndT1.ObtenerSiguiente();
                var tiempo3 = RndT1.ObtenerSiguiente();
                var tiempo4 = RndT1.ObtenerSiguiente();
                var tiempo5 = RndT1.ObtenerSiguiente();

                // Creo cada tarea con su precedente
                var tarea1 = new Tarea(tiempo1, null);
                var tarea2 = new Tarea(tiempo2, null);
                var tarea3 = new Tarea(tiempo3, null);
                var tarea4 = new Tarea(tiempo4, tarea1);
                var tarea5 = new Tarea(tiempo5, tarea2);
                // Creo la nueva actividad con su respectivo numero de orden
                var actividad = new ActividadEnsamble(orden, tarea1, tarea2, tarea3, tarea4, tarea5);
                // Calculo los datos sumarizados del conjunto de actividades
                actividad.AcumuladoTiempoTotal = EstadoActual.AcumuladoTiempoTotal + actividad.TiempoTotal;
                actividad.PromedioAcumuladoTiempoTotal = actividad.AcumuladoTiempoTotal / orden;

                TiempoMaximo = actividad.TiempoTotal > TiempoMaximo ? actividad.TiempoTotal : TiempoMaximo;
                TiempoMinimo = actividad.TiempoTotal < TiempoMinimo ? actividad.TiempoTotal : TiempoMinimo;
                // Actualizo el vector de estado actual y retorno
                this.EstadoActual = actividad;
            return EstadoActual;
        }

        public ActividadEnsamble ObtenerEstadoActual()
        {
            return EstadoActual;
        }
    }
}
