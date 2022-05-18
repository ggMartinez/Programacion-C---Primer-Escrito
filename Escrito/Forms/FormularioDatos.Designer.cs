namespace Escrito.Forms
{
    partial class FormularioDatos
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
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.LabelDireccion = new System.Windows.Forms.Label();
            this.LabelTelefonos = new System.Windows.Forms.Label();
            this.LabelIngresarId = new System.Windows.Forms.Label();
            this.LabelIngresarNombre = new System.Windows.Forms.Label();
            this.LabelIngresarApellido = new System.Windows.Forms.Label();
            this.LabelIngresarDireccion = new System.Windows.Forms.Label();
            this.LabelIngresarTelefonos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(85, 27);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(19, 13);
            this.LabelId.TabIndex = 0;
            this.LabelId.Text = "Id:";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(57, 56);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(47, 13);
            this.LabelNombre.TabIndex = 1;
            this.LabelNombre.Text = "Nombre:";
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Location = new System.Drawing.Point(57, 90);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(47, 13);
            this.LabelApellido.TabIndex = 2;
            this.LabelApellido.Text = "Apellido:";
            // 
            // LabelDireccion
            // 
            this.LabelDireccion.AutoSize = true;
            this.LabelDireccion.Location = new System.Drawing.Point(49, 121);
            this.LabelDireccion.Name = "LabelDireccion";
            this.LabelDireccion.Size = new System.Drawing.Size(55, 13);
            this.LabelDireccion.TabIndex = 3;
            this.LabelDireccion.Text = "Dirección:";
            // 
            // LabelTelefonos
            // 
            this.LabelTelefonos.AutoSize = true;
            this.LabelTelefonos.Location = new System.Drawing.Point(47, 157);
            this.LabelTelefonos.Name = "LabelTelefonos";
            this.LabelTelefonos.Size = new System.Drawing.Size(57, 13);
            this.LabelTelefonos.TabIndex = 4;
            this.LabelTelefonos.Text = "Teléfonos:";
            // 
            // LabelIngresarId
            // 
            this.LabelIngresarId.AutoSize = true;
            this.LabelIngresarId.Location = new System.Drawing.Point(128, 27);
            this.LabelIngresarId.Name = "LabelIngresarId";
            this.LabelIngresarId.Size = new System.Drawing.Size(63, 13);
            this.LabelIngresarId.TabIndex = 5;
            this.LabelIngresarId.Text = "IdIngresada";
            // 
            // LabelIngresarNombre
            // 
            this.LabelIngresarNombre.AutoSize = true;
            this.LabelIngresarNombre.Location = new System.Drawing.Point(128, 56);
            this.LabelIngresarNombre.Name = "LabelIngresarNombre";
            this.LabelIngresarNombre.Size = new System.Drawing.Size(91, 13);
            this.LabelIngresarNombre.TabIndex = 6;
            this.LabelIngresarNombre.Text = "NombreIngresado";
            // 
            // LabelIngresarApellido
            // 
            this.LabelIngresarApellido.AutoSize = true;
            this.LabelIngresarApellido.Location = new System.Drawing.Point(128, 90);
            this.LabelIngresarApellido.Name = "LabelIngresarApellido";
            this.LabelIngresarApellido.Size = new System.Drawing.Size(91, 13);
            this.LabelIngresarApellido.TabIndex = 7;
            this.LabelIngresarApellido.Text = "ApellidoIngresado";
            // 
            // LabelIngresarDireccion
            // 
            this.LabelIngresarDireccion.AutoSize = true;
            this.LabelIngresarDireccion.Location = new System.Drawing.Point(128, 121);
            this.LabelIngresarDireccion.Name = "LabelIngresarDireccion";
            this.LabelIngresarDireccion.Size = new System.Drawing.Size(99, 13);
            this.LabelIngresarDireccion.TabIndex = 8;
            this.LabelIngresarDireccion.Text = "DireccionIngresada";
            // 
            // LabelIngresarTelefonos
            // 
            this.LabelIngresarTelefonos.AutoSize = true;
            this.LabelIngresarTelefonos.Location = new System.Drawing.Point(121, 147);
            this.LabelIngresarTelefonos.Name = "LabelIngresarTelefonos";
            this.LabelIngresarTelefonos.Size = new System.Drawing.Size(106, 13);
            this.LabelIngresarTelefonos.TabIndex = 9;
            this.LabelIngresarTelefonos.Text = "TelefonosIngresados";
            // 
            // FormularioDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 340);
            this.Controls.Add(this.LabelIngresarTelefonos);
            this.Controls.Add(this.LabelIngresarDireccion);
            this.Controls.Add(this.LabelIngresarApellido);
            this.Controls.Add(this.LabelIngresarNombre);
            this.Controls.Add(this.LabelIngresarId);
            this.Controls.Add(this.LabelTelefonos);
            this.Controls.Add(this.LabelDireccion);
            this.Controls.Add(this.LabelApellido);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.LabelId);
            this.Name = "FormularioDatos";
            this.Text = "FormularioDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.Label LabelDireccion;
        private System.Windows.Forms.Label LabelTelefonos;
        public System.Windows.Forms.Label LabelIngresarId;
        public System.Windows.Forms.Label LabelIngresarTelefonos;
        public System.Windows.Forms.Label LabelIngresarNombre;
        public System.Windows.Forms.Label LabelIngresarApellido;
        public System.Windows.Forms.Label LabelIngresarDireccion;
    }
}