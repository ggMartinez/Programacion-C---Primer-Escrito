namespace Escrito
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
            this.textoID = new System.Windows.Forms.Label();
            this.textoNombre = new System.Windows.Forms.Label();
            this.textoApellido = new System.Windows.Forms.Label();
            this.textoDireccion = new System.Windows.Forms.Label();
            this.textoTelefono = new System.Windows.Forms.Label();
            this.datosID = new System.Windows.Forms.Label();
            this.datosNombre = new System.Windows.Forms.Label();
            this.datosApellido = new System.Windows.Forms.Label();
            this.datosDireccion = new System.Windows.Forms.Label();
            this.datosTelefono = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoID
            // 
            this.textoID.AutoSize = true;
            this.textoID.Location = new System.Drawing.Point(12, 31);
            this.textoID.Name = "textoID";
            this.textoID.Size = new System.Drawing.Size(21, 13);
            this.textoID.TabIndex = 0;
            this.textoID.Text = "ID:";
            // 
            // textoNombre
            // 
            this.textoNombre.AutoSize = true;
            this.textoNombre.Location = new System.Drawing.Point(12, 71);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(47, 13);
            this.textoNombre.TabIndex = 1;
            this.textoNombre.Text = "Nombre:";
            this.textoNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // textoApellido
            // 
            this.textoApellido.AutoSize = true;
            this.textoApellido.Location = new System.Drawing.Point(12, 111);
            this.textoApellido.Name = "textoApellido";
            this.textoApellido.Size = new System.Drawing.Size(47, 13);
            this.textoApellido.TabIndex = 2;
            this.textoApellido.Text = "Apellido:";
            // 
            // textoDireccion
            // 
            this.textoDireccion.AutoSize = true;
            this.textoDireccion.Location = new System.Drawing.Point(12, 158);
            this.textoDireccion.Name = "textoDireccion";
            this.textoDireccion.Size = new System.Drawing.Size(55, 13);
            this.textoDireccion.TabIndex = 3;
            this.textoDireccion.Text = "Dirección:";
            // 
            // textoTelefono
            // 
            this.textoTelefono.AutoSize = true;
            this.textoTelefono.Location = new System.Drawing.Point(12, 206);
            this.textoTelefono.Name = "textoTelefono";
            this.textoTelefono.Size = new System.Drawing.Size(52, 13);
            this.textoTelefono.TabIndex = 4;
            this.textoTelefono.Text = "Telefono:";
            // 
            // datosID
            // 
            this.datosID.AutoSize = true;
            this.datosID.Location = new System.Drawing.Point(106, 31);
            this.datosID.Name = "datosID";
            this.datosID.Size = new System.Drawing.Size(0, 13);
            this.datosID.TabIndex = 5;
            // 
            // datosNombre
            // 
            this.datosNombre.AutoSize = true;
            this.datosNombre.Location = new System.Drawing.Point(106, 71);
            this.datosNombre.Name = "datosNombre";
            this.datosNombre.Size = new System.Drawing.Size(0, 13);
            this.datosNombre.TabIndex = 6;
            // 
            // datosApellido
            // 
            this.datosApellido.AutoSize = true;
            this.datosApellido.Location = new System.Drawing.Point(106, 111);
            this.datosApellido.Name = "datosApellido";
            this.datosApellido.Size = new System.Drawing.Size(0, 13);
            this.datosApellido.TabIndex = 7;
            // 
            // datosDireccion
            // 
            this.datosDireccion.AutoSize = true;
            this.datosDireccion.Location = new System.Drawing.Point(106, 158);
            this.datosDireccion.Name = "datosDireccion";
            this.datosDireccion.Size = new System.Drawing.Size(0, 13);
            this.datosDireccion.TabIndex = 8;
            // 
            // datosTelefono
            // 
            this.datosTelefono.AutoSize = true;
            this.datosTelefono.Location = new System.Drawing.Point(106, 206);
            this.datosTelefono.Name = "datosTelefono";
            this.datosTelefono.Size = new System.Drawing.Size(0, 13);
            this.datosTelefono.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(86, 245);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 280);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.datosTelefono);
            this.Controls.Add(this.datosDireccion);
            this.Controls.Add(this.datosApellido);
            this.Controls.Add(this.datosNombre);
            this.Controls.Add(this.datosID);
            this.Controls.Add(this.textoTelefono);
            this.Controls.Add(this.textoDireccion);
            this.Controls.Add(this.textoApellido);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.textoID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoID;
        private System.Windows.Forms.Label textoNombre;
        private System.Windows.Forms.Label textoApellido;
        private System.Windows.Forms.Label textoDireccion;
        private System.Windows.Forms.Label textoTelefono;
        private System.Windows.Forms.Label datosID;
        private System.Windows.Forms.Label datosNombre;
        private System.Windows.Forms.Label datosApellido;
        private System.Windows.Forms.Label datosDireccion;
        private System.Windows.Forms.Label datosTelefono;
        private System.Windows.Forms.Button btnAceptar;
    }
}