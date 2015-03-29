namespace WindowsFormsApplication1
{
    partial class FormAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxMatricesResult = new System.Windows.Forms.ListBox();
            this.listBoxMatricesOpera = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataMatriz2 = new System.Windows.Forms.DataGridView();
            this.resultOP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveMatriz = new System.Windows.Forms.Button();
            this.buttonDelCol = new System.Windows.Forms.Button();
            this.buttonDelFil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddColum = new System.Windows.Forms.Button();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.labelMaOp = new System.Windows.Forms.Label();
            this.dataMatriz1 = new System.Windows.Forms.DataGridView();
            this.e1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatriz1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBoxMatricesResult);
            this.groupBox1.Controls.Add(this.listBoxMatricesOpera);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matrices Resultado -No Editables";
            // 
            // listBoxMatricesResult
            // 
            this.listBoxMatricesResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMatricesResult.FormattingEnabled = true;
            this.listBoxMatricesResult.ItemHeight = 18;
            this.listBoxMatricesResult.Location = new System.Drawing.Point(375, 45);
            this.listBoxMatricesResult.Name = "listBoxMatricesResult";
            this.listBoxMatricesResult.Size = new System.Drawing.Size(179, 166);
            this.listBoxMatricesResult.TabIndex = 2;
            this.listBoxMatricesResult.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBoxMatricesOpera
            // 
            this.listBoxMatricesOpera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMatricesOpera.FormattingEnabled = true;
            this.listBoxMatricesOpera.ItemHeight = 18;
            this.listBoxMatricesOpera.Location = new System.Drawing.Point(9, 47);
            this.listBoxMatricesOpera.Name = "listBoxMatricesOpera";
            this.listBoxMatricesOpera.Size = new System.Drawing.Size(179, 166);
            this.listBoxMatricesOpera.TabIndex = 1;
            this.listBoxMatricesOpera.SelectedIndexChanged += new System.EventHandler(this.listBoxMatricesOpera_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrices para Operar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataMatriz2);
            this.groupBox2.Controls.Add(this.buttonSaveMatriz);
            this.groupBox2.Controls.Add(this.buttonDelCol);
            this.groupBox2.Controls.Add(this.buttonDelFil);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonAddColum);
            this.groupBox2.Controls.Add(this.buttonAddRow);
            this.groupBox2.Controls.Add(this.labelMaOp);
            this.groupBox2.Controls.Add(this.dataMatriz1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataMatriz2
            // 
            this.dataMatriz2.AllowUserToDeleteRows = false;
            this.dataMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatriz2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resultOP1});
            this.dataMatriz2.Location = new System.Drawing.Point(387, 52);
            this.dataMatriz2.Name = "dataMatriz2";
            this.dataMatriz2.ReadOnly = true;
            this.dataMatriz2.Size = new System.Drawing.Size(255, 168);
            this.dataMatriz2.TabIndex = 12;
            // 
            // resultOP1
            // 
            this.resultOP1.HeaderText = "c1";
            this.resultOP1.Name = "resultOP1";
            this.resultOP1.ReadOnly = true;
            this.resultOP1.Width = 50;
            // 
            // buttonSaveMatriz
            // 
            this.buttonSaveMatriz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveMatriz.Location = new System.Drawing.Point(12, 17);
            this.buttonSaveMatriz.Name = "buttonSaveMatriz";
            this.buttonSaveMatriz.Size = new System.Drawing.Size(129, 29);
            this.buttonSaveMatriz.TabIndex = 11;
            this.buttonSaveMatriz.Text = "Guardar Cambios";
            this.buttonSaveMatriz.UseVisualStyleBackColor = true;
            this.buttonSaveMatriz.Click += new System.EventHandler(this.buttonSaveMatriz_Click);
            // 
            // buttonDelCol
            // 
            this.buttonDelCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelCol.Location = new System.Drawing.Point(282, 191);
            this.buttonDelCol.Name = "buttonDelCol";
            this.buttonDelCol.Size = new System.Drawing.Size(72, 29);
            this.buttonDelCol.TabIndex = 10;
            this.buttonDelCol.Text = "Columna";
            this.buttonDelCol.UseVisualStyleBackColor = true;
            this.buttonDelCol.Click += new System.EventHandler(this.buttonDelCol_Click);
            // 
            // buttonDelFil
            // 
            this.buttonDelFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelFil.Location = new System.Drawing.Point(282, 156);
            this.buttonDelFil.Name = "buttonDelFil";
            this.buttonDelFil.Size = new System.Drawing.Size(72, 29);
            this.buttonDelFil.TabIndex = 9;
            this.buttonDelFil.Text = "Fila";
            this.buttonDelFil.UseVisualStyleBackColor = true;
            this.buttonDelFil.Click += new System.EventHandler(this.buttonDelFil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(290, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eliminar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(293, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Añadir";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonAddColum
            // 
            this.buttonAddColum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddColum.Location = new System.Drawing.Point(282, 95);
            this.buttonAddColum.Name = "buttonAddColum";
            this.buttonAddColum.Size = new System.Drawing.Size(72, 29);
            this.buttonAddColum.TabIndex = 6;
            this.buttonAddColum.Text = "Columna";
            this.buttonAddColum.UseVisualStyleBackColor = true;
            this.buttonAddColum.Click += new System.EventHandler(this.buttonAddColum_Click);
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRow.Location = new System.Drawing.Point(282, 60);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(72, 29);
            this.buttonAddRow.TabIndex = 5;
            this.buttonAddRow.Text = "Fila";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // labelMaOp
            // 
            this.labelMaOp.AutoSize = true;
            this.labelMaOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaOp.Location = new System.Drawing.Point(192, 33);
            this.labelMaOp.Name = "labelMaOp";
            this.labelMaOp.Size = new System.Drawing.Size(61, 16);
            this.labelMaOp.TabIndex = 4;
            this.labelMaOp.Text = "Matriz 0";
            // 
            // dataMatriz1
            // 
            this.dataMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatriz1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.e1});
            this.dataMatriz1.Location = new System.Drawing.Point(9, 52);
            this.dataMatriz1.MultiSelect = false;
            this.dataMatriz1.Name = "dataMatriz1";
            this.dataMatriz1.Size = new System.Drawing.Size(267, 170);
            this.dataMatriz1.TabIndex = 0;
            // 
            // e1
            // 
            this.e1.HeaderText = "c1";
            this.e1.Name = "e1";
            this.e1.Width = 50;
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administracion de Matrices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatriz1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxMatricesResult;
        private System.Windows.Forms.ListBox listBoxMatricesOpera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataMatriz1;
        private System.Windows.Forms.Label labelMaOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn e1;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.Button buttonAddColum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDelCol;
        private System.Windows.Forms.Button buttonDelFil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSaveMatriz;
        private System.Windows.Forms.DataGridView dataMatriz2;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultOP1;
    }
}