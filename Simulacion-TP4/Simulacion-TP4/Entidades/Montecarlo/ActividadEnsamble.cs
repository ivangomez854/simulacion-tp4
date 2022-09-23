using Simulacion.Entidades.Randoms;
using Simulacion_TP4.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simulacion_TP4.Entidades.Montecarlo
{
    internal class ActividadEnsamble
    {
        public const String CAMINO_1 = "A1 -> A4 -> A5";
        public const String CAMINO_2 = "A2 -> A5";
        public const String CAMINO_3 = "A3";
        public String CaminoCritico { get; }
        public double ProbabilidadCaminoCritico1 { get; set; }
        public double ProbabilidadCaminoCritico2 { get; set; }
        public double ProbabilidadCaminoCritico3 { get; set; }
        public double Orden { get; set; }
        public Tarea T1 { get; }
        public Tarea T2 { get; }
        public Tarea T3 { get; }
        public Tarea T4 { get; }
        public Tarea T5 { get; }

        public double TiempoT1 { get { return Math.Round(T1.DuracionMinima, 2); } }
        public double TiempoT2 { get { return Math.Round(T2.DuracionMinima, 2); } }
        public double TiempoT3 { get { return Math.Round(T3.DuracionMinima, 2); } }
        public double TiempoT4 { get { return Math.Round(T4.DuracionMinima, 2); } }
        public double TiempoT5 { get { return Math.Round(T5.DuracionMinima, 2); } }
        public double RndT1 { get { return Math.Round(T1.VariableAleatoria.Rnd1, 4); } }
        public double RndT2 { get { return Math.Round(T2.VariableAleatoria.Rnd1, 4); } }
        public double RndT3 { get { return Math.Round(T3.VariableAleatoria.Rnd1, 4); } }
        public double RndT4 { get { return Math.Round(T4.VariableAleatoria.Rnd1, 4); } }
        public double RndT5 { get { return Math.Round(T5.VariableAleatoria.Rnd1, 4); } }
 
        public double TiempoAtrasoPosibleT1 { get; set; }
        public double TiempoAtrasoPosibleT2 { get; set; }
        public double TiempoAtrasoPosibleT3 { get; set; }
        public double TiempoAtrasoPosibleT4 { get; set; }
        public double TiempoAtrasoPosibleT5 { get; set; }
        public double TiempoTotal { get; }

        public double AcumuladoTiempoTotal { get; set; }

        public double PromedioAcumuladoTiempoTotal { get; set; }


        public ActividadEnsamble(double orden, Tarea t1, Tarea t2, Tarea t3, Tarea t4, Tarea t5)
        {
            Orden = orden;
            T1 = t1;
            T2 = t2;
            T3 = t3;
            T4 = t4;
            T5 = t5;
            TiempoTotal = T3 != null && T5 != null ? Math.Round(this.CalcularTiempoTotal(), 2) : 0;
            CaminoCritico = T3 != null && T5 != null ? this.CalcularCaminoCritico() : "";
            PromedioAcumuladoTiempoTotal = CalcularPromedioAcumuladoTiempoTotal();

            if (T3 != null && T5 != null)
            {
                TiempoAtrasoPosibleT1 = (double)Math.Round(TiempoTotal - T5.DuracionMinima - T4.DuracionMinima - T1.DuracionMinima, 2);
                TiempoAtrasoPosibleT2 = (double)Math.Round(TiempoTotal - T5.DuracionMinima - T2.DuracionMinima, 2);
                TiempoAtrasoPosibleT3 = (double)Math.Round(TiempoTotal - T3.DuracionMinima, 2);
                TiempoAtrasoPosibleT4 = (double)Math.Round(TiempoTotal - T5.DuracionMinima - T4.DuracionMinima, 2);
                TiempoAtrasoPosibleT5 = (double)Math.Round(TiempoTotal - T5.DuracionMinima, 2);
            }
        }

        private double CalcularTiempoTotal()
        {
            return Math.Max(T3.DuracionTotalTarea(), T5.DuracionTotalTarea());
        }

        private String CalcularCaminoCritico()
        {
            // obtengo cuanto duro cada actividad
            double tiempoActividad1 = T1.DuracionMinima;
            double tiempoActividad2 = T2.DuracionMinima;
            double tiempoActividad3 = T3.DuracionMinima;
            double tiempoActividad4 = T4.DuracionMinima;
            double tiempoActividad5 = T5.DuracionMinima;

            // hay 3 caminos posibles:
            // A1 -> A4 -> A5 -> FINAL
            // A2 -> A5 -------> FINAL
            // A3 -------------> FINAL
            double tiempoCamino1 = tiempoActividad1 + tiempoActividad4 + tiempoActividad5;
            double tiempoCamino2 = tiempoActividad2 + tiempoActividad5;
            double tiempoCamino3 = tiempoActividad3;

            // el camino que demora mas tiempo es el camino critico
            double tiempoCaminoCritico = tiempoCamino1;
            String caminoCritico = CAMINO_1;

            if (tiempoCamino2 > tiempoCaminoCritico)
            {
                tiempoCaminoCritico = tiempoCamino2;
                caminoCritico = CAMINO_2;
            }

            if (tiempoCamino3 > tiempoCaminoCritico)
            {
                tiempoCaminoCritico = tiempoCamino3;
                caminoCritico = CAMINO_3;
            }

            return caminoCritico;
        }

        private double CalcularPromedioAcumuladoTiempoTotal()
        {
            return AcumuladoTiempoTotal / Orden;
        }
    }
}
