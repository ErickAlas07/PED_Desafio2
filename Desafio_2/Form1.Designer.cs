
namespace Desafio_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpRecorridos = new System.Windows.Forms.GroupBox();
            this.btnProfundidad = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAnchura = new System.Windows.Forms.Button();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.lblInicialD = new System.Windows.Forms.Label();
            this.pnlMapa = new System.Windows.Forms.Panel();
            this.ptbMapa = new System.Windows.Forms.PictureBox();
            this.grpMapas = new System.Windows.Forms.GroupBox();
            this.cmbPaises = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNoDirigido = new System.Windows.Forms.RadioButton();
            this.rbDirigido = new System.Windows.Forms.RadioButton();
            this.CMSCrearVertice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoVérticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVérticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArcoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpRecorridos.SuspendLayout();
            this.pnlMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMapa)).BeginInit();
            this.grpMapas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CMSCrearVertice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRecorridos
            // 
            this.grpRecorridos.BackColor = System.Drawing.Color.DarkRed;
            this.grpRecorridos.Controls.Add(this.btnProfundidad);
            this.grpRecorridos.Controls.Add(this.btnBuscar);
            this.grpRecorridos.Controls.Add(this.btnAnchura);
            this.grpRecorridos.Controls.Add(this.cmbDepartamentos);
            this.grpRecorridos.Controls.Add(this.lblInicialD);
            this.grpRecorridos.ForeColor = System.Drawing.Color.White;
            this.grpRecorridos.Location = new System.Drawing.Point(13, 13);
            this.grpRecorridos.Name = "grpRecorridos";
            this.grpRecorridos.Size = new System.Drawing.Size(433, 110);
            this.grpRecorridos.TabIndex = 0;
            this.grpRecorridos.TabStop = false;
            this.grpRecorridos.Text = "RECORRIDOS";
            // 
            // btnProfundidad
            // 
            this.btnProfundidad.ForeColor = System.Drawing.Color.Black;
            this.btnProfundidad.Location = new System.Drawing.Point(125, 61);
            this.btnProfundidad.Name = "btnProfundidad";
            this.btnProfundidad.Size = new System.Drawing.Size(120, 35);
            this.btnProfundidad.TabIndex = 2;
            this.btnProfundidad.Text = "Profundidad";
            this.btnProfundidad.UseVisualStyleBackColor = true;
            this.btnProfundidad.Click += new System.EventHandler(this.btnProfundidad_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(257, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(165, 33);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar departamento";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAnchura
            // 
            this.btnAnchura.ForeColor = System.Drawing.Color.Black;
            this.btnAnchura.Location = new System.Drawing.Point(18, 61);
            this.btnAnchura.Name = "btnAnchura";
            this.btnAnchura.Size = new System.Drawing.Size(90, 35);
            this.btnAnchura.TabIndex = 1;
            this.btnAnchura.Text = "Anchura";
            this.btnAnchura.UseVisualStyleBackColor = true;
            this.btnAnchura.Click += new System.EventHandler(this.btnAnchura_Click);
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(257, 22);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartamentos.TabIndex = 1;
            // 
            // lblInicialD
            // 
            this.lblInicialD.AutoSize = true;
            this.lblInicialD.Location = new System.Drawing.Point(6, 29);
            this.lblInicialD.Name = "lblInicialD";
            this.lblInicialD.Size = new System.Drawing.Size(230, 17);
            this.lblInicialD.TabIndex = 0;
            this.lblInicialD.Text = "Departamento inicial del Recorrido:";
            // 
            // pnlMapa
            // 
            this.pnlMapa.Controls.Add(this.ptbMapa);
            this.pnlMapa.Location = new System.Drawing.Point(13, 139);
            this.pnlMapa.Name = "pnlMapa";
            this.pnlMapa.Size = new System.Drawing.Size(806, 446);
            this.pnlMapa.TabIndex = 1;
            // 
            // ptbMapa
            // 
            this.ptbMapa.Location = new System.Drawing.Point(-1, 0);
            this.ptbMapa.Name = "ptbMapa";
            this.ptbMapa.Size = new System.Drawing.Size(807, 446);
            this.ptbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbMapa.TabIndex = 0;
            this.ptbMapa.TabStop = false;
            this.ptbMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbMapa_Paint);
            this.ptbMapa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbMapa_MouseClick);
            this.ptbMapa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbMapa_MouseDown);
            this.ptbMapa.MouseLeave += new System.EventHandler(this.ptbMapa_MouseLeave);
            this.ptbMapa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbMapa_MouseMove);
            this.ptbMapa.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbMapa_MouseUp);
            // 
            // grpMapas
            // 
            this.grpMapas.Controls.Add(this.cmbPaises);
            this.grpMapas.Location = new System.Drawing.Point(22, 605);
            this.grpMapas.Name = "grpMapas";
            this.grpMapas.Size = new System.Drawing.Size(260, 81);
            this.grpMapas.TabIndex = 2;
            this.grpMapas.TabStop = false;
            this.grpMapas.Text = "Visita Centroamérica";
            // 
            // cmbPaises
            // 
            this.cmbPaises.Location = new System.Drawing.Point(9, 40);
            this.cmbPaises.Name = "cmbPaises";
            this.cmbPaises.Size = new System.Drawing.Size(168, 24);
            this.cmbPaises.TabIndex = 0;
            this.cmbPaises.SelectedIndexChanged += new System.EventHandler(this.cmbPaises_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(841, 634);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 52);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNoDirigido);
            this.groupBox1.Controls.Add(this.rbDirigido);
            this.groupBox1.Location = new System.Drawing.Point(690, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo:";
            this.groupBox1.Visible = false;
            // 
            // rbNoDirigido
            // 
            this.rbNoDirigido.AutoSize = true;
            this.rbNoDirigido.Location = new System.Drawing.Point(111, 26);
            this.rbNoDirigido.Name = "rbNoDirigido";
            this.rbNoDirigido.Size = new System.Drawing.Size(99, 21);
            this.rbNoDirigido.TabIndex = 1;
            this.rbNoDirigido.TabStop = true;
            this.rbNoDirigido.Text = "No Dirigido";
            this.rbNoDirigido.UseVisualStyleBackColor = true;
            this.rbNoDirigido.CheckedChanged += new System.EventHandler(this.rbNoDirigido_CheckedChanged);
            // 
            // rbDirigido
            // 
            this.rbDirigido.AutoSize = true;
            this.rbDirigido.Location = new System.Drawing.Point(24, 26);
            this.rbDirigido.Name = "rbDirigido";
            this.rbDirigido.Size = new System.Drawing.Size(77, 21);
            this.rbDirigido.TabIndex = 0;
            this.rbDirigido.TabStop = true;
            this.rbDirigido.Text = "Dirigido";
            this.rbDirigido.UseVisualStyleBackColor = true;
            this.rbDirigido.CheckedChanged += new System.EventHandler(this.rbDirigido_CheckedChanged);
            // 
            // CMSCrearVertice
            // 
            this.CMSCrearVertice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSCrearVertice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoVérticeToolStripMenuItem,
            this.eliminarVérticeToolStripMenuItem,
            this.eliminarArcoToolStripMenuItem});
            this.CMSCrearVertice.Name = "CMSCrearVertice";
            this.CMSCrearVertice.Size = new System.Drawing.Size(182, 76);
            this.CMSCrearVertice.Opening += new System.ComponentModel.CancelEventHandler(this.CMSCrearVertice_Opening);
            // 
            // nuevoVérticeToolStripMenuItem
            // 
            this.nuevoVérticeToolStripMenuItem.Name = "nuevoVérticeToolStripMenuItem";
            this.nuevoVérticeToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.nuevoVérticeToolStripMenuItem.Text = "Nuevo Vértice";
            this.nuevoVérticeToolStripMenuItem.Click += new System.EventHandler(this.nuevoVérticeToolStripMenuItem_Click);
            // 
            // eliminarVérticeToolStripMenuItem
            // 
            this.eliminarVérticeToolStripMenuItem.Name = "eliminarVérticeToolStripMenuItem";
            this.eliminarVérticeToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.eliminarVérticeToolStripMenuItem.Text = "Eliminar Vértice";
            this.eliminarVérticeToolStripMenuItem.Click += new System.EventHandler(this.eliminarVérticeToolStripMenuItem_Click);
            // 
            // eliminarArcoToolStripMenuItem
            // 
            this.eliminarArcoToolStripMenuItem.Name = "eliminarArcoToolStripMenuItem";
            this.eliminarArcoToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.eliminarArcoToolStripMenuItem.Text = "Eliminar Arco";
            this.eliminarArcoToolStripMenuItem.Click += new System.EventHandler(this.eliminarArcoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 136);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 698);
            this.Controls.Add(this.pnlMapa);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpMapas);
            this.Controls.Add(this.grpRecorridos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpRecorridos.ResumeLayout(false);
            this.grpRecorridos.PerformLayout();
            this.pnlMapa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMapa)).EndInit();
            this.grpMapas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CMSCrearVertice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRecorridos;
        private System.Windows.Forms.Button btnProfundidad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAnchura;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.Label lblInicialD;
        private System.Windows.Forms.Panel pnlMapa;
        private System.Windows.Forms.GroupBox grpMapas;
        private System.Windows.Forms.ComboBox cmbPaises;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rbNoDirigido;
        public System.Windows.Forms.RadioButton rbDirigido;
        private System.Windows.Forms.ContextMenuStrip CMSCrearVertice;
        private System.Windows.Forms.ToolStripMenuItem nuevoVérticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVérticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArcoToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptbMapa;
        private System.Windows.Forms.Panel panel1;
    }
}

