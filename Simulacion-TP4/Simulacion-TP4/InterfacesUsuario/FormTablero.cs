using MathNet.Numerics.Distributions;
using Simulacion.Entidades;
using Simulacion.Entidades.Interfaces;
using Simulacion.Entidades.Randoms;
using Simulacion.Entidades.Utiles;
using Simulacion_TP4.Controlador;
using Simulacion_TP4.Entidades;
using Simulacion_TP4.Entidades.Montecarlo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_TP4.InterfacesUsuario
{
    public partial class FormTablero : Form
    {
        /// <summary>
        /// Valor por defecto del input 'Semilla'
        /// </summary>
        private static readonly int DEFAULT_SEMILLA = 37;

        /// <summary>
        /// Valor por defecto del input 'Constante Multiplicativa'
        /// </summary>
        private static readonly int DEFAULT_CONSTANTE_MULTIPLICATIVA = 19;

        /// <summary>
        /// Valor por defecto del input 'Constante Independiente'
        /// </summary>
        private static readonly int DEFAULT_CONSTANTE_INDEPENDIENTE = 7;

        /// <summary>
        /// Valor por defecto del input 'Modulo'
        /// </summary>
        private static readonly int DEFAULT_MODULO = 53;

        /// <summary>
        /// Valor por defecto del input 'Modulo'
        /// </summary>
        private static readonly int DEFAULT_DESV_EST = 1;

        /// <summary>
        /// Valor por defecto del input 'Modulo'
        /// </summary>
        private static readonly int DEFAULT_MEDIA = 0;


        /// <summary>
        /// Valores por defecto de parametros VA de tiempo de actividades
        /// </summary>
        private static readonly int DEFAULT_A_T1 = 20;
        private static readonly int DEFAULT_B_T1 = 30;
        private static readonly int DEFAULT_A_T2 = 30;
        private static readonly int DEFAULT_B_T2 = 50;
        private static readonly double DEFAULT_MEDIA_T3 = 30d;
        private static readonly int DEFAULT_A_T4 = 10;
        private static readonly int DEFAULT_B_T4 = 20;
        private static readonly double DEFAULT_MEDIA_T5 = 5d;


        private SimulacionMontecarloController controlador;

        private BindingList<ActividadEnsamble> lista;

        private Paginador paginador;

        public FormTablero()
        {
            InitializeComponent();
            this.inicializarComponentes();
            this.inicializarGrillaActividades();
            this.inicializarGrillaSimulacion();
        }

        private void inicializarComponentes()
        {
            this.dgvSimulacion.AutoGenerateColumns = false;
            this.cargarCombos();
            this.btnReiniciar.Enabled = false;
        }

        private void inicializarGrillaActividades()
        {
            DataTable dtActividades = new DataTable();
            dtActividades.Columns.Add("TAREA");
            dtActividades.Columns.Add("DISTR");
            dtActividades.Columns.Add("PARAM1");
            dtActividades.Columns.Add("PARAM2");
            dtActividades.Rows.Add(1, "UNIFORME", 20, 30);
            dtActividades.Rows.Add(2, "UNIFORME", 30, 50);
            dtActividades.Rows.Add(3, "EXPONENCIAL", "MEDIA", 3);
            dtActividades.Rows.Add(4, "UNIFORME", 10, 20);
            dtActividades.Rows.Add(5, "EXPONENCIAL", "MEDIA", 5);

            BindingSource SBind = new BindingSource();
            SBind.DataSource = dtActividades;
            dgvActividades.Columns.Clear();
            dgvActividades.DataSource = SBind;

            dgvActividades.Columns["TAREA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvActividades.Columns["DISTR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvActividades.Columns["PARAM2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvActividades.AllowUserToAddRows = false;
        }

        private void inicializarGrillaSimulacion()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvSimulacion.ColumnCount = 20;
            dgvSimulacion.ColumnHeadersVisible = true;
            dgvSimulacion.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvSimulacion.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvSimulacion.Columns[0].Name = "Iteraci??n";
            dgvSimulacion.Columns[0].DataPropertyName = "Orden";
            // Definimos el ancho de la columna.

            dgvSimulacion.Columns[1].Name = "Rnd1";
            dgvSimulacion.Columns[1].DataPropertyName = "RndT1";
            dgvSimulacion.Columns[2].Name = "T1";
            dgvSimulacion.Columns[2].DataPropertyName = "TiempoT1";
            dgvSimulacion.Columns[3].Name = "Atraso T1";
            dgvSimulacion.Columns[3].DataPropertyName = "TiempoAtrasoPosibleT1";
            dgvSimulacion.Columns[4].Name = "Rnd2";
            dgvSimulacion.Columns[4].DataPropertyName = "RndT2";
            dgvSimulacion.Columns[5].Name = "T2";
            dgvSimulacion.Columns[5].DataPropertyName = "TiempoT2";
            dgvSimulacion.Columns[6].Name = "Atraso T2";
            dgvSimulacion.Columns[6].DataPropertyName = "TiempoAtrasoPosibleT2";
            dgvSimulacion.Columns[7].Name = "Rnd3";
            dgvSimulacion.Columns[7].DataPropertyName = "RndT3";
            dgvSimulacion.Columns[8].Name = "T3";
            dgvSimulacion.Columns[8].DataPropertyName = "TiempoT3";
            dgvSimulacion.Columns[9].Name = "Atraso T3";
            dgvSimulacion.Columns[9].DataPropertyName = "TiempoAtrasoPosibleT3";
            dgvSimulacion.Columns[10].Name = "Rnd4";
            dgvSimulacion.Columns[10].DataPropertyName = "RndT4";
            dgvSimulacion.Columns[11].Name = "T4";
            dgvSimulacion.Columns[11].DataPropertyName = "TiempoT4";
            dgvSimulacion.Columns[12].Name = "Atraso T4";
            dgvSimulacion.Columns[12].DataPropertyName = "TiempoAtrasoPosibleT4";
            dgvSimulacion.Columns[13].Name = "Rnd5";
            dgvSimulacion.Columns[13].DataPropertyName = "RndT5";
            dgvSimulacion.Columns[14].Name = "T5";
            dgvSimulacion.Columns[14].DataPropertyName = "TiempoT5";
            dgvSimulacion.Columns[15].Name = "Atraso T5";
            dgvSimulacion.Columns[15].DataPropertyName = "TiempoAtrasoPosibleT5";
            dgvSimulacion.Columns[16].Name = "Tiempo total";
            dgvSimulacion.Columns[16].DataPropertyName = "TiempoTotal";
            dgvSimulacion.Columns[17].Name = "Acumulado";
            dgvSimulacion.Columns[17].DataPropertyName = "AcumuladoTiempoTotal";
            dgvSimulacion.Columns[18].Name = "Promedio";
            dgvSimulacion.Columns[18].DataPropertyName = "PromedioAcumuladoTiempoTotal";
            dgvSimulacion.Columns[19].Name = "Camino Critico";
            dgvSimulacion.Columns[19].DataPropertyName = "CaminoCritico";

            // Cambia el tama??o de la altura de los encabezados de columna.
            dgvSimulacion.AutoResizeColumnHeadersHeight();

            // Cambia el tama??o de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvSimulacion.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            dgvSimulacion.AllowUserToAddRows = false;
        }

        private void cargarCombos()
        {
            IList<KeyValuePair<int, string>> metodosRnd = new List<KeyValuePair<int, string>>();
            metodosRnd.Add(new KeyValuePair<int, string>(3, "Provisto por lenguaje"));
            metodosRnd.Add(new KeyValuePair<int, string>(2, "Congruencial mixto"));
            metodosRnd.Add(new KeyValuePair<int, string>(1, "Congruencial multiplicativo"));
            metodosRnd.Add(new KeyValuePair<int, string>(0, "Congruencial aditivo"));

            this.cboMetodoRandom.DataSource = metodosRnd;
            this.cboMetodoRandom.ValueMember = "Key";
            this.cboMetodoRandom.DisplayMember = "Value";
            this.cboMetodoRandom.SelectedValue = 3;
        }

        private void Reiniciar()
        {

        }

        private bool validarControlesRandom()
        {
            if((int)cboMetodoRandom.SelectedValue < 3)
            return (txtA.Value != 0 && txtModulo.Value != 0);
            return true;
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!validarControlesRandom())
            {
                MessageBox.Show("Parametros de generador de randoms incorrectos");
                return;
            }
            
            this.reiniciar();

            var generador = this.getGeneradorRandom();

            this.chartEvolucionPromedio.Series[0].Points.Clear();

            var vA1 = new GeneradorVAUniforme(generador, DEFAULT_A_T1, DEFAULT_B_T1);
            var vA2 = new GeneradorVAUniforme(generador, DEFAULT_A_T2, DEFAULT_B_T2);
            var vA3 = new GeneradorVAExponencialNegativa(generador, 1d/DEFAULT_MEDIA_T3);
            var vA4 = new GeneradorVAUniforme(generador, DEFAULT_A_T4, DEFAULT_B_T4);
            var vA5 = new GeneradorVAExponencialNegativa(generador, 1d/DEFAULT_MEDIA_T5);

            this.lista = new BindingList<ActividadEnsamble>();

            this.controlador = new SimulacionMontecarloController(this.lista, vA1, vA2, vA3, vA4, vA5);
            
            this.controlador.generarSimulacion((double)this.txtCantidad.Value, this.progressBar, this.chartEvolucionPromedio);

            double maximo = this.controlador.montecarloService.TiempoMaximo;
            double minimo = this.controlador.montecarloService.TiempoMinimo;
            double promedio = this.controlador.montecarloService.TiempoPromedioActividades;
            this.inputMaximo.Value = (decimal) maximo;
            this.inputMinimo.Value = (decimal) minimo;
            this.inputPromedio.Value = (decimal) promedio;

            double media = this.controlador.montecarloService.EstadoActual.PromedioAcumuladoTiempoTotal;
            double varianza = Math.Sqrt(this.controlador.montecarloService.EstadoActual.Varianza);
            this.inputConfianza90.Value = (decimal) Normal.InvCDF(media, varianza, 0.9d);

            this.inputProbabilidadCaminoCritico1.Value = (decimal) this.controlador.montecarloService.EstadoActual.ProbabilidadCaminoCritico1;
            this.inputProbabilidadCaminoCritico2.Value = (decimal) this.controlador.montecarloService.EstadoActual.ProbabilidadCaminoCritico2;
            this.inputProbabilidadCaminoCritico3.Value = (decimal) this.controlador.montecarloService.EstadoActual.ProbabilidadCaminoCritico3;

            this.paginador = new Paginador(this.lista, 20);

            this.dgvSimulacion.DataSource = this.paginador.ObtenerPrimerPagina();
            this.dgvSimulacion.FirstDisplayedScrollingRowIndex = this.dgvSimulacion.Rows.Count - 1;

            this.progressBar.Value = 0;
        }

        private IGeneradorRandom getGeneradorRandom()
        {
            switch (this.cboMetodoRandom.SelectedValue)
            {
                case 3:
                    return new MetodoLenguaje();
                case 2:
                    return new MetodoCongruencialMixtoMultiplicativo((double)this.txtA.Value, (double)this.txtC.Value, (double)this.txtModulo.Value, (double)this.txtSemilla.Value);
                case 1:
                    return new MetodoCongruencialMixtoMultiplicativo((double)this.txtA.Value, (double)this.txtModulo.Value, (double)this.txtSemilla.Value);
                case 0:
                    return new MetodoCongruencialAditivo((double)this.txtA.Value, (double)this.txtC.Value, (double)this.txtModulo.Value, (double)this.txtSemilla.Value);
                default:
                    return null;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.reiniciar();
        }

        private void reiniciar()
        {
        }


        private void cboMetodoRandom_SelectedValueChanged(object sender, EventArgs e)
        {

            switch (this.cboMetodoRandom.SelectedValue)
            {
                case 3:
                    this.txtA.Enabled = false;
                    this.txtC.Enabled = false;
                    this.txtModulo.Enabled = false;
                    this.txtSemilla.Enabled = false;
                    break;
                default:
                    this.txtA.Enabled = true;
                    this.txtC.Enabled = true;
                    this.txtModulo.Enabled = true;
                    this.txtSemilla.Enabled = true;
                    break;
            }
        }

        private void btnPrimeraPagina_Click(object sender, EventArgs e)
        {
            if (this.paginador != null)
            {
                this.dgvSimulacion.DataSource = this.paginador.ObtenerPrimerPagina();
                this.dgvSimulacion.FirstDisplayedScrollingRowIndex = 0;
            }
        }

        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (this.paginador != null)
            {
                BindingList<ActividadEnsamble> aux = this.paginador.ObtenerPaginaAnterior();

                this.dgvSimulacion.DataSource = aux is null ? this.dgvSimulacion.DataSource : aux;
                this.dgvSimulacion.FirstDisplayedScrollingRowIndex = 0;
            }
        }

        private void btnPaginaSiguiente_Click(object sender, EventArgs e)
        {
            if (this.paginador != null)
            {
                BindingList<ActividadEnsamble> aux = this.paginador.ObtenerPaginaSiguiente();

                this.dgvSimulacion.DataSource = aux is null ? this.dgvSimulacion.DataSource : aux;
                this.dgvSimulacion.FirstDisplayedScrollingRowIndex = 0;
            }
        }

        private void btnUltimaPagina_Click(object sender, EventArgs e)
        {
            if (this.paginador != null)
            {
                this.dgvSimulacion.DataSource = this.paginador.ObtenerUltimaPagina();
                this.dgvSimulacion.FirstDisplayedScrollingRowIndex = 0;
            }
        }

        private void btnBuscarPagina_Click(object sender, EventArgs e)
        {
            if (this.paginador != null)
            {
                BindingList<ActividadEnsamble> aux = this.paginador.BuscarPaginaXIndice(Convert.ToInt32(txtBuscarPagina.Value.ToString()) - 1);

                if (aux is null)
                {
                    MessageBox.Show("Fuera de rango. Total items: " + this.lista.Count);
                    return;
                }

                this.dgvSimulacion.DataSource = aux;
                this.dgvSimulacion.FirstDisplayedScrollingRowIndex = 0;
            }
        }
    }
}
