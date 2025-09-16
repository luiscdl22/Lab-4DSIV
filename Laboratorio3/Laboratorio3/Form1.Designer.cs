namespace Laboratorio3
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
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.lvVocales = new System.Windows.Forms.ListView();
            this.CantidadVocales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Vocales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtPalabra
            // 
            this.txtPalabra.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabra.Location = new System.Drawing.Point(119, 268);
            this.txtPalabra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPalabra.Multiline = true;
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(375, 47);
            this.txtPalabra.TabIndex = 0;
            this.txtPalabra.TextChanged += new System.EventHandler(this.txtPalabra_TextChanged);
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Bodoni MT Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(119, 341);
            this.btnContar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(230, 58);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "INICIAR";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lvVocales
            // 
            this.lvVocales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvVocales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CantidadVocales,
            this.Vocales});
            this.lvVocales.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVocales.HideSelection = false;
            this.lvVocales.Location = new System.Drawing.Point(646, 124);
            this.lvVocales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvVocales.Name = "lvVocales";
            this.lvVocales.Size = new System.Drawing.Size(333, 360);
            this.lvVocales.TabIndex = 2;
            this.lvVocales.UseCompatibleStateImageBehavior = false;
            this.lvVocales.View = System.Windows.Forms.View.Details;
            this.lvVocales.SelectedIndexChanged += new System.EventHandler(this.lvVocales_SelectedIndexChanged);
            // 
            // CantidadVocales
            // 
            this.CantidadVocales.DisplayIndex = 1;
            this.CantidadVocales.Text = "N° VOCALES";
            this.CantidadVocales.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar Palabra:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.DarkGray;
            this.btnSiguiente.Font = new System.Drawing.Font("Bodoni MT Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(119, 426);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(230, 58);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "ENCONTRAR VOCALES";
            // 
            // Vocales
            // 
            this.Vocales.DisplayIndex = 0;
            this.Vocales.Text = "VOCALES";
            this.Vocales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Vocales.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1224, 670);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvVocales);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtPalabra);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Vocales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.ListView lvVocales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader CantidadVocales;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Vocales;
    }
}

