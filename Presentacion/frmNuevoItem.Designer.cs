namespace Presentacion
{
    partial class frmNuevoItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoItem));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lwItems = new System.Windows.Forms.ListView();
            this.lblNuevoItem = new System.Windows.Forms.Label();
            this.txtNuevoItem = new System.Windows.Forms.TextBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(341, 420);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(155, 41);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(341, 355);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(155, 41);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // lwItems
            // 
            this.lwItems.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lwItems.ForeColor = System.Drawing.Color.Black;
            this.lwItems.HideSelection = false;
            this.lwItems.Location = new System.Drawing.Point(48, 65);
            this.lwItems.Name = "lwItems";
            this.lwItems.Size = new System.Drawing.Size(235, 406);
            this.lwItems.TabIndex = 10;
            this.lwItems.UseCompatibleStateImageBehavior = false;
            // 
            // lblNuevoItem
            // 
            this.lblNuevoItem.AutoSize = true;
            this.lblNuevoItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoItem.Location = new System.Drawing.Point(365, 128);
            this.lblNuevoItem.Name = "lblNuevoItem";
            this.lblNuevoItem.Size = new System.Drawing.Size(110, 19);
            this.lblNuevoItem.TabIndex = 20;
            this.lblNuevoItem.Text = "Nuevo Item:";
            // 
            // txtNuevoItem
            // 
            this.txtNuevoItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNuevoItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoItem.Location = new System.Drawing.Point(341, 160);
            this.txtNuevoItem.MaxLength = 50;
            this.txtNuevoItem.Name = "txtNuevoItem";
            this.txtNuevoItem.Size = new System.Drawing.Size(164, 27);
            this.txtNuevoItem.TabIndex = 18;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(44, 31);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(151, 19);
            this.lblLista.TabIndex = 19;
            this.lblLista.Text = "Listado de Items:";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(785, 292);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(505, 307);
            this.dgvLista.TabIndex = 21;
            // 
            // frmNuevoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1526, 862);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.lblNuevoItem);
            this.Controls.Add(this.txtNuevoItem);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lwItems);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Item";
            this.Load += new System.EventHandler(this.frmNuevoItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListView lwItems;
        private System.Windows.Forms.Label lblNuevoItem;
        private System.Windows.Forms.TextBox txtNuevoItem;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvLista;
    }
}