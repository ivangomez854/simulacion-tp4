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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuscarPagina = new System.Windows.Forms.Button();
            this.txtBuscarPagina = new System.Windows.Forms.NumericUpDown();
            this.btnPaginaAnterior = new System.Windows.Forms.Button();
            this.btnPaginaSiguiente = new System.Windows.Forms.Button();
            this.btnUltimaPagina = new System.Windows.Forms.Button();
            this.btnPrimeraPagina = new System.Windows.Forms.Button();
            this.pnlFrecuenciaEsperada = new System.Windows.Forms.Panel();
            this.pnlFrecuenciaObservada = new System.Windows.Forms.Panel();
            this.lblFrecuenciaObservada = new System.Windows.Forms.Label();
            this.lblFrecuenciaEsperada = new System.Windows.Forms.Label();
            this.gbIntervalos = new System.Windows.Forms.GroupBox();
            this.lblCantidadIntervalos = new System.Windows.Forms.Label();
            this.btnGenerarIntervalos = new System.Windows.Forms.Button();
            this.txtCantidadIntervalos = new System.Windows.Forms.NumericUpDown();
            this.btnAutocalcular = new System.Windows.Forms.Button();
            this.dgvSimulacion = new System.Windows.Forms.DataGridView();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
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
            this.gbIntervalos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadIntervalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
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
            10000000,
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(428, 516);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 12);
            this.flowLayoutPanel1.TabIndex = 25;
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
            // pnlFrecuenciaEsperada
            // 
            this.pnlFrecuenciaEsperada.BackColor = System.Drawing.Color.Maroon;
            this.pnlFrecuenciaEsperada.Location = new System.Drawing.Point(397, 387);
            this.pnlFrecuenciaEsperada.Name = "pnlFrecuenciaEsperada";
            this.pnlFrecuenciaEsperada.Size = new System.Drawing.Size(24, 23);
            this.pnlFrecuenciaEsperada.TabIndex = 31;
            this.pnlFrecuenciaEsperada.Visible = false;
            // 
            // pnlFrecuenciaObservada
            // 
            this.pnlFrecuenciaObservada.BackColor = System.Drawing.Color.Green;
            this.pnlFrecuenciaObservada.Location = new System.Drawing.Point(397, 354);
            this.pnlFrecuenciaObservada.Name = "pnlFrecuenciaObservada";
            this.pnlFrecuenciaObservada.Size = new System.Drawing.Size(24, 23);
            this.pnlFrecuenciaObservada.TabIndex = 30;
            this.pnlFrecuenciaObservada.Visible = false;
            // 
            // lblFrecuenciaObservada
            // 
            this.lblFrecuenciaObservada.AutoSize = true;
            this.lblFrecuenciaObservada.Location = new System.Drawing.Point(276, 360);
            this.lblFrecuenciaObservada.Name = "lblFrecuenciaObservada";
            this.lblFrecuenciaObservada.Size = new System.Drawing.Size(115, 13);
            this.lblFrecuenciaObservada.TabIndex = 29;
            this.lblFrecuenciaObservada.Text = "Frecuencia Observada";
            this.lblFrecuenciaObservada.Visible = false;
            // 
            // lblFrecuenciaEsperada
            // 
            this.lblFrecuenciaEsperada.AutoSize = true;
            this.lblFrecuenciaEsperada.Location = new System.Drawing.Point(276, 392);
            this.lblFrecuenciaEsperada.Name = "lblFrecuenciaEsperada";
            this.lblFrecuenciaEsperada.Size = new System.Drawing.Size(108, 13);
            this.lblFrecuenciaEsperada.TabIndex = 28;
            this.lblFrecuenciaEsperada.Text = "Frecuencia Esperada";
            this.lblFrecuenciaEsperada.Visible = false;
            // 
            // gbIntervalos
            // 
            this.gbIntervalos.Controls.Add(this.lblCantidadIntervalos);
            this.gbIntervalos.Controls.Add(this.btnGenerarIntervalos);
            this.gbIntervalos.Controls.Add(this.txtCantidadIntervalos);
            this.gbIntervalos.Controls.Add(this.btnAutocalcular);
            this.gbIntervalos.Location = new System.Drawing.Point(357, 452);
            this.gbIntervalos.Name = "gbIntervalos";
            this.gbIntervalos.Size = new System.Drawing.Size(294, 76);
            this.gbIntervalos.TabIndex = 26;
            this.gbIntervalos.TabStop = false;
            this.gbIntervalos.Text = "Intervalos";
            this.gbIntervalos.Visible = false;
            // 
            // lblCantidadIntervalos
            // 
            this.lblCantidadIntervalos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCantidadIntervalos.AutoSize = true;
            this.lblCantidadIntervalos.Location = new System.Drawing.Point(6, 25);
            this.lblCantidadIntervalos.Name = "lblCantidadIntervalos";
            this.lblCantidadIntervalos.Size = new System.Drawing.Size(98, 13);
            this.lblCantidadIntervalos.TabIndex = 22;
            this.lblCantidadIntervalos.Text = "Cantidad Intervalos";
            // 
            // btnGenerarIntervalos
            // 
            this.btnGenerarIntervalos.Location = new System.Drawing.Point(214, 25);
            this.btnGenerarIntervalos.Name = "btnGenerarIntervalos";
            this.btnGenerarIntervalos.Size = new System.Drawing.Size(75, 36);
            this.btnGenerarIntervalos.TabIndex = 25;
            this.btnGenerarIntervalos.Text = "Generar";
            this.btnGenerarIntervalos.UseVisualStyleBackColor = true;
            // 
            // txtCantidadIntervalos
            // 
            this.txtCantidadIntervalos.Location = new System.Drawing.Point(9, 41);
            this.txtCantidadIntervalos.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtCantidadIntervalos.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtCantidadIntervalos.Name = "txtCantidadIntervalos";
            this.txtCantidadIntervalos.Size = new System.Drawing.Size(118, 20);
            this.txtCantidadIntervalos.TabIndex = 23;
            this.txtCantidadIntervalos.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnAutocalcular
            // 
            this.btnAutocalcular.Location = new System.Drawing.Point(133, 25);
            this.btnAutocalcular.Name = "btnAutocalcular";
            this.btnAutocalcular.Size = new System.Drawing.Size(75, 36);
            this.btnAutocalcular.TabIndex = 24;
            this.btnAutocalcular.Text = "Autocalcular";
            this.btnAutocalcular.UseVisualStyleBackColor = true;
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
            // FormTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 685);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.pnlFrecuenciaEsperada);
            this.Controls.Add(this.btnBuscarPagina);
            this.Controls.Add(this.pnlFrecuenciaObservada);
            this.Controls.Add(this.lblFrecuenciaObservada);
            this.Controls.Add(this.txtBuscarPagina);
            this.Controls.Add(this.lblFrecuenciaEsperada);
            this.Controls.Add(this.gbIntervalos);
            this.Controls.Add(this.btnPaginaAnterior);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.MinimumSize = new System.Drawing.Size(1395, 724);
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
            this.gbIntervalos.ResumeLayout(false);
            this.gbIntervalos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadIntervalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.DataGridView dgvSimulacion;
        private System.Windows.Forms.Button btnAutocalcular;
        private System.Windows.Forms.NumericUpDown txtCantidadIntervalos;
        private System.Windows.Forms.Label lblCantidadIntervalos;
        private System.Windows.Forms.GroupBox gbIntervalos;
        private System.Windows.Forms.Button btnGenerarIntervalos;
        private System.Windows.Forms.Panel pnlFrecuenciaEsperada;
        private System.Windows.Forms.Panel pnlFrecuenciaObservada;
        private System.Windows.Forms.Label lblFrecuenciaObservada;
        private System.Windows.Forms.Label lblFrecuenciaEsperada;
        private System.Windows.Forms.Button btnBuscarPagina;
        private System.Windows.Forms.NumericUpDown txtBuscarPagina;
        private System.Windows.Forms.Button btnPaginaAnterior;
        private System.Windows.Forms.Button btnPaginaSiguiente;
        private System.Windows.Forms.Button btnUltimaPagina;
        private System.Windows.Forms.Button btnPrimeraPagina;
        private System.Windows.Forms.DataGridView dgvActividades;
    }
}