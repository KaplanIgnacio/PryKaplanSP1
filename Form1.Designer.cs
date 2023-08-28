namespace PryKaplanSP1
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
            this.btnArchivo1 = new System.Windows.Forms.Button();
            this.bnLeerArchivo = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArchivo1
            // 
            this.btnArchivo1.Location = new System.Drawing.Point(32, 298);
            this.btnArchivo1.Name = "btnArchivo1";
            this.btnArchivo1.Size = new System.Drawing.Size(138, 63);
            this.btnArchivo1.TabIndex = 0;
            this.btnArchivo1.Text = "Crear Archivo";
            this.btnArchivo1.UseVisualStyleBackColor = true;
            this.btnArchivo1.Click += new System.EventHandler(this.btnArchivo1_Click);
            // 
            // bnLeerArchivo
            // 
            this.bnLeerArchivo.Location = new System.Drawing.Point(189, 298);
            this.bnLeerArchivo.Name = "bnLeerArchivo";
            this.bnLeerArchivo.Size = new System.Drawing.Size(138, 63);
            this.bnLeerArchivo.TabIndex = 1;
            this.bnLeerArchivo.Text = "Leer Archivo";
            this.bnLeerArchivo.UseVisualStyleBackColor = true;
            this.bnLeerArchivo.Click += new System.EventHandler(this.bnLeerArchivo_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(54, 58);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(197, 95);
            this.txtDatos.TabIndex = 2;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(189, 172);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(102, 46);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.bnLeerArchivo);
            this.Controls.Add(this.btnArchivo1);
            this.Name = "Form1";
            this.Text = " Manejo de Archivos y Carpetas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArchivo1;
        private System.Windows.Forms.Button bnLeerArchivo;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnGrabar;
    }
}

