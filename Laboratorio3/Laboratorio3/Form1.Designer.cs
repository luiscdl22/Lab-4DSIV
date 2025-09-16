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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(301, 83);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(205, 22);
            this.txtPalabra.TabIndex = 0;
            this.txtPalabra.TextChanged += new System.EventHandler(this.txtPalabra_TextChanged);
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(403, 135);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(103, 30);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "INICIAR";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lvVocales
            // 
            this.lvVocales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvVocales.HideSelection = false;
            this.lvVocales.Location = new System.Drawing.Point(122, 179);
            this.lvVocales.Name = "lvVocales";
            this.lvVocales.Size = new System.Drawing.Size(279, 226);
            this.lvVocales.TabIndex = 2;
            this.lvVocales.UseCompatibleStateImageBehavior = false;
            this.lvVocales.View = System.Windows.Forms.View.Details;
            this.lvVocales.SelectedIndexChanged += new System.EventHandler(this.lvVocales_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "VOCALES";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "N° VOCALES";
            this.columnHeader2.Width = 219;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar Palabra:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(394, 411);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(152, 30);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "ENCONTRAR VOCALES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 508);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvVocales);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtPalabra);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label2;
    }
}

