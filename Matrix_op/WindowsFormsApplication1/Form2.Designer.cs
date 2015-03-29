namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericColumnas = new System.Windows.Forms.NumericUpDown();
            this.numericFilas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Columnas";
            // 
            // numericColumnas
            // 
            this.numericColumnas.Location = new System.Drawing.Point(277, 156);
            this.numericColumnas.Name = "numericColumnas";
            this.numericColumnas.Size = new System.Drawing.Size(85, 20);
            this.numericColumnas.TabIndex = 2;
            this.numericColumnas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericColumnas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericFilas
            // 
            this.numericFilas.Location = new System.Drawing.Point(277, 96);
            this.numericFilas.Name = "numericFilas";
            this.numericFilas.Size = new System.Drawing.Size(85, 20);
            this.numericFilas.TabIndex = 3;
            this.numericFilas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericFilas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(77, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Crear Nueva Matriz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear Matriz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(433, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericFilas);
            this.Controls.Add(this.numericColumnas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Nueva Matriz";
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericColumnas;
        private System.Windows.Forms.NumericUpDown numericFilas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;

    }
}