namespace Presentacion
{
    partial class frmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            this.pbGithub = new System.Windows.Forms.PictureBox();
            this.pbMail = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbLinkedin = new System.Windows.Forms.PictureBox();
            this.lblSG = new System.Windows.Forms.Label();
            this.lblTP = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblMp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkedin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGithub
            // 
            this.pbGithub.Image = ((System.Drawing.Image)(resources.GetObject("pbGithub.Image")));
            this.pbGithub.Location = new System.Drawing.Point(169, 329);
            this.pbGithub.Name = "pbGithub";
            this.pbGithub.Size = new System.Drawing.Size(75, 72);
            this.pbGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGithub.TabIndex = 0;
            this.pbGithub.TabStop = false;
            this.pbGithub.Click += new System.EventHandler(this.pbGithub_Click);
            // 
            // pbMail
            // 
            this.pbMail.Image = ((System.Drawing.Image)(resources.GetObject("pbMail.Image")));
            this.pbMail.Location = new System.Drawing.Point(33, 340);
            this.pbMail.Name = "pbMail";
            this.pbMail.Size = new System.Drawing.Size(50, 50);
            this.pbMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMail.TabIndex = 1;
            this.pbMail.TabStop = false;
            this.pbMail.Click += new System.EventHandler(this.pbMail_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(301, 349);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(155, 41);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbLinkedin
            // 
            this.pbLinkedin.Image = ((System.Drawing.Image)(resources.GetObject("pbLinkedin.Image")));
            this.pbLinkedin.Location = new System.Drawing.Point(113, 340);
            this.pbLinkedin.Name = "pbLinkedin";
            this.pbLinkedin.Size = new System.Drawing.Size(50, 50);
            this.pbLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLinkedin.TabIndex = 4;
            this.pbLinkedin.TabStop = false;
            this.pbLinkedin.Click += new System.EventHandler(this.pbLinkedin_Click);
            // 
            // lblSG
            // 
            this.lblSG.AutoSize = true;
            this.lblSG.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSG.Location = new System.Drawing.Point(28, 244);
            this.lblSG.Name = "lblSG";
            this.lblSG.Size = new System.Drawing.Size(200, 25);
            this.lblSG.TabIndex = 21;
            this.lblSG.Text = "Sebastián Gallego";
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP.Location = new System.Drawing.Point(28, 70);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(306, 25);
            this.lblTP.TabIndex = 22;
            this.lblTP.Text = "Trabajo Práctico Integrador";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(28, 113);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(353, 25);
            this.lblCurso.TabIndex = 23;
            this.lblCurso.Text = "🛡 Curso C# Nivel 2 [.Net + SQL]";
            // 
            // lblMp
            // 
            this.lblMp.AutoSize = true;
            this.lblMp.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMp.Location = new System.Drawing.Point(28, 161);
            this.lblMp.Name = "lblMp";
            this.lblMp.Size = new System.Drawing.Size(282, 25);
            this.lblMp.TabIndex = 24;
            this.lblMp.Text = "www.maxiprograma.com";
            this.lblMp.Click += new System.EventHandler(this.lblMp_Click);
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.lblMp);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblTP);
            this.Controls.Add(this.lblSG);
            this.Controls.Add(this.pbLinkedin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pbMail);
            this.Controls.Add(this.pbGithub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 450);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "frmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca Del Desarrollador";
            ((System.ComponentModel.ISupportInitialize)(this.pbGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkedin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGithub;
        private System.Windows.Forms.PictureBox pbMail;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbLinkedin;
        private System.Windows.Forms.Label lblSG;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblMp;
    }
}