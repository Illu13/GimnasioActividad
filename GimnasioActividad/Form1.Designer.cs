namespace GimnasioActividad
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
            this.label1 = new System.Windows.Forms.Label();
            this.llbClientes = new System.Windows.Forms.LinkLabel();
            this.llbActividades = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gimnasio Olimpia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // llbClientes
            // 
            this.llbClientes.AutoSize = true;
            this.llbClientes.Location = new System.Drawing.Point(56, 94);
            this.llbClientes.Name = "llbClientes";
            this.llbClientes.Size = new System.Drawing.Size(105, 13);
            this.llbClientes.TabIndex = 1;
            this.llbClientes.TabStop = true;
            this.llbClientes.Text = "Clientes del gimnasio";
            this.llbClientes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbClientes_LinkClicked);
            // 
            // llbActividades
            // 
            this.llbActividades.AutoSize = true;
            this.llbActividades.Location = new System.Drawing.Point(56, 127);
            this.llbActividades.Name = "llbActividades";
            this.llbActividades.Size = new System.Drawing.Size(114, 13);
            this.llbActividades.TabIndex = 2;
            this.llbActividades.TabStop = true;
            this.llbActividades.Text = "Actividades deportivas";
            this.llbActividades.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbActividades_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 255);
            this.Controls.Add(this.llbActividades);
            this.Controls.Add(this.llbClientes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbClientes;
        private System.Windows.Forms.LinkLabel llbActividades;
    }
}

