namespace Archivo_1
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
            this.txtCaja1 = new System.Windows.Forms.TextBox();
            this.txtCaja3 = new System.Windows.Forms.TextBox();
            this.txtCaja2 = new System.Windows.Forms.TextBox();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCaja1
            // 
            this.txtCaja1.Location = new System.Drawing.Point(96, 122);
            this.txtCaja1.Name = "txtCaja1";
            this.txtCaja1.Size = new System.Drawing.Size(122, 20);
            this.txtCaja1.TabIndex = 0;
            this.txtCaja1.TextChanged += new System.EventHandler(this.txtCaja1_TextChanged);
            // 
            // txtCaja3
            // 
            this.txtCaja3.Location = new System.Drawing.Point(354, 122);
            this.txtCaja3.Name = "txtCaja3";
            this.txtCaja3.Size = new System.Drawing.Size(122, 20);
            this.txtCaja3.TabIndex = 1;
            // 
            // txtCaja2
            // 
            this.txtCaja2.Location = new System.Drawing.Point(224, 122);
            this.txtCaja2.Name = "txtCaja2";
            this.txtCaja2.Size = new System.Drawing.Size(122, 20);
            this.txtCaja2.TabIndex = 2;
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Location = new System.Drawing.Point(93, 49);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(65, 13);
            this.lblIndicacion.TabIndex = 3;
            this.lblIndicacion.Text = "Escribe algo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(501, 122);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.txtCaja2);
            this.Controls.Add(this.txtCaja3);
            this.Controls.Add(this.txtCaja1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaja1;
        private System.Windows.Forms.TextBox txtCaja3;
        private System.Windows.Forms.TextBox txtCaja2;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button1;
    }
}

