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
            this.btn_Factura = new System.Windows.Forms.Button();
            this.btn_Vendedor = new System.Windows.Forms.Button();
            this.btn_Remito = new System.Windows.Forms.Button();
            this.btn_Empresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CrearProducto
            // 
            this.btn_CrearProducto.Location = new System.Drawing.Point(197, 102);
            this.btn_CrearProducto.Name = "btn_CrearProducto";
            this.btn_CrearProducto.Size = new System.Drawing.Size(153, 60);
            this.btn_CrearProducto.TabIndex = 0;
            this.btn_CrearProducto.Text = "Mostrar Producto";
            this.btn_CrearProducto.UseVisualStyleBackColor = true;
            this.btn_CrearProducto.Click += new System.EventHandler(this.btn_CrearProducto_Click);
            // 
            // bnt_CrearClienteIndividuo
            // 
            this.bnt_CrearClienteIndividuo.Location = new System.Drawing.Point(197, 168);
            this.bnt_CrearClienteIndividuo.Name = "bnt_CrearClienteIndividuo";
            this.bnt_CrearClienteIndividuo.Size = new System.Drawing.Size(153, 60);
            this.bnt_CrearClienteIndividuo.TabIndex = 1;
            this.bnt_CrearClienteIndividuo.Text = "Mostrar ClienteIndividuo";
            this.bnt_CrearClienteIndividuo.UseVisualStyleBackColor = true;
            this.bnt_CrearClienteIndividuo.Click += new System.EventHandler(this.bnt_CrearClienteIndividuo_Click);
            // 
            // btn_Factura
            // 
            this.btn_Factura.Location = new System.Drawing.Point(197, 234);
            this.btn_Factura.Name = "btn_Factura";
            this.btn_Factura.Size = new System.Drawing.Size(153, 60);
            this.btn_Factura.TabIndex = 2;
            this.btn_Factura.Text = "Mostrar Factura";
            this.btn_Factura.UseVisualStyleBackColor = true;
            this.btn_Factura.Click += new System.EventHandler(this.btn_Factura_Click);
            // 
            // btn_Vendedor
            // 
            this.btn_Vendedor.Location = new System.Drawing.Point(394, 168);
            this.btn_Vendedor.Name = "btn_Vendedor";
            this.btn_Vendedor.Size = new System.Drawing.Size(153, 60);
            this.btn_Vendedor.TabIndex = 3;
            this.btn_Vendedor.Text = "Mostrar Vendedor";
            this.btn_Vendedor.UseVisualStyleBackColor = true;
            this.btn_Vendedor.Click += new System.EventHandler(this.btn_Vendedor_Click);
            // 
            // btn_Remito
            // 
            this.btn_Remito.Location = new System.Drawing.Point(394, 102);
            this.btn_Remito.Name = "btn_Remito";
            this.btn_Remito.Size = new System.Drawing.Size(153, 60);
            this.btn_Remito.TabIndex = 4;
            this.btn_Remito.Text = "Mostrar Remito";
            this.btn_Remito.UseVisualStyleBackColor = true;
            this.btn_Remito.Click += new System.EventHandler(this.btn_Remito_Click);
            // 
            // btn_Empresa
            // 
            this.btn_Empresa.Location = new System.Drawing.Point(394, 234);
            this.btn_Empresa.Name = "btn_Empresa";
            this.btn_Empresa.Size = new System.Drawing.Size(153, 60);
            this.btn_Empresa.TabIndex = 5;
            this.btn_Empresa.Text = "Mostrar Empresa";
            this.btn_Empresa.UseVisualStyleBackColor = true;
            this.btn_Empresa.Click += new System.EventHandler(this.btn_Empresa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Empresa);
            this.Controls.Add(this.btn_Remito);
            this.Controls.Add(this.btn_Vendedor);
            this.Controls.Add(this.btn_Factura);
            this.Controls.Add(this.bnt_CrearClienteIndividuo);
            this.Controls.Add(this.btn_CrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearProducto;
        private System.Windows.Forms.Button bnt_CrearClienteIndividuo;
        private System.Windows.Forms.Button btn_Factura;
        private System.Windows.Forms.Button btn_Vendedor;
        private System.Windows.Forms.Button btn_Remito;
        private System.Windows.Forms.Button btn_Empresa;
    }
}

