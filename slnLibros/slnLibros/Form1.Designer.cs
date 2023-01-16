namespace slnLibros
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
            this.label_Libreria = new System.Windows.Forms.Label();
            this.btn_mostrarAutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Libreria
            // 
            this.label_Libreria.AutoSize = true;
            this.label_Libreria.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Libreria.Location = new System.Drawing.Point(65, 29);
            this.label_Libreria.Name = "label_Libreria";
            this.label_Libreria.Size = new System.Drawing.Size(122, 35);
            this.label_Libreria.TabIndex = 0;
            this.label_Libreria.Text = "Librería";
            // 
            // btn_mostrarAutor
            // 
            this.btn_mostrarAutor.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarAutor.Location = new System.Drawing.Point(71, 94);
            this.btn_mostrarAutor.Name = "btn_mostrarAutor";
            this.btn_mostrarAutor.Size = new System.Drawing.Size(151, 53);
            this.btn_mostrarAutor.TabIndex = 1;
            this.btn_mostrarAutor.Text = "Mostrar Autor";
            this.btn_mostrarAutor.UseVisualStyleBackColor = true;
            this.btn_mostrarAutor.Click += new System.EventHandler(this.btn_mostrarAutor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_mostrarAutor);
            this.Controls.Add(this.label_Libreria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Libreria;
        private System.Windows.Forms.Button btn_mostrarAutor;
    }
}

