namespace A
{
    partial class AltaFamilia
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
            this.btCerrar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textParentesco = new System.Windows.Forms.TextBox();
            this.textOcupacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(118, 208);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 0;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(219, 208);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parentesco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ocupacion";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(78, 10);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(162, 20);
            this.textNombre.TabIndex = 6;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(78, 44);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(162, 20);
            this.textApellido.TabIndex = 7;
            // 
            // textParentesco
            // 
            this.textParentesco.Location = new System.Drawing.Point(77, 86);
            this.textParentesco.Name = "textParentesco";
            this.textParentesco.Size = new System.Drawing.Size(163, 20);
            this.textParentesco.TabIndex = 8;
            // 
            // textOcupacion
            // 
            this.textOcupacion.Location = new System.Drawing.Point(78, 125);
            this.textOcupacion.Name = "textOcupacion";
            this.textOcupacion.Size = new System.Drawing.Size(162, 20);
            this.textOcupacion.TabIndex = 9;
            // 
            // AltaFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 243);
            this.Controls.Add(this.textOcupacion);
            this.Controls.Add(this.textParentesco);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btCerrar);
            this.Name = "AltaFamilia";
            this.Text = "AltaFamilia";
            this.Load += new System.EventHandler(this.AltaFamilia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textParentesco;
        private System.Windows.Forms.TextBox textOcupacion;
    }
}