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
        public double RndT1 { get { return Math.Round(T1.VariableAleatoria.Rnd1, 2); } }
        public double RndT2 { get { return Math.Round(T2.VariableAleatoria.Rnd1, 2); } }
        public double RndT3 { get { return Math.Round(T3.VariableAleatoria.Rnd1, 2); } }
        public double RndT4 { get { return Math.Round(T4.VariableAleatoria.Rnd1, 2); } }
        public double RndT5 { get { return Math.Round(T5.VariableAleatoria.Rnd1, 2); } }
 
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
            TiempoTotal = T3 != null && T5 != null ? this.CalcularTiempoTotal() : 0;
            PromedioAcumuladoTiempoTotal = CalcularPromedioAcumuladoTiempoTotal();
        }

        private double CalcularTiempoTotal()
        {
            return Math.Max(T3.DuracionTotalTarea(), T5.DuracionTotalTarea());
        }

        private double CalcularPromedioAcumuladoTiempoTotal()
        {
            return AcumuladoTiempoTotal / Orden;
        }
    }
}
