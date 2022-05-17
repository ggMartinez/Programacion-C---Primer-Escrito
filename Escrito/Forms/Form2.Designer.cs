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
            this.txtNombreFinal = new System.Windows.Forms.TextBox();
            this.txtIDFinal = new System.Windows.Forms.TextBox();
            this.txtApellidoFinal = new System.Windows.Forms.TextBox();
            this.txtDireccionFinal = new System.Windows.Forms.TextBox();
            this.txtTelefonoFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreFinal
            // 
            this.txtNombreFinal.Enabled = false;
            this.txtNombreFinal.Location = new System.Drawing.Point(70, 43);
            this.txtNombreFinal.Name = "txtNombreFinal";
            this.txtNombreFinal.Size = new System.Drawing.Size(100, 20);
            this.txtNombreFinal.TabIndex = 0;
            // 
            // txtIDFinal
            // 
            this.txtIDFinal.Enabled = false;
            this.txtIDFinal.Location = new System.Drawing.Point(70, 17);
            this.txtIDFinal.Name = "txtIDFinal";
            this.txtIDFinal.Size = new System.Drawing.Size(100, 20);
            this.txtIDFinal.TabIndex = 1;
            this.txtIDFinal.TextChanged += new System.EventHandler(this.txtIDFinal_TextChanged);
            // 
            // txtApellidoFinal
            // 
            this.txtApellidoFinal.Enabled = false;
            this.txtApellidoFinal.Location = new System.Drawing.Point(70, 69);
            this.txtApellidoFinal.Name = "txtApellidoFinal";
            this.txtApellidoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoFinal.TabIndex = 2;
            // 
            // txtDireccionFinal
            // 
            this.txtDireccionFinal.Enabled = false;
            this.txtDireccionFinal.Location = new System.Drawing.Point(70, 95);
            this.txtDireccionFinal.Name = "txtDireccionFinal";
            this.txtDireccionFinal.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionFinal.TabIndex = 3;
            // 
            // txtTelefonoFinal
            // 
            this.txtTelefonoFinal.Enabled = false;
            this.txtTelefonoFinal.Location = new System.Drawing.Point(70, 124);
            this.txtTelefonoFinal.Multiline = true;
            this.txtTelefonoFinal.Name = "txtTelefonoFinal";
            this.txtTelefonoFinal.Size = new System.Drawing.Size(100, 200);
            this.txtTelefonoFinal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefonos";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 356);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefonoFinal);
            this.Controls.Add(this.txtDireccionFinal);
            this.Controls.Add(this.txtApellidoFinal);
            this.Controls.Add(this.txtIDFinal);
            this.Controls.Add(this.txtNombreFinal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreFinal;
        private System.Windows.Forms.TextBox txtIDFinal;
        private System.Windows.Forms.TextBox txtApellidoFinal;
        private System.Windows.Forms.TextBox txtTelefonoFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccionFinal;
    }
}