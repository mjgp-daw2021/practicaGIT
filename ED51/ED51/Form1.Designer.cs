
namespace ED51
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
            this.etiqNombreAlu = new System.Windows.Forms.Label();
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.etiqNota = new System.Windows.Forms.Label();
            this.aluNota = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.etiqLista = new System.Windows.Forms.Label();
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // etiqNombreAlu
            // 
            this.etiqNombreAlu.AutoSize = true;
            this.etiqNombreAlu.Location = new System.Drawing.Point(39, 42);
            this.etiqNombreAlu.Name = "etiqNombreAlu";
            this.etiqNombreAlu.Size = new System.Drawing.Size(96, 13);
            this.etiqNombreAlu.TabIndex = 0;
            this.etiqNombreAlu.Text = "Nombre de alumno";
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(42, 58);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(250, 20);
            this.aluNombre.TabIndex = 1;
            // 
            // etiqNota
            // 
            this.etiqNota.AutoSize = true;
            this.etiqNota.Location = new System.Drawing.Point(315, 42);
            this.etiqNota.Name = "etiqNota";
            this.etiqNota.Size = new System.Drawing.Size(30, 13);
            this.etiqNota.TabIndex = 2;
            this.etiqNota.Text = "Nota";
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(318, 58);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(100, 20);
            this.aluNota.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar alumno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etiqLista
            // 
            this.etiqLista.AutoSize = true;
            this.etiqLista.Location = new System.Drawing.Point(39, 102);
            this.etiqLista.Name = "etiqLista";
            this.etiqLista.Size = new System.Drawing.Size(86, 13);
            this.etiqLista.TabIndex = 5;
            this.etiqLista.Text = "Lista de alumnos";
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(42, 127);
            this.listaAlumnos.Multiline = true;
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(567, 258);
            this.listaAlumnos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 419);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.etiqLista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.etiqNota);
            this.Controls.Add(this.aluNombre);
            this.Controls.Add(this.etiqNombreAlu);
            this.Name = "Form1";
            this.Text = "Alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiqNombreAlu;
        private System.Windows.Forms.TextBox aluNombre;
        private System.Windows.Forms.Label etiqNota;
        private System.Windows.Forms.TextBox aluNota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label etiqLista;
        private System.Windows.Forms.TextBox listaAlumnos;
    }
}

