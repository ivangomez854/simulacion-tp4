using Simulacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_TP4.Entidades.Montecarlo
{
    internal class Tarea
    {
        public double DuracionMinima { get; }

        public VariableAleatoria VariableAleatoria { get; }

        public Tarea Precedente { get; set; }

        public Tarea(VariableAleatoria va, Tarea precedente)
        {
            VariableAleatoria = va;
            DuracionMinima = va.ValorAleatorio;
            this.Precedente = precedente;
        }

        public double DuracionTotalTarea()
        {
            var aux = DuracionMinima;

            if (Precedente != null)
            {
                    aux += Precedente.DuracionTotalTarea();
            }
            return aux;
        }
    }
}
