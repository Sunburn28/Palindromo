﻿namespace Palindromo
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
            this.Verificar = new System.Windows.Forms.Button();
            this.Palabra1 = new System.Windows.Forms.TextBox();
            this.Palabra2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Verificar
            // 
            this.Verificar.Location = new System.Drawing.Point(269, 184);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(162, 59);
            this.Verificar.TabIndex = 0;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // Palabra1
            // 
            this.Palabra1.Location = new System.Drawing.Point(222, 72);
            this.Palabra1.Name = "Palabra1";
            this.Palabra1.Size = new System.Drawing.Size(209, 22);
            this.Palabra1.TabIndex = 1;
            // 
            // Palabra2
            // 
            this.Palabra2.Location = new System.Drawing.Point(222, 136);
            this.Palabra2.Name = "Palabra2";
            this.Palabra2.Size = new System.Drawing.Size(209, 22);
            this.Palabra2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palindromo con Hilos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Palabra2);
            this.Controls.Add(this.Palabra1);
            this.Controls.Add(this.Verificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.TextBox Palabra1;
        private System.Windows.Forms.TextBox Palabra2;
        private System.Windows.Forms.Label label1;
    }
}

