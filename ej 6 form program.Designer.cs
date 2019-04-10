namespace WindowsFormsApp2
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
            this.lbllabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPalabras = new System.Windows.Forms.Label();
            this.lblPalabras1 = new System.Windows.Forms.Label();
            this.lblFinalizaLA = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVeintePalabras = new System.Windows.Forms.Button();
            this.btnCienLetras = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbllabel1
            // 
            this.lbllabel1.AutoSize = true;
            this.lbllabel1.Location = new System.Drawing.Point(22, 22);
            this.lbllabel1.Name = "lbllabel1";
            this.lbllabel1.Size = new System.Drawing.Size(48, 13);
            this.lbllabel1.TabIndex = 0;
            this.lbllabel1.Text = "Palabras";
            this.lbllabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Finaliza en LA";
            // 
            // lblPalabras
            // 
            this.lblPalabras.AutoSize = true;
            this.lblPalabras.Location = new System.Drawing.Point(22, 82);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(48, 13);
            this.lblPalabras.TabIndex = 2;
            this.lblPalabras.Text = "Palabras";
            // 
            // lblPalabras1
            // 
            this.lblPalabras1.AutoSize = true;
            this.lblPalabras1.Location = new System.Drawing.Point(96, 22);
            this.lblPalabras1.Name = "lblPalabras1";
            this.lblPalabras1.Size = new System.Drawing.Size(13, 13);
            this.lblPalabras1.TabIndex = 3;
            this.lblPalabras1.Text = "0";
            this.lblPalabras1.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFinalizaLA
            // 
            this.lblFinalizaLA.AutoSize = true;
            this.lblFinalizaLA.Location = new System.Drawing.Point(96, 52);
            this.lblFinalizaLA.Name = "lblFinalizaLA";
            this.lblFinalizaLA.Size = new System.Drawing.Size(13, 13);
            this.lblFinalizaLA.TabIndex = 4;
            this.lblFinalizaLA.Text = "0";
            this.lblFinalizaLA.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(25, 98);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(372, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "3 primeras \"o\"";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVeintePalabras
            // 
            this.btnVeintePalabras.Location = new System.Drawing.Point(342, 135);
            this.btnVeintePalabras.Name = "btnVeintePalabras";
            this.btnVeintePalabras.Size = new System.Drawing.Size(75, 41);
            this.btnVeintePalabras.TabIndex = 7;
            this.btnVeintePalabras.Text = "20 palabras";
            this.btnVeintePalabras.UseVisualStyleBackColor = true;
            this.btnVeintePalabras.Click += new System.EventHandler(this.txtVeintePalabras_Click);
            // 
            // btnCienLetras
            // 
            this.btnCienLetras.Location = new System.Drawing.Point(261, 135);
            this.btnCienLetras.Name = "btnCienLetras";
            this.btnCienLetras.Size = new System.Drawing.Size(75, 41);
            this.btnCienLetras.TabIndex = 8;
            this.btnCienLetras.Text = "100 letras";
            this.btnCienLetras.UseVisualStyleBackColor = true;
            this.btnCienLetras.Click += new System.EventHandler(this.btnCienLetras_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "3 primeras \"a\"";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Location = new System.Drawing.Point(25, 193);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(372, 184);
            this.rtxtTexto.TabIndex = 10;
            this.rtxtTexto.Text = "";
            this.rtxtTexto.TextChanged += new System.EventHandler(this.rtxtTexto_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtTexto);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCienLetras);
            this.Controls.Add(this.btnVeintePalabras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblFinalizaLA);
            this.Controls.Add(this.lblPalabras1);
            this.Controls.Add(this.lblPalabras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbllabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPalabras;
        private System.Windows.Forms.Label lblPalabras1;
        private System.Windows.Forms.Label lblFinalizaLA;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVeintePalabras;
        private System.Windows.Forms.Button btnCienLetras;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox rtxtTexto;
    }
}

