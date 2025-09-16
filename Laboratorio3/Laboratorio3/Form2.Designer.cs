namespace Laboratorio3
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
            this.btnMostrarPalindromos = new System.Windows.Forms.Button();
            this.lbPalindromos = new System.Windows.Forms.ListBox();
            this.txtInicioRango = new System.Windows.Forms.TextBox();
            this.txtFinRango = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiguiente2 = new System.Windows.Forms.Button();
            this.btnAnterior3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarPalindromos
            // 
            this.btnMostrarPalindromos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPalindromos.Location = new System.Drawing.Point(91, 165);
            this.btnMostrarPalindromos.Name = "btnMostrarPalindromos";
            this.btnMostrarPalindromos.Size = new System.Drawing.Size(100, 40);
            this.btnMostrarPalindromos.TabIndex = 0;
            this.btnMostrarPalindromos.Text = "INICIAR";
            this.btnMostrarPalindromos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarPalindromos.UseVisualStyleBackColor = true;
            this.btnMostrarPalindromos.Click += new System.EventHandler(this.btnMostrarPalindromos_Click);
            // 
            // lbPalindromos
            // 
            this.lbPalindromos.FormattingEnabled = true;
            this.lbPalindromos.ItemHeight = 16;
            this.lbPalindromos.Location = new System.Drawing.Point(120, 291);
            this.lbPalindromos.Name = "lbPalindromos";
            this.lbPalindromos.Size = new System.Drawing.Size(242, 84);
            this.lbPalindromos.TabIndex = 1;
            // 
            // txtInicioRango
            // 
            this.txtInicioRango.Location = new System.Drawing.Point(286, 86);
            this.txtInicioRango.Name = "txtInicioRango";
            this.txtInicioRango.Size = new System.Drawing.Size(100, 22);
            this.txtInicioRango.TabIndex = 2;
            // 
            // txtFinRango
            // 
            this.txtFinRango.Location = new System.Drawing.Point(286, 114);
            this.txtFinRango.Name = "txtFinRango";
            this.txtFinRango.Size = new System.Drawing.Size(100, 22);
            this.txtFinRango.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "INICIO DE RANGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "FIN DE RANGO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "PALINDROMOS ENCONTRADOS:";
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente2.Location = new System.Drawing.Point(394, 408);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(152, 30);
            this.btnSiguiente2.TabIndex = 7;
            this.btnSiguiente2.Text = "SIGUIENTE";
            this.btnSiguiente2.UseVisualStyleBackColor = true;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior3
            // 
            this.btnAnterior3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior3.Location = new System.Drawing.Point(12, 408);
            this.btnAnterior3.Name = "btnAnterior3";
            this.btnAnterior3.Size = new System.Drawing.Size(152, 30);
            this.btnAnterior3.TabIndex = 11;
            this.btnAnterior3.Text = "ANTERIOR";
            this.btnAnterior3.UseVisualStyleBackColor = true;
            this.btnAnterior3.Click += new System.EventHandler(this.btnAnterior3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "ENCONTRAR PALINDROMOS";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAnterior3);
            this.Controls.Add(this.btnSiguiente2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinRango);
            this.Controls.Add(this.txtInicioRango);
            this.Controls.Add(this.lbPalindromos);
            this.Controls.Add(this.btnMostrarPalindromos);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPalindromos;
        private System.Windows.Forms.ListBox lbPalindromos;
        private System.Windows.Forms.TextBox txtInicioRango;
        private System.Windows.Forms.TextBox txtFinRango;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiguiente2;
        private System.Windows.Forms.Button btnAnterior3;
        private System.Windows.Forms.Label label4;
    }
}