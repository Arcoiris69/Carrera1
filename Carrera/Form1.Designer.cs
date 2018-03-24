namespace Carrera
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
            this.btnCorrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            this.lblLiebre = new System.Windows.Forms.TextBox();
            this.lblTortuga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(186, 22);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(75, 23);
            this.btnCorrer.TabIndex = 0;
            this.btnCorrer.Text = "Go";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liebre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tortuga";
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Location = new System.Drawing.Point(209, 196);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(0, 13);
            this.lblGanador.TabIndex = 5;
            // 
            // lblLiebre
            // 
            this.lblLiebre.Location = new System.Drawing.Point(36, 97);
            this.lblLiebre.Multiline = true;
            this.lblLiebre.Name = "lblLiebre";
            this.lblLiebre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.lblLiebre.Size = new System.Drawing.Size(100, 86);
            this.lblLiebre.TabIndex = 6;
            // 
            // lblTortuga
            // 
            this.lblTortuga.Location = new System.Drawing.Point(285, 97);
            this.lblTortuga.Multiline = true;
            this.lblTortuga.Name = "lblTortuga";
            this.lblTortuga.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.lblTortuga.Size = new System.Drawing.Size(100, 86);
            this.lblTortuga.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 260);
            this.Controls.Add(this.lblTortuga);
            this.Controls.Add(this.lblLiebre);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCorrer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.TextBox lblLiebre;
        private System.Windows.Forms.TextBox lblTortuga;
    }
}

