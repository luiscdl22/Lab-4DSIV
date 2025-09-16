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
            this.btnMostrarPalindromos.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPalindromos.Location = new System.Drawing.Point(125, 293);
            this.btnMostrarPalindromos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMostrarPalindromos.Name = "btnMostrarPalindromos";
            this.btnMostrarPalindromos.Size = new System.Drawing.Size(176, 50);
            this.btnMostrarPalindromos.TabIndex = 0;
            this.btnMostrarPalindromos.Text = "INICIAR";
            this.btnMostrarPalindromos.UseVisualStyleBackColor = true;
            this.btnMostrarPalindromos.Click += new System.EventHandler(this.btnMostrarPalindromos_Click);
            // 
            // lbPalindromos
            // 
            this.lbPalindromos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPalindromos.FormattingEnabled = true;
            this.lbPalindromos.ItemHeight = 29;
            this.lbPalindromos.Location = new System.Drawing.Point(125, 420);
            this.lbPalindromos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbPalindromos.Name = "lbPalindromos";
            this.lbPalindromos.Size = new System.Drawing.Size(459, 178);
            this.lbPalindromos.TabIndex = 1;
            // 
            // txtInicioRango
            // 
            this.txtInicioRango.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicioRango.Location = new System.Drawing.Point(576, 163);
            this.txtInicioRango.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInicioRango.Multiline = true;
            this.txtInicioRango.Name = "txtInicioRango";
            this.txtInicioRango.Size = new System.Drawing.Size(263, 42);
            this.txtInicioRango.TabIndex = 2;
            this.txtInicioRango.TextChanged += new System.EventHandler(this.txtInicioRango_TextChanged);
            // 
            // txtFinRango
            // 
            this.txtFinRango.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinRango.Location = new System.Drawing.Point(576, 221);
            this.txtFinRango.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFinRango.Multiline = true;
            this.txtFinRango.Name = "txtFinRango";
            this.txtFinRango.Size = new System.Drawing.Size(263, 42);
            this.txtFinRango.TabIndex = 3;
            this.txtFinRango.TextChanged += new System.EventHandler(this.txtFinRango_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "INICIO DE RANGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "FIN DE RANGO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(571, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "PALINDROMOS ENCONTRADOS:";
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente2.Location = new System.Drawing.Point(367, 625);
            this.btnSiguiente2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(217, 50);
            this.btnSiguiente2.TabIndex = 7;
            this.btnSiguiente2.Text = "SIGUIENTE";
            this.btnSiguiente2.UseVisualStyleBackColor = true;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior3
            // 
            this.btnAnterior3.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior3.Location = new System.Drawing.Point(124, 625);
            this.btnAnterior3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnterior3.Name = "btnAnterior3";
            this.btnAnterior3.Size = new System.Drawing.Size(217, 50);
            this.btnAnterior3.TabIndex = 11;
            this.btnAnterior3.Text = "ANTERIOR";
            this.btnAnterior3.UseVisualStyleBackColor = true;
            this.btnAnterior3.Click += new System.EventHandler(this.btnAnterior3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(115, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(724, 51);
            this.label4.TabIndex = 12;
            this.label4.Text = "ENCONTRAR PALINDROMOS";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1227, 708);
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
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palindromos Numerales";
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