namespace Escrito.Forms
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecibidoId = new System.Windows.Forms.TextBox();
            this.txtRecibidoNombre = new System.Windows.Forms.TextBox();
            this.txtRecibidoApellido = new System.Windows.Forms.TextBox();
            this.txtRecibidoTelefono = new System.Windows.Forms.TextBox();
            this.txtRecibidoDireccion = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // txtRecibidoId
            // 
            this.txtRecibidoId.Location = new System.Drawing.Point(101, 42);
            this.txtRecibidoId.Name = "txtRecibidoId";
            this.txtRecibidoId.Size = new System.Drawing.Size(100, 20);
            this.txtRecibidoId.TabIndex = 5;
            // 
            // txtRecibidoNombre
            // 
            this.txtRecibidoNombre.Location = new System.Drawing.Point(101, 80);
            this.txtRecibidoNombre.Name = "txtRecibidoNombre";
            this.txtRecibidoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtRecibidoNombre.TabIndex = 6;
            // 
            // txtRecibidoApellido
            // 
            this.txtRecibidoApellido.Location = new System.Drawing.Point(101, 113);
            this.txtRecibidoApellido.Name = "txtRecibidoApellido";
            this.txtRecibidoApellido.Size = new System.Drawing.Size(100, 20);
            this.txtRecibidoApellido.TabIndex = 7;
            // 
            // txtRecibidoTelefono
            // 
            this.txtRecibidoTelefono.Location = new System.Drawing.Point(101, 185);
            this.txtRecibidoTelefono.Name = "txtRecibidoTelefono";
            this.txtRecibidoTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtRecibidoTelefono.TabIndex = 9;
            // 
            // txtRecibidoDireccion
            // 
            this.txtRecibidoDireccion.Location = new System.Drawing.Point(101, 156);
            this.txtRecibidoDireccion.Name = "txtRecibidoDireccion";
            this.txtRecibidoDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtRecibidoDireccion.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(112, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(112, 259);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 317);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtRecibidoDireccion);
            this.Controls.Add(this.txtRecibidoTelefono);
            this.Controls.Add(this.txtRecibidoApellido);
            this.Controls.Add(this.txtRecibidoNombre);
            this.Controls.Add(this.txtRecibidoId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtRecibidoId;
        public System.Windows.Forms.TextBox txtRecibidoNombre;
        public System.Windows.Forms.TextBox txtRecibidoApellido;
        public System.Windows.Forms.TextBox txtRecibidoTelefono;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.TextBox txtRecibidoDireccion;
        private System.Windows.Forms.Button btnAtras;
    }
}