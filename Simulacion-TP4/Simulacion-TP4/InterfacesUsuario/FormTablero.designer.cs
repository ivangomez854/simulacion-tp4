namespace Simulacion_TP4.InterfacesUsuario
{
    partial class FormTablero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTablero));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbRandom = new System.Windows.Forms.GroupBox();
            this.txtSemilla = new System.Windows.Forms.NumericUpDown();
            this.txtModulo = new System.Windows.Forms.NumericUpDown();
            this.txtC = new System.Windows.Forms.NumericUpDown();
            this.txtA = new System.Windows.Forms.NumericUpDown();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.lblModulo = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.cboMetodoRandom = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.btnBuscarPagina = new System.Windows.Forms.Button();
            this.txtBuscarPagina = new System.Windows.Forms.NumericUpDown();
            this.btnPaginaAnterior = new System.Windows.Forms.Button();
            this.btnPaginaSiguiente = new System.Windows.Forms.Button();
            this.btnUltimaPagina = new System.Windows.Forms.Button();
            this.btnPrimeraPagina = new System.Windows.Forms.Button();
            this.dgvSimulacion = new System.Windows.Forms.DataGridView();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.lblCaminoCritico1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputProbabilidadCaminoCritico3 = new System.Windows.Forms.NumericUpDown();
            this.lblProbabilidadCaminoCritico3 = new System.Windows.Forms.Label();
            this.lblCaminoCritico3 = new System.Windows.Forms.Label();
            this.inputProbabilidadCaminoCritico2 = new System.Windows.Forms.NumericUpDown();
            this.lblProbabilidadCaminoCritico2 = new System.Windows.Forms.Label();
            this.lblCaminoCritico2 = new System.Windows.Forms.Label();
            this.inputProbabilidadCaminoCritico1 = new System.Windows.Forms.NumericUpDown();
            this.lblProbabilidadCaminoCritico1 = new System.Windows.Forms.Label();
            this.chartEvolucionPromedio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblConfianza90 = new System.Windows.Forms.Label();
            this.inputConfianza90 = new System.Windows.Forms.NumericUpDown();
            this.gbTiempos = new System.Windows.Forms.GroupBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.inputPromedio = new System.Windows.Forms.NumericUpDown();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.inputMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.inputMaximo = new System.Windows.Forms.NumericUpDown();
            this.gbRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputProbabilidadCaminoCritico3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputProbabilidadCaminoCritico2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputProbabilidadCaminoCritico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolucionPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputConfianza90)).BeginInit();
            this.gbTiempos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMaximo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRandom
            // 
            this.gbRandom.Controls.Add(this.txtSemilla);
            this.gbRandom.Controls.Add(this.txtModulo);
            this.gbRandom.Controls.Add(this.txtC);
            this.gbRandom.Controls.Add(this.txtA);
            this.gbRandom.Controls.Add(this.lblSemilla);
            this.gbRandom.Controls.Add(this.lblModulo);
            this.gbRandom.Controls.Add(this.lblC);
            this.gbRandom.Controls.Add(this.lblA);
            this.gbRandom.Controls.Add(this.cboMetodoRandom);
            this.gbRandom.Location = new System.Drawing.Point(10, 27);
            this.gbRandom.Name = "gbRandom";
            this.gbRandom.Size = new System.Drawing.Size(561, 106);
            this.gbRandom.TabIndex = 0;
            this.gbRandom.TabStop = false;
            this.gbRandom.Text = "Random";
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(434, 76);
            this.txtSemilla.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(120, 20);
            this.txtSemilla.TabIndex = 9;
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(287, 76);
            this.txtModulo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(120, 20);
            this.txtModulo.TabIndex = 8;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(146, 76);
            this.txtC.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(120, 20);
            this.txtC.TabIndex = 7;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(6, 76);
            this.txtA.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(120, 20);
            this.txtA.TabIndex = 6;
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Location = new System.Drawing.Point(431, 60);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(65, 13);
            this.lblSemilla.TabIndex = 4;
            this.lblSemilla.Text = "Valor semilla";
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(284, 60);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(63, 13);
            this.lblModulo.TabIndex = 3;
            this.lblModulo.Text = "Cte. módulo";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(143, 60);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(106, 13);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Cte. independiente C";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(6, 60);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(101, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Cte. multiiplicativa A";
            // 
            // cboMetodoRandom
            // 
            this.cboMetodoRandom.FormattingEnabled = true;
            this.cboMetodoRandom.Location = new System.Drawing.Point(6, 31);
            this.cboMetodoRandom.Name = "cboMetodoRandom";
            this.cboMetodoRandom.Size = new System.Drawing.Size(160, 21);
            this.cboMetodoRandom.TabIndex = 0;
            this.cboMetodoRandom.SelectedValueChanged += new System.EventHandler(this.cboMetodoRandom_SelectedValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(97, 26);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1379, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem2});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(60, 20);
            this.menu.Text = "Archivo";
            // 
            // salirToolStripMenuItem2
            // 
            this.salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
            this.salirToolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem2.Text = "Salir";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 143);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(16, 159);
            this.txtCantidad.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(106, 20);
            this.txtCantidad.TabIndex = 21;
            this.txtCantidad.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.Location = new System.Drawing.Point(15, 186);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnGenerar.Size = new System.Drawing.Size(107, 44);
            this.btnGenerar.TabIndex = 22;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnReiniciar.Image")));
            this.btnReiniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReiniciar.Location = new System.Drawing.Point(15, 236);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnReiniciar.Size = new System.Drawing.Size(107, 44);
            this.btnReiniciar.TabIndex = 23;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1379, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // btnBuscarPagina
            // 
            this.btnBuscarPagina.Location = new System.Drawing.Point(1314, 360);
            this.btnBuscarPagina.Name = "btnBuscarPagina";
            this.btnBuscarPagina.Size = new System.Drawing.Size(52, 23);
            this.btnBuscarPagina.TabIndex = 37;
            this.btnBuscarPagina.Text = "Buscar";
            this.btnBuscarPagina.UseVisualStyleBackColor = true;
            this.btnBuscarPagina.Click += new System.EventHandler(this.btnBuscarPagina_Click);
            // 
            // txtBuscarPagina
            // 
            this.txtBuscarPagina.Location = new System.Drawing.Point(1212, 363);
            this.txtBuscarPagina.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtBuscarPagina.Name = "txtBuscarPagina";
            this.txtBuscarPagina.Size = new System.Drawing.Size(96, 20);
            this.txtBuscarPagina.TabIndex = 36;
            // 
            // btnPaginaAnterior
            // 
            this.btnPaginaAnterior.Location = new System.Drawing.Point(1104, 360);
            this.btnPaginaAnterior.Name = "btnPaginaAnterior";
            this.btnPaginaAnterior.Size = new System.Drawing.Size(30, 23);
            this.btnPaginaAnterior.TabIndex = 35;
            this.btnPaginaAnterior.Text = "<";
            this.btnPaginaAnterior.UseVisualStyleBackColor = true;
            this.btnPaginaAnterior.Click += new System.EventHandler(this.btnPaginaAnterior_Click);
            // 
            // btnPaginaSiguiente
            // 
            this.btnPaginaSiguiente.Location = new System.Drawing.Point(1140, 360);
            this.btnPaginaSiguiente.Name = "btnPaginaSiguiente";
            this.btnPaginaSiguiente.Size = new System.Drawing.Size(30, 23);
            this.btnPaginaSiguiente.TabIndex = 34;
            this.btnPaginaSiguiente.Text = ">";
            this.btnPaginaSiguiente.UseVisualStyleBackColor = true;
            this.btnPaginaSiguiente.Click += new System.EventHandler(this.btnPaginaSiguiente_Click);
            // 
            // btnUltimaPagina
            // 
            this.btnUltimaPagina.Location = new System.Drawing.Point(1176, 360);
            this.btnUltimaPagina.Name = "btnUltimaPagina";
            this.btnUltimaPagina.Size = new System.Drawing.Size(30, 23);
            this.btnUltimaPagina.TabIndex = 33;
            this.btnUltimaPagina.Text = ">|";
            this.btnUltimaPagina.UseVisualStyleBackColor = true;
            this.btnUltimaPagina.Click += new System.EventHandler(this.btnUltimaPagina_Click);
            // 
            // btnPrimeraPagina
            // 
            this.btnPrimeraPagina.Location = new System.Drawing.Point(1068, 360);
            this.btnPrimeraPagina.Name = "btnPrimeraPagina";
            this.btnPrimeraPagina.Size = new System.Drawing.Size(30, 23);
            this.btnPrimeraPagina.TabIndex = 32;
            this.btnPrimeraPagina.Text = "|<";
            this.btnPrimeraPagina.UseVisualStyleBackColor = true;
            this.btnPrimeraPagina.Click += new System.EventHandler(this.btnPrimeraPagina_Click);
            // 
            // dgvSimulacion
            // 
            this.dgvSimulacion.AllowUserToAddRows = false;
            this.dgvSimulacion.AllowUserToDeleteRows = false;
            this.dgvSimulacion.AllowUserToResizeColumns = false;
            this.dgvSimulacion.AllowUserToResizeRows = false;
            this.dgvSimulacion.CausesValidation = false;
            this.dgvSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulacion.Location = new System.Drawing.Point(577, 27);
            this.dgvSimulacion.Name = "dgvSimulacion";
            this.dgvSimulacion.ReadOnly = true;
            this.dgvSimulacion.Size = new System.Drawing.Size(790, 325);
            this.dgvSimulacion.TabIndex = 0;
            // 
            // dgvActividades
            // 
            this.dgvActividades.AllowUserToAddRows = false;
            this.dgvActividades.AllowUserToOrderColumns = true;
            this.dgvActividades.AllowUserToResizeColumns = false;
            this.dgvActividades.AllowUserToResizeRows = false;
            this.dgvActividades.CausesValidation = false;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(196, 139);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.Size = new System.Drawing.Size(375, 141);
            this.dgvActividades.TabIndex = 38;
            // 
            // lblCaminoCritico1
            // 
            this.lblCaminoCritico1.AutoSize = true;
            this.lblCaminoCritico1.Location = new System.Drawing.Point(6, 31);
            this.lblCaminoCritico1.Name = "lblCaminoCritico1";
            this.lblCaminoCritico1.Size = new System.Drawing.Size(126, 13);
            this.lblCaminoCritico1.TabIndex = 39;
            this.lblCaminoCritico1.Text = "Camino 1: A1 -> A4 -> A5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputProbabilidadCaminoCritico3);
            this.groupBox1.Controls.Add(this.lblProbabilidadCaminoCritico3);
            this.groupBox1.Controls.Add(this.lblCaminoCritico3);
            this.groupBox1.Controls.Add(this.inputProbabilidadCaminoCritico2);
            this.groupBox1.Controls.Add(this.lblProbabilidadCaminoCritico2);
            this.groupBox1.Controls.Add(this.lblCaminoCritico2);
            this.groupBox1.Controls.Add(this.inputProbabilidadCaminoCritico1);
            this.groupBox1.Controls.Add(this.lblProbabilidadCaminoCritico1);
            this.groupBox1.Controls.Add(this.lblCaminoCritico1);
            this.groupBox1.Location = new System.Drawing.Point(10, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 226);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Probabilidades de Criticidad de Caminos";
            // 
            // inputProbabilidadCaminoCritico3
            // 
            this.inputProbabilidadCaminoCritico3.DecimalPlaces = 4;
            this.inputProbabilidadCaminoCritico3.Enabled = false;
            this.inputProbabilidadCaminoCritico3.Location = new System.Drawing.Point(80, 168);
            this.inputProbabilidadCaminoCritico3.Name = "inputProbabilidadCaminoCritico3";
            this.inputProbabilidadCaminoCritico3.Size = new System.Drawing.Size(120, 20);
            this.inputProbabilidadCaminoCritico3.TabIndex = 47;
            // 
            // lblProbabilidadCaminoCritico3
            // 
            this.lblProbabilidadCaminoCritico3.AutoSize = true;
            this.lblProbabilidadCaminoCritico3.Location = new System.Drawing.Point(6, 170);
            this.lblProbabilidadCaminoCritico3.Name = "lblProbabilidadCaminoCritico3";
            this.lblProbabilidadCaminoCritico3.Size = new System.Drawing.Size(68, 13);
            this.lblProbabilidadCaminoCritico3.TabIndex = 46;
            this.lblProbabilidadCaminoCritico3.Text = "Probabilidad:";
            // 
            // lblCaminoCritico3
            // 
            this.lblCaminoCritico3.AutoSize = true;
            this.lblCaminoCritico3.Location = new System.Drawing.Point(6, 146);
            this.lblCaminoCritico3.Name = "lblCaminoCritico3";
            this.lblCaminoCritico3.Size = new System.Drawing.Size(70, 13);
            this.lblCaminoCritico3.TabIndex = 45;
            this.lblCaminoCritico3.Text = "Camino 3: A3";
            // 
            // inputProbabilidadCaminoCritico2
            // 
            this.inputProbabilidadCaminoCritico2.DecimalPlaces = 4;
            this.inputProbabilidadCaminoCritico2.Enabled = false;
            this.inputProbabilidadCaminoCritico2.Location = new System.Drawing.Point(80, 112);
            this.inputProbabilidadCaminoCritico2.Name = "inputProbabilidadCaminoCritico2";
            this.inputProbabilidadCaminoCritico2.Size = new System.Drawing.Size(120, 20);
            this.inputProbabilidadCaminoCritico2.TabIndex = 44;
            // 
            // lblProbabilidadCaminoCritico2
            // 
            this.lblProbabilidadCaminoCritico2.AutoSize = true;
            this.lblProbabilidadCaminoCritico2.Location = new System.Drawing.Point(6, 114);
            this.lblProbabilidadCaminoCritico2.Name = "lblProbabilidadCaminoCritico2";
            this.lblProbabilidadCaminoCritico2.Size = new System.Drawing.Size(68, 13);
            this.lblProbabilidadCaminoCritico2.TabIndex = 43;
            this.lblProbabilidadCaminoCritico2.Text = "Probabilidad:";
            // 
            // lblCaminoCritico2
            // 
            this.lblCaminoCritico2.AutoSize = true;
            this.lblCaminoCritico2.Location = new System.Drawing.Point(6, 90);
            this.lblCaminoCritico2.Name = "lblCaminoCritico2";
            this.lblCaminoCritico2.Size = new System.Drawing.Size(98, 13);
            this.lblCaminoCritico2.TabIndex = 42;
            this.lblCaminoCritico2.Text = "Camino 2: A2 -> A5";
            // 
            // inputProbabilidadCaminoCritico1
            // 
            this.inputProbabilidadCaminoCritico1.DecimalPlaces = 4;
            this.inputProbabilidadCaminoCritico1.Enabled = false;
            this.inputProbabilidadCaminoCritico1.Location = new System.Drawing.Point(80, 53);
            this.inputProbabilidadCaminoCritico1.Name = "inputProbabilidadCaminoCritico1";
            this.inputProbabilidadCaminoCritico1.Size = new System.Drawing.Size(120, 20);
            this.inputProbabilidadCaminoCritico1.TabIndex = 41;
            // 
            // lblProbabilidadCaminoCritico1
            // 
            this.lblProbabilidadCaminoCritico1.AutoSize = true;
            this.lblProbabilidadCaminoCritico1.Location = new System.Drawing.Point(6, 55);
            this.lblProbabilidadCaminoCritico1.Name = "lblProbabilidadCaminoCritico1";
            this.lblProbabilidadCaminoCritico1.Size = new System.Drawing.Size(68, 13);
            this.lblProbabilidadCaminoCritico1.TabIndex = 40;
            this.lblProbabilidadCaminoCritico1.Text = "Probabilidad:";
            // 
            // chartEvolucionPromedio
            // 
            chartArea2.Name = "ChartArea1";
            this.chartEvolucionPromedio.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEvolucionPromedio.Legends.Add(legend2);
            this.chartEvolucionPromedio.Location = new System.Drawing.Point(230, 360);
            this.chartEvolucionPromedio.Name = "chartEvolucionPromedio";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Promedio";
            this.chartEvolucionPromedio.Series.Add(series2);
            this.chartEvolucionPromedio.Size = new System.Drawing.Size(822, 288);
            this.chartEvolucionPromedio.TabIndex = 41;
            this.chartEvolucionPromedio.Text = "chart1";
            // 
            // lblConfianza90
            // 
            this.lblConfianza90.AutoSize = true;
            this.lblConfianza90.Location = new System.Drawing.Point(6, 138);
            this.lblConfianza90.Name = "lblConfianza90";
            this.lblConfianza90.Size = new System.Drawing.Size(147, 13);
            this.lblConfianza90.TabIndex = 42;
            this.lblConfianza90.Text = "Fecha con confianza del 90%";
            // 
            // inputConfianza90
            // 
            this.inputConfianza90.DecimalPlaces = 2;
            this.inputConfianza90.Enabled = false;
            this.inputConfianza90.Location = new System.Drawing.Point(9, 154);
            this.inputConfianza90.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.inputConfianza90.Name = "inputConfianza90";
            this.inputConfianza90.Size = new System.Drawing.Size(120, 20);
            this.inputConfianza90.TabIndex = 43;
            // 
            // gbTiempos
            // 
            this.gbTiempos.Controls.Add(this.lblPromedio);
            this.gbTiempos.Controls.Add(this.inputPromedio);
            this.gbTiempos.Controls.Add(this.lblMinimo);
            this.gbTiempos.Controls.Add(this.inputMinimo);
            this.gbTiempos.Controls.Add(this.lblMaximo);
            this.gbTiempos.Controls.Add(this.inputMaximo);
            this.gbTiempos.Controls.Add(this.lblConfianza90);
            this.gbTiempos.Controls.Add(this.inputConfianza90);
            this.gbTiempos.Location = new System.Drawing.Point(1068, 395);
            this.gbTiempos.Name = "gbTiempos";
            this.gbTiempos.Size = new System.Drawing.Size(200, 181);
            this.gbTiempos.TabIndex = 44;
            this.gbTiempos.TabStop = false;
            this.gbTiempos.Text = "Tiempos";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(6, 99);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(51, 13);
            this.lblPromedio.TabIndex = 48;
            this.lblPromedio.Text = "Promedio";
            // 
            // inputPromedio
            // 
            this.inputPromedio.DecimalPlaces = 2;
            this.inputPromedio.Enabled = false;
            this.inputPromedio.Location = new System.Drawing.Point(9, 115);
            this.inputPromedio.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.inputPromedio.Name = "inputPromedio";
            this.inputPromedio.Size = new System.Drawing.Size(120, 20);
            this.inputPromedio.TabIndex = 49;
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(6, 60);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(40, 13);
            this.lblMinimo.TabIndex = 46;
            this.lblMinimo.Text = "Minimo";
            // 
            // inputMinimo
            // 
            this.inputMinimo.DecimalPlaces = 2;
            this.inputMinimo.Enabled = false;
            this.inputMinimo.Location = new System.Drawing.Point(9, 76);
            this.inputMinimo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.inputMinimo.Name = "inputMinimo";
            this.inputMinimo.Size = new System.Drawing.Size(120, 20);
            this.inputMinimo.TabIndex = 47;
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(6, 21);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(43, 13);
            this.lblMaximo.TabIndex = 44;
            this.lblMaximo.Text = "Maximo";
            // 
            // inputMaximo
            // 
            this.inputMaximo.DecimalPlaces = 2;
            this.inputMaximo.Enabled = false;
            this.inputMaximo.Location = new System.Drawing.Point(9, 37);
            this.inputMaximo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.inputMaximo.Name = "inputMaximo";
            this.inputMaximo.Size = new System.Drawing.Size(120, 20);
            this.inputMaximo.TabIndex = 45;
            // 
            // FormTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 685);
            this.Controls.Add(this.gbTiempos);
            this.Controls.Add(this.chartEvolucionPromedio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.btnBuscarPagina);
            this.Controls.Add(this.txtBuscarPagina);
            this.Controls.Add(this.btnPaginaAnterior);
            this.Controls.Add(this.btnPaginaSiguiente);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUltimaPagina);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnPrimeraPagina);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.gbRandom);
            this.Controls.Add(this.dgvSimulacion);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1364, 724);
            this.Name = "FormTablero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTablero";
            this.gbRandom.ResumeLayout(false);
            this.gbRandom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputProbabilidadCaminoCritico3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputProbabilidadCaminoCritico2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputProbabilidadCaminoCritico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolucionPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputConfianza90)).EndInit();
            this.gbTiempos.ResumeLayout(false);
            this.gbTiempos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMaximo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRandom;
        private System.Windows.Forms.ComboBox cboMetodoRandom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem2;
        private System.Windows.Forms.NumericUpDown txtSemilla;
        private System.Windows.Forms.NumericUpDown txtModulo;
        private System.Windows.Forms.NumericUpDown txtC;
        private System.Windows.Forms.NumericUpDown txtA;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.DataGridView dgvSimulacion;
        private System.Windows.Forms.Button btnBuscarPagina;
        private System.Windows.Forms.NumericUpDown txtBuscarPagina;
        private System.Windows.Forms.Button btnPaginaAnterior;
        private System.Windows.Forms.Button btnPaginaSiguiente;
        private System.Windows.Forms.Button btnUltimaPagina;
        private System.Windows.Forms.Button btnPrimeraPagina;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label lblCaminoCritico1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown inputProbabilidadCaminoCritico3;
        private System.Windows.Forms.Label lblProbabilidadCaminoCritico3;
        private System.Windows.Forms.Label lblCaminoCritico3;
        private System.Windows.Forms.NumericUpDown inputProbabilidadCaminoCritico2;
        private System.Windows.Forms.Label lblProbabilidadCaminoCritico2;
        private System.Windows.Forms.Label lblCaminoCritico2;
        private System.Windows.Forms.NumericUpDown inputProbabilidadCaminoCritico1;
        private System.Windows.Forms.Label lblProbabilidadCaminoCritico1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEvolucionPromedio;
        private System.Windows.Forms.Label lblConfianza90;
        private System.Windows.Forms.NumericUpDown inputConfianza90;
        private System.Windows.Forms.GroupBox gbTiempos;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.NumericUpDown inputPromedio;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.NumericUpDown inputMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.NumericUpDown inputMaximo;
    }
}