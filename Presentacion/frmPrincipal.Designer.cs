using System;

namespace Presentacion
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblListadoProductos = new System.Windows.Forms.Label();
            this.ldbDescripcion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbDetalles = new System.Windows.Forms.ListBox();
            this.gbFiltroRapido = new System.Windows.Forms.GroupBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnLimpiarFiltroRapido = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.Menu.SuspendLayout();
            this.gbFiltroRapido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.ColumnHeadersHeight = 30;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvArticulos.Location = new System.Drawing.Point(167, 193);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(844, 629);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(21, 193);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 41);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(21, 240);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 41);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(21, 287);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 41);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(21, 334);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(117, 41);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(1104, 400);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(0);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(400, 400);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 5;
            this.pbImagen.TabStop = false;
            // 
            // lblListadoProductos
            // 
            this.lblListadoProductos.AutoSize = true;
            this.lblListadoProductos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoProductos.Location = new System.Drawing.Point(502, 38);
            this.lblListadoProductos.Name = "lblListadoProductos";
            this.lblListadoProductos.Size = new System.Drawing.Size(168, 19);
            this.lblListadoProductos.TabIndex = 7;
            this.lblListadoProductos.Text = "Listado de Artículo:";
            // 
            // ldbDescripcion
            // 
            this.ldbDescripcion.AutoSize = true;
            this.ldbDescripcion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldbDescripcion.Location = new System.Drawing.Point(1046, 162);
            this.ldbDescripcion.Name = "ldbDescripcion";
            this.ldbDescripcion.Size = new System.Drawing.Size(82, 19);
            this.ldbDescripcion.TabIndex = 8;
            this.ldbDescripcion.Text = "Detalles:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1388, 908);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(155, 41);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticulosToolStripMenuItem,
            this.filtrarToolStripMenuItem,
            this.CategoriaToolStripMenuItem,
            this.MarcaToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1584, 24);
            this.Menu.TabIndex = 10;
            this.Menu.Text = "menuStrip1";
            // 
            // ArticulosToolStripMenuItem
            // 
            this.ArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem";
            this.ArticulosToolStripMenuItem.ShortcutKeyDisplayString = "Artículos";
            this.ArticulosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.ArticulosToolStripMenuItem.Text = "Artículos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.agregarToolStripMenuItem.Text = "Agregar...";
            this.agregarToolStripMenuItem.ToolTipText = "Agregar un Producto a la BD";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.modificarToolStripMenuItem.Text = "Modificar...";
            this.modificarToolStripMenuItem.ToolTipText = "Modificar un Producto a la BD";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar...";
            this.eliminarToolStripMenuItem.ToolTipText = "Eliminar un Producto a la BD";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // filtrarToolStripMenuItem
            // 
            this.filtrarToolStripMenuItem.Name = "filtrarToolStripMenuItem";
            this.filtrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.filtrarToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.filtrarToolStripMenuItem.Text = "Filtrar";
            // 
            // CategoriaToolStripMenuItem
            // 
            this.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem";
            this.CategoriaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.CategoriaToolStripMenuItem.Text = "Categoria";
            this.CategoriaToolStripMenuItem.Click += new System.EventHandler(this.CategoriaToolStripMenuItem_Click);
            // 
            // MarcaToolStripMenuItem
            // 
            this.MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem";
            this.MarcaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.MarcaToolStripMenuItem.Text = "Marca";
            this.MarcaToolStripMenuItem.Click += new System.EventHandler(this.MarcaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // lbDetalles
            // 
            this.lbDetalles.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbDetalles.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetalles.FormattingEnabled = true;
            this.lbDetalles.ItemHeight = 19;
            this.lbDetalles.Location = new System.Drawing.Point(1050, 193);
            this.lbDetalles.Name = "lbDetalles";
            this.lbDetalles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDetalles.Size = new System.Drawing.Size(509, 175);
            this.lbDetalles.TabIndex = 23;
            // 
            // gbFiltroRapido
            // 
            this.gbFiltroRapido.Controls.Add(this.lblPrecio);
            this.gbFiltroRapido.Controls.Add(this.btnLimpiarFiltroRapido);
            this.gbFiltroRapido.Controls.Add(this.cboCategoria);
            this.gbFiltroRapido.Controls.Add(this.cboMarca);
            this.gbFiltroRapido.Controls.Add(this.lblCategoria);
            this.gbFiltroRapido.Controls.Add(this.lblMarca);
            this.gbFiltroRapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFiltroRapido.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltroRapido.Location = new System.Drawing.Point(167, 84);
            this.gbFiltroRapido.Name = "gbFiltroRapido";
            this.gbFiltroRapido.Size = new System.Drawing.Size(844, 103);
            this.gbFiltroRapido.TabIndex = 29;
            this.gbFiltroRapido.TabStop = false;
            this.gbFiltroRapido.Text = "Filtro Rápido";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(406, 37);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(74, 19);
            this.lblPrecio.TabIndex = 35;
            this.lblPrecio.Text = "Precios:";
            // 
            // btnLimpiarFiltroRapido
            // 
            this.btnLimpiarFiltroRapido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLimpiarFiltroRapido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarFiltroRapido.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltroRapido.Location = new System.Drawing.Point(611, 56);
            this.btnLimpiarFiltroRapido.Name = "btnLimpiarFiltroRapido";
            this.btnLimpiarFiltroRapido.Size = new System.Drawing.Size(191, 27);
            this.btnLimpiarFiltroRapido.TabIndex = 33;
            this.btnLimpiarFiltroRapido.Text = "&Limpiar Filtro rápido";
            this.btnLimpiarFiltroRapido.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltroRapido.Click += new System.EventHandler(this.btnLimpiarFiltroRapido_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cboCategoria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(231, 59);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(144, 24);
            this.cboCategoria.TabIndex = 30;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // cboMarca
            // 
            this.cboMarca.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cboMarca.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.ItemHeight = 16;
            this.cboMarca.Location = new System.Drawing.Point(46, 59);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(142, 24);
            this.cboMarca.TabIndex = 29;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(227, 37);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(103, 19);
            this.lblCategoria.TabIndex = 32;
            this.lblCategoria.Text = "Categorías:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(42, 37);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 19);
            this.lblMarca.TabIndex = 31;
            this.lblMarca.Text = "Marcas:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1584, 961);
            this.Controls.Add(this.gbFiltroRapido);
            this.Controls.Add(this.lbDetalles);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.ldbDescripcion);
            this.Controls.Add(this.lblListadoProductos);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.MinimumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP Integrador Sebastián Gallego";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.gbFiltroRapido.ResumeLayout(false);
            this.gbFiltroRapido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     
                #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblListadoProductos;
        private System.Windows.Forms.Label ldbDescripcion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem ArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MarcaToolStripMenuItem;
        private System.Windows.Forms.ListBox lbDetalles;
        private System.Windows.Forms.GroupBox gbFiltroRapido;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnLimpiarFiltroRapido;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
    }
}

