namespace WindowsFormsApplication1
{
    partial class FormOperaNumMa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperaNumMa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataMatriz1 = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboOperacion = new System.Windows.Forms.ComboBox();
            this.listbMatriz1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelOp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataResultado = new System.Windows.Forms.DataGridView();
            this.cR_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatriz1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataMatriz1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboOperacion);
            this.groupBox1.Controls.Add(this.listbMatriz1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(563, 90);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 24);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(209, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contenido Matriz";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(475, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Realizar Operacion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataMatriz1
            // 
            this.dataMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatriz1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1});
            this.dataMatriz1.Location = new System.Drawing.Point(163, 78);
            this.dataMatriz1.Name = "dataMatriz1";
            this.dataMatriz1.ReadOnly = true;
            this.dataMatriz1.Size = new System.Drawing.Size(280, 166);
            this.dataMatriz1.TabIndex = 9;
            // 
            // c1
            // 
            this.c1.HeaderText = "c1";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Width = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(458, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Operacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(583, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero";
            // 
            // comboOperacion
            // 
            this.comboOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOperacion.FormattingEnabled = true;
            this.comboOperacion.Items.AddRange(new object[] {
            "+ Suma",
            "- Resta",
            "* Producto",
            "/ Division",
            "><Inversa",
            "~ Gauss"});
            this.comboOperacion.Location = new System.Drawing.Point(449, 91);
            this.comboOperacion.Name = "comboOperacion";
            this.comboOperacion.Size = new System.Drawing.Size(108, 24);
            this.comboOperacion.TabIndex = 11;
            this.comboOperacion.SelectedIndexChanged += new System.EventHandler(this.comboOperacion_SelectedIndexChanged);
            // 
            // listbMatriz1
            // 
            this.listbMatriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbMatriz1.FormattingEnabled = true;
            this.listbMatriz1.ItemHeight = 18;
            this.listbMatriz1.Location = new System.Drawing.Point(12, 78);
            this.listbMatriz1.Name = "listbMatriz1";
            this.listbMatriz1.Size = new System.Drawing.Size(145, 166);
            this.listbMatriz1.TabIndex = 10;
            this.listbMatriz1.SelectedIndexChanged += new System.EventHandler(this.listbMatriz1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Matriz A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operaciones de Matriz-Numero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelOp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataResultado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Operacion realizada : ";
            // 
            // labelOp
            // 
            this.labelOp.AutoSize = true;
            this.labelOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelOp.Location = new System.Drawing.Point(176, 140);
            this.labelOp.Name = "labelOp";
            this.labelOp.Size = new System.Drawing.Size(0, 24);
            this.labelOp.TabIndex = 15;
            this.labelOp.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(79, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Resultado:      - - - - - - - > - >";
            // 
            // dataResultado
            // 
            this.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cR_1});
            this.dataResultado.Location = new System.Drawing.Point(364, 19);
            this.dataResultado.Name = "dataResultado";
            this.dataResultado.ReadOnly = true;
            this.dataResultado.Size = new System.Drawing.Size(320, 189);
            this.dataResultado.TabIndex = 12;
            // 
            // cR_1
            // 
            this.cR_1.HeaderText = "cR_1";
            this.cR_1.Name = "cR_1";
            this.cR_1.ReadOnly = true;
            this.cR_1.Width = 60;
            // 
            // FormOperaNumMa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOperaNumMa";
            this.Text = "Operciones Numero-Matriz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatriz1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboOperacion;
        private System.Windows.Forms.ListBox listbMatriz1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataMatriz1;
        private System.Windows.Forms.Label labelOp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cR_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
    }
}