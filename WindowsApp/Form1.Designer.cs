namespace WindowsApp
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
            this.btn_CrearProducto = new System.Windows.Forms.Button();
            this.bnt_CrearClienteIndividuo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CrearProducto
            // 
            this.btn_CrearProducto.Location = new System.Drawing.Point(317, 94);
            this.btn_CrearProducto.Name = "btn_CrearProducto";
            this.btn_CrearProducto.Size = new System.Drawing.Size(145, 37);
            this.btn_CrearProducto.TabIndex = 0;
            this.btn_CrearProducto.Text = "Crear Producto";
            this.btn_CrearProducto.UseVisualStyleBackColor = true;
            this.btn_CrearProducto.Click += new System.EventHandler(this.btn_CrearProducto_Click);
            // 
            // bnt_CrearClienteIndividuo
            // 
            this.bnt_CrearClienteIndividuo.Location = new System.Drawing.Point(317, 150);
            this.bnt_CrearClienteIndividuo.Name = "bnt_CrearClienteIndividuo";
            this.bnt_CrearClienteIndividuo.Size = new System.Drawing.Size(145, 43);
            this.bnt_CrearClienteIndividuo.TabIndex = 1;
            this.bnt_CrearClienteIndividuo.Text = "Crear ClienteIndividuo";
            this.bnt_CrearClienteIndividuo.UseVisualStyleBackColor = true;
            this.bnt_CrearClienteIndividuo.Click += new System.EventHandler(this.bnt_CrearClienteIndividuo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_CrearClienteIndividuo);
            this.Controls.Add(this.btn_CrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearProducto;
        private System.Windows.Forms.Button bnt_CrearClienteIndividuo;
    }
}

