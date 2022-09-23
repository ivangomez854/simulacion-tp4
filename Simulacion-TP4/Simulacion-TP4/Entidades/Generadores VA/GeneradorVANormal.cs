using Simulacion.Entidades.Randoms;
using Simulacion.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Collections;

namespace Simulacion.Entidades
{
    internal class GeneradorVANormal : IGeneradorVA
    {
        private IGeneradorRandom generadorRnd;
        public double Media { get; }
        public double Desviacion { get; }

        private VariableAleatoria VASinUsar; //Me avisa que tengo una variable aleatoria sin usar
        private VariableAleatoria EstadoActual;


        public GeneradorVANormal(IGeneradorRandom generadorRnd, double media, double desviacion)
        {
            this.generadorRnd = generadorRnd;
            this.Media = media;
            this.Desviacion = desviacion;
            this.EstadoActual = null;
            this.VASinUsar = null;
        }

        public BindingList<VariableAleatoria> generarListaVA(double cantidad, [Optional] BindingList<VariableAleatoria> listaCompletar)
        {
            BindingList<VariableAleatoria> lista = listaCompletar is null ? new BindingList<VariableAleatoria>() : listaCompletar;
            var laUltimaNoVa = false;
            var cantidadGenerar = cantidad;

            //Chequeo si hay random pendiente de usar
            if (this.VASinUsar != null && cantidad == 1 ) {
                lista.Add(this.VASinUsar);
                this.EstadoActual = this.VASinUsar; // Actualizo el estado actual
                this.VASinUsar = null;
                return lista;
            } else if (this.VASinUsar != null && (cantidad - 1) > 0)
            {
                lista.Add(this.VASinUsar);
                this.VASinUsar = null;
                cantidadGenerar--;
                // Aca no actualizo el estado actual porque con la validacion ya se que falta generar mas variables
            }

            // Si paso el chequeo me fijo que la cantidad a generar sea par
            if (cantidadGenerar % 2 != 0) {
                cantidadGenerar = cantidadGenerar + 1;
                laUltimaNoVa = true;
            }
            // Inicio la generacion de variables aleatorias
            for (int i = 1; i <= cantidadGenerar; i+=2)
            {
                // Pido dos randoms
                var rnd1 = this.generadorRnd.obtenerProximoRandom();
                var rnd2 = this.generadorRnd.obtenerProximoRandom();
                //Calculo las proximas dos variables aleatorias
                VariableAleatoria n1 = new VariableAleatoria();
                VariableAleatoria n2 = new VariableAleatoria();
                n1.Rnd1 = rnd1.Item2;
                n1.Rnd2 = rnd2.Item2;
                n1.Orden = rnd1.Item1;
                n1.ValorAleatorio = Math.Sqrt(-2 * Math.Log(rnd1.Item2)) * Math.Cos(2 * Math.PI * rnd2.Item2) * this.Desviacion + this.Media;
                n2.Rnd1 = rnd1.Item2;
                n2.Rnd2 = rnd2.Item2;
                n2.Orden = rnd2.Item1;
                n2.ValorAleatorio = Math.Sqrt(-2 * Math.Log(rnd1.Item2)) * Math.Sin(2 * Math.PI * rnd2.Item2) * this.Desviacion + this.Media;
                // Cargo las variables aleatorias en la lista
                lista.Add(n1);
                lista.Add(n2);
            }
            // Si la ultima no va la saco
            if(laUltimaNoVa)
            {
                VASinUsar = lista.Last();
                lista.RemoveAt(lista.Count-1);
            }
            // Antes de retornar actualizo el estado actual
            this.EstadoActual = lista.Last();
            return lista;
        }

        public VariableAleatoria ObtenerEstadoActual()
        {
            return this.EstadoActual;
        }

        public VariableAleatoria ObtenerSiguiente()
        {
            //Chequeo si hay random pendiente de usar
            if (this.VASinUsar != null)
            {
                this.EstadoActual = this.VASinUsar; // Actualizo el estado actual
                this.VASinUsar = null;
                return this.EstadoActual;
            }
            
            // Pido dos randoms
            var rnd1 = this.generadorRnd.obtenerProximoRandom();
            var rnd2 = this.generadorRnd.obtenerProximoRandom();
            //Calculo las proximas dos variables aleatorias
            VariableAleatoria n1 = new VariableAleatoria();
            VariableAleatoria n2 = new VariableAleatoria();
            n1.Rnd1 = rnd1.Item2;
            n1.Rnd2 = rnd2.Item2;
            n1.Orden = rnd1.Item1;
            n1.ValorAleatorio = Math.Sqrt(-2 * Math.Log(rnd1.Item2)) * Math.Cos(2 * Math.PI * rnd2.Item2) * this.Desviacion + this.Media;
            n2.Rnd1 = rnd1.Item2;
            n2.Rnd2 = rnd2.Item2;
            n2.Orden = rnd2.Item1;
            n2.ValorAleatorio = Math.Sqrt(-2 * Math.Log(rnd1.Item2)) * Math.Sin(2 * Math.PI * rnd2.Item2) * this.Desviacion + this.Media;
            // Cargo las variables aleatorias
            this.EstadoActual = n1;
            this.VASinUsar = n2;
            return n1;
        }
    }
}
