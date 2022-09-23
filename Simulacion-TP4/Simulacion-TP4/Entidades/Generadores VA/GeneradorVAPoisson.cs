﻿using Simulacion.Entidades.Interfaces;
using Simulacion.Entidades.Randoms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion.Entidades
{
    internal class GeneradorVAPoisson : IGeneradorVA
    {
        private IGeneradorRandom generadorRnd;
        public double lamda { get; } // Limite Real inferior

        private VariableAleatoria estadoActual;


        public GeneradorVAPoisson(IGeneradorRandom generadorRnd, double lamda)
        {
            this.generadorRnd = generadorRnd;
            this.lamda = lamda;
            this.estadoActual = new VariableAleatoria();
            this.estadoActual.Orden = 0;
        }

        public BindingList<VariableAleatoria> generarListaVA(double cantidad, [Optional] BindingList<VariableAleatoria> listaCompletar)
        {
            BindingList<VariableAleatoria> lista = listaCompletar is null ? new BindingList<VariableAleatoria>() : listaCompletar;
            var a = Math.Exp(-this.lamda);

            // Inicio la generacion de variables aleatorias
            for (int i = 1; i <= cantidad; i++)
            {   
                // Algorirmo para generar VA Poisson
                double p = 1;
                var x = -1;
                do
                {
                    // Pido un random
                    var rnd = this.generadorRnd.obtenerProximoRandom();
                    p = p * rnd.Item2;
                    x++;
                }
                while (p > a);
                
                // La X resultante al final del ciclo es la VA Poisson
                VariableAleatoria n1 = new VariableAleatoria();
                n1.Orden = this.estadoActual.Orden + 1;
                n1.ValorAleatorio = x;
                // Cargo la variable aleatoria en la lista
                lista.Add(n1);
                // Actualizo el estado actual
                this.estadoActual = lista.Last();
            }
            
            return lista;
        }

        public VariableAleatoria ObtenerEstadoActual()
        {
            return this.estadoActual;
        }

        public VariableAleatoria ObtenerSiguiente()
        {
            var a = Math.Exp(-this.lamda);
            // Algorirmo para generar VA Poisson
            double p = 1;
            var x = -1;
            do
            {
                // Pido un random
                var rnd = this.generadorRnd.obtenerProximoRandom();
                p = p * rnd.Item2;
                x++;
            }
            while (p > a);

            // La X resultante al final del ciclo es la VA Poisson
            VariableAleatoria n1 = new VariableAleatoria();
            n1.Orden = this.estadoActual.Orden + 1;
            n1.ValorAleatorio = x;
            // Actualizo el estado actual
            this.estadoActual = n1;
            return this.estadoActual;
        }
    }
}
