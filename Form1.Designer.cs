namespace tarea3
{
    partial class Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sumar1 = new System.Windows.Forms.Button();
            this.restar2 = new System.Windows.Forms.Button();
            this.dividir4 = new System.Windows.Forms.Button();
            this.multiplicar3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(534, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora que realiza operaciones vasicas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 153);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 28);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 249);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 28);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "valor 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "valor 2";
            // 
            // sumar1
            // 
            this.sumar1.Location = new System.Drawing.Point(168, 355);
            this.sumar1.Margin = new System.Windows.Forms.Padding(4);
            this.sumar1.Name = "sumar1";
            this.sumar1.Size = new System.Drawing.Size(201, 45);
            this.sumar1.TabIndex = 5;
            this.sumar1.Text = "Sumar";
            this.sumar1.UseVisualStyleBackColor = true;
            this.sumar1.Click += new System.EventHandler(this.sumar1_Click);
            // 
            // restar2
            // 
            this.restar2.Location = new System.Drawing.Point(377, 355);
            this.restar2.Margin = new System.Windows.Forms.Padding(4);
            this.restar2.Name = "restar2";
            this.restar2.Size = new System.Drawing.Size(201, 45);
            this.restar2.TabIndex = 6;
            this.restar2.Text = "Restar";
            this.restar2.UseVisualStyleBackColor = true;
            this.restar2.Click += new System.EventHandler(this.restar2_Click);
            // 
            // dividir4
            // 
            this.dividir4.Location = new System.Drawing.Point(795, 355);
            this.dividir4.Margin = new System.Windows.Forms.Padding(4);
            this.dividir4.Name = "dividir4";
            this.dividir4.Size = new System.Drawing.Size(201, 45);
            this.dividir4.TabIndex = 7;
            this.dividir4.Text = "Dividir";
            this.dividir4.UseVisualStyleBackColor = true;
            this.dividir4.Click += new System.EventHandler(this.dividir4_Click);
            // 
            // multiplicar3
            // 
            this.multiplicar3.Location = new System.Drawing.Point(586, 355);
            this.multiplicar3.Margin = new System.Windows.Forms.Padding(4);
            this.multiplicar3.Name = "multiplicar3";
            this.multiplicar3.Size = new System.Drawing.Size(201, 45);
            this.multiplicar3.TabIndex = 8;
            this.multiplicar3.Text = "Multiplicar";
            this.multiplicar3.UseVisualStyleBackColor = true;
            this.multiplicar3.Click += new System.EventHandler(this.multiplicar3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultado:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(666, 253);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 28);
            this.textBox3.TabIndex = 10;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1109, 418);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.multiplicar3);
            this.Controls.Add(this.dividir4);
            this.Controls.Add(this.restar2);
            this.Controls.Add(this.sumar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sumar1;
        private System.Windows.Forms.Button restar2;
        private System.Windows.Forms.Button dividir4;
        private System.Windows.Forms.Button multiplicar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
    }
}

