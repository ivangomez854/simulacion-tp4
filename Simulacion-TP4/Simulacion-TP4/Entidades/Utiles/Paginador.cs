﻿using Simulacion_TP4.Entidades.Montecarlo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion.Entidades.Utiles
{
    internal class Paginador
    {
        private int actualInferior;
        private int actualSuperior;
        private int amplitud;
        private int cantidadPaginas;
        private int paginaActual;

        private BindingList<ActividadEnsamble> lista;

        public Paginador(BindingList<ActividadEnsamble> lista, int amplitud)
        {
            this.lista = lista;
            this.amplitud = amplitud;
            this.cantidadPaginas = this.CalcularCantidadPaginas(lista.Count, amplitud);
        }

        public BindingList<ActividadEnsamble> ObtenerPrimerPagina()
        {   
            this.actualInferior = 0;
            this.actualSuperior = this.lista.Count > this.amplitud ? this.amplitud : this.lista.Count - 1;
            this.paginaActual = 1;

            return this.ObtenerListaEntreLimites(this.actualInferior, this.actualSuperior);
        }
        
        public BindingList<ActividadEnsamble> ObtenerUltimaPagina()
        {
            this.paginaActual = this.cantidadPaginas;
            this.actualInferior = (this.cantidadPaginas - 1) * this.amplitud;
            this.actualSuperior = this.paginaActual * amplitud <= this.lista.Count ? this.paginaActual * this.amplitud : this.lista.Count - 1;

            return this.ObtenerListaEntreLimites(this.actualInferior, this.actualSuperior);
        }
        
        public BindingList<ActividadEnsamble> ObtenerPaginaSiguiente()
        {   
            if (this.paginaActual == this.cantidadPaginas)
            {
                return null;
            }
            this.paginaActual++;
            this.actualInferior = (this.paginaActual - 1) * this.amplitud;
            this.actualSuperior = this.paginaActual * amplitud <= this.lista.Count ? this.paginaActual * this.amplitud : this.lista.Count - 1;

            return this.ObtenerListaEntreLimites(this.actualInferior, this.actualSuperior);
        }
        
        public BindingList<ActividadEnsamble> ObtenerPaginaAnterior()
        {
            if (this.paginaActual == 1)
            {
                return null;
            }
            this.paginaActual--;
            this.actualInferior = (this.paginaActual - 1) * this.amplitud;
            this.actualSuperior = this.paginaActual * amplitud <= this.lista.Count ? this.paginaActual * this.amplitud : this.lista.Count - 1;

            return this.ObtenerListaEntreLimites(this.actualInferior, this.actualSuperior);
        }

        public BindingList<ActividadEnsamble> BuscarPaginaXIndice(int indice)
        {
            if (indice < 0 || indice > this.lista.Count)
            {
                return null;
            }

            for(var i = 1; i <= this.cantidadPaginas; i++)
            {
                if (indice <= i*this.amplitud)
                {
                    this.paginaActual = i;
                    this.actualInferior = (i - 1) * this.amplitud;
                    this.actualSuperior = this.paginaActual * amplitud <= this.lista.Count ? this.paginaActual * this.amplitud : this.lista.Count - 1;

                    return this.ObtenerListaEntreLimites(this.actualInferior, this.actualSuperior);
                }
            }
            
            this.paginaActual--;
            this.actualInferior = (this.paginaActual - 1) * this.amplitud;
            this.actualSuperior = this.paginaActual * amplitud <= this.lista.Count ? this.paginaActual * this.amplitud : this.lista.Count - 1;

            return this.ObtenerListaEntreLimites(this.actualInferior, this.actualSuperior);
        }

        private int CalcularCantidadPaginas(int cantidadElementos, int amplitud)
        {
            int siguienteEntero = (int)Math.Truncate((double)(cantidadElementos / amplitud)) + 1;

            int cantidad = cantidadElementos % amplitud == 0 ? cantidadElementos / amplitud : siguienteEntero;
            return cantidad;
        }

        private BindingList<ActividadEnsamble> ObtenerListaEntreLimites(int limiteInf, int limiteSup)
        {
            BindingList<ActividadEnsamble> listaAux = new BindingList<ActividadEnsamble>();

            for (var i = limiteInf; i < limiteSup; i++)
            {
                listaAux.Add(this.lista[i]);
            }
            return listaAux;
        }
    }
}
