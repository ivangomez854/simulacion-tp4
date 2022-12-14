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

        public double CantidadAntes45Dias { get; set; }

        public ActividadEnsamble EstadoActual { get; set; }


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
            EstadoActual.ProbabilidadCaminoCritico1 = 0;
            EstadoActual.ProbabilidadCaminoCritico2 = 0;
            EstadoActual.ProbabilidadCaminoCritico3 = 0;
            EstadoActual.Varianza = 0;

            //Inicializo propiedades de sumarizacion
            TiempoMaximo = Double.MinValue;
            TiempoMinimo = Double.MaxValue;
            CantidadAntes45Dias = 0;
        }

        public ActividadEnsamble SimularSiguienteActividad()
        {
            var orden = EstadoActual.Orden + 1;
            // Obtengo los tiempos de cada tarea
            var tiempo1 = RndT1.ObtenerSiguiente();
            var tiempo2 = RndT2.ObtenerSiguiente();
            var tiempo3 = RndT3.ObtenerSiguiente();
            var tiempo4 = RndT4.ObtenerSiguiente();
            var tiempo5 = RndT5.ObtenerSiguiente();

            // Creo cada tarea con su precedente
            var tarea1 = new Tarea(tiempo1, null);
            var tarea2 = new Tarea(tiempo2, null);
            var tarea3 = new Tarea(tiempo3, null);
            var tarea4 = new Tarea(tiempo4, tarea1);

            Tarea tarea5;
            if (tiempo4.ValorAleatorio + tiempo1.ValorAleatorio > tiempo2.ValorAleatorio)
            {
                tarea5 = new Tarea(tiempo5, tarea4);
            } else
            {
                tarea5 = new Tarea(tiempo5, tarea2);
            }

            // Creo la nueva actividad con su respectivo numero de orden
            var actividad = new ActividadEnsamble(orden, tarea1, tarea2, tarea3, tarea4, tarea5);
            // Calculo los datos sumarizados del conjunto de actividades
            actividad.AcumuladoTiempoTotal = Math.Round(EstadoActual.AcumuladoTiempoTotal + actividad.TiempoTotal, 2);
            actividad.PromedioAcumuladoTiempoTotal = Math.Round(actividad.AcumuladoTiempoTotal / orden, 2);

            if (orden > 1)
            {
                actividad.Varianza = ((orden - 2) * EstadoActual.Varianza + (orden / (orden - 1)) * Math.Pow(actividad.PromedioAcumuladoTiempoTotal - actividad.TiempoTotal, 2)) / (orden - 1);
            }

            TiempoMaximo = actividad.TiempoTotal > TiempoMaximo ? actividad.TiempoTotal : TiempoMaximo;
            TiempoMinimo = actividad.TiempoTotal < TiempoMinimo ? actividad.TiempoTotal : TiempoMinimo;
            CantidadAntes45Dias += actividad.TiempoTotal <= 45 ? 1 : 0;

            double aumentaCamino1 = 0;
            double aumentaCamino2 = 0;
            double aumentaCamino3 = 0;
            switch (actividad.CaminoCritico)
            {
                case ActividadEnsamble.CAMINO_1:
                    aumentaCamino1 = 1;
                    break;
                case ActividadEnsamble.CAMINO_2:
                    aumentaCamino2 = 1;
                    break;
                case ActividadEnsamble.CAMINO_3:
                    aumentaCamino3 = 1;
                    break;
                default:
                    break;
            }
            actividad.ProbabilidadCaminoCritico1 = ((EstadoActual.ProbabilidadCaminoCritico1 * (orden - 1)) + aumentaCamino1) / orden;
            actividad.ProbabilidadCaminoCritico2 = ((EstadoActual.ProbabilidadCaminoCritico2 * (orden - 1)) + aumentaCamino2) / orden;
            actividad.ProbabilidadCaminoCritico3 = ((EstadoActual.ProbabilidadCaminoCritico3 * (orden - 1)) + aumentaCamino3) / orden;

            // Actualizo el vector de estado actual y retorno
            this.EstadoActual = actividad;
               

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
