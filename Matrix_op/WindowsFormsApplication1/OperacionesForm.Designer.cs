namespace WindowsFormsApplication1
{
    partial class OperacionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperacionesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listbMatriz2 = new System.Windows.Forms.ListBox();
            this.comboOperacion = new System.Windows.Forms.ComboBox();
            this.listbMatriz1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelOp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataResultado = new System.Windows.Forms.DataGridView();
            this.cR_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelM2 = new System.Windows.Forms.Label();
            this.dataMatriz2 = new System.Windows.Forms.DataGridView();
            this.c2_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelM1 = new System.Windows.Forms.Label();
            this.dataMatriz1 = new System.Windows.Forms.DataGridView();
            this.c_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatriz1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listbMatriz2);
            this.groupBox1.Controls.Add(this.comboOperacion);
            this.groupBox1.Controls.Add(this.listbMatriz1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(239, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Realizar Operacion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(320, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "operacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(211, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccionar";
            // 
            // listbMatriz2
            // 
            this.listbMatriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbMatriz2.FormattingEnabled = true;
            this.listbMatriz2.ItemHeight = 18;
            this.listbMatriz2.Location = new System.Drawing.Point(476, 77);
            this.listbMatriz2.Name = "listbMatriz2";
            this.listbMatriz2.Size = new System.Drawing.Size(186, 148);
            this.listbMatriz2.TabIndex = 5;
            this.listbMatriz2.SelectedIndexChanged += new System.EventHandler(this.listbMatriz2_SelectedIndexChanged);
            // 
            // comboOperacion
            // 
            this.comboOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOperacion.FormattingEnabled = true;
            this.comboOperacion.Items.AddRange(new object[] {
            "+ Suma",
            "- Resta",
            "* Producto A x B",
            "* Producto B x A"});
            this.comboOperacion.Location = new System.Drawing.Point(221, 100);
            this.comboOperacion.Name = "comboOperacion";
            this.comboOperacion.Size = new System.Drawing.Size(190, 24);
            this.comboOperacion.TabIndex = 4;
            this.comboOperacion.SelectedIndexChanged += new System.EventHandler(this.comboOperacion_SelectedIndexChanged);
            // 
            // listbMatriz1
            // 
            this.listbMatriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbMatriz1.FormattingEnabled = true;
            this.listbMatriz1.ItemHeight = 18;
            this.listbMatriz1.Location = new System.Drawing.Point(6, 77);
            this.listbMatriz1.Name = "listbMatriz1";
            this.listbMatriz1.Size = new System.Drawing.Size(186, 148);
            this.listbMatriz1.TabIndex = 3;
            this.listbMatriz1.SelectedIndexChanged += new System.EventHandler(this.listbMatriz1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(561, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matriz B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matriz A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones con Matrices";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.labelOp);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dataResultado);
            this.groupBox2.Controls.Add(this.labelM2);
            this.groupBox2.Controls.Add(this.dataMatriz2);
            this.groupBox2.Controls.Add(this.labelM1);
            this.groupBox2.Controls.Add(this.dataMatriz1);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(432, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "=";
            // 
            // labelOp
            // 
            this.labelOp.AutoSize = true;
            this.labelOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOp.ForeColor = System.Drawing.Color.Red;
            this.labelOp.Location = new System.Drawing.Point(211, 16);
            this.labelOp.Name = "labelOp";
            this.labelOp.Size = new System.Drawing.Size(0, 24);
            this.labelOp.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(504, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Resultado";
            // 
            // dataResultado
            // 
            this.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cR_1});
            this.dataResultado.Location = new System.Drawing.Point(453, 44);
            this.dataResultado.Name = "dataResultado";
            this.dataResultado.ReadOnly = true;
            this.dataResultado.Size = new System.Drawing.Size(209, 179);
            this.dataResultado.TabIndex = 11;
            // 
            // cR_1
            // 
            this.cR_1.HeaderText = "cR_1";
            this.cR_1.Name = "cR_1";
            this.cR_1.ReadOnly = true;
            this.cR_1.Width = 60;
            // 
            // labelM2
            // 
            this.labelM2.AutoSize = true;
            this.labelM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM2.ForeColor = System.Drawing.Color.Black;
            this.labelM2.Location = new System.Drawing.Point(283, 16);
            this.labelM2.Name = "labelM2";
            this.labelM2.Size = new System.Drawing.Size(91, 25);
            this.labelM2.TabIndex = 10;
            this.labelM2.Text = "Matriz B";
            // 
            // dataMatriz2
            // 
            this.dataMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatriz2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c2_1});
            this.dataMatriz2.Location = new System.Drawing.Point(221, 44);
            this.dataMatriz2.Name = "dataMatriz2";
            this.dataMatriz2.ReadOnly = true;
            this.dataMatriz2.Size = new System.Drawing.Size(209, 179);
            this.dataMatriz2.TabIndex = 9;
            // 
            // c2_1
            // 
            this.c2_1.HeaderText = "c2_1";
            this.c2_1.Name = "c2_1";
            this.c2_1.ReadOnly = true;
            this.c2_1.Width = 50;
            // 
            // labelM1
            // 
            this.labelM1.AutoSize = true;
            this.labelM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM1.ForeColor = System.Drawing.Color.Black;
            this.labelM1.Location = new System.Drawing.Point(64, 16);
            this.labelM1.Name = "labelM1";
            this.labelM1.Size = new System.Drawing.Size(91, 25);
            this.labelM1.TabIndex = 8;
            this.labelM1.Text = "Matriz A";
            // 
            // dataMatriz1
            // 
            this.dataMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatriz1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_1});
            this.dataMatriz1.Location = new System.Drawing.Point(6, 44);
            this.dataMatriz1.Name = "dataMatriz1";
            this.dataMatriz1.ReadOnly = true;
            this.dataMatriz1.Size = new System.Drawing.Size(209, 179);
            this.dataMatriz1.TabIndex = 0;
            // 
            // c_1
            // 
            this.c_1.HeaderText = "c_1";
            this.c_1.Name = "c_1";
            this.c_1.ReadOnly = true;
            this.c_1.Width = 50;
            // 
            // OperacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(696, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperacionesForm";
            this.Text = "Operaciones Matrices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatriz1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listbMatriz2;
        private System.Windows.Forms.ComboBox comboOperacion;
        private System.Windows.Forms.ListBox listbMatriz1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataMatriz1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelOp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataResultado;
        private System.Windows.Forms.Label labelM2;
        private System.Windows.Forms.DataGridView dataMatriz2;
        private System.Windows.Forms.Label labelM1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cR_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2_1;
    }
}