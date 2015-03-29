/*<Copyright(C) 2015 Eladio Acosta> * 
 * 
 * This file is part of Matrix_Operations.

    Matrix_Operations is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Matrix_Operations is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Matrix_Operations.  If not, see <http://www.gnu.org/licenses/>.
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/********************************
 Autor: ELADIO ACOSTA VALDAYO
 First date: 16/03/2015
 Last  date: 18/03/2015
 Version: 1.1 - BETA
********************************/
namespace WindowsFormsApplication1
{
    /// <summary>
    /// Form to operate with matrix and Number
    /// Number - Decimal
    /// </summary>
    public partial class FormOperaNumMa : Form
    {
        /// <summary>
        /// Main data Source
        /// </summary>
        prin datos;
        //-----------------------------------------------------------------
        /// <summary>
        /// Builder of Form to operate with matrix and Number
        /// </summary>
        /// <param name="data">Main data source</param>
        public FormOperaNumMa(prin data, Color fondo, Color letras)
        {
            InitializeComponent();
            datos = data;
            cargaOperaciones();
            selectedIndexFirst();
            this.BackColor = fondo;
            this.ForeColor = letras;
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// Not used
        /// </summary>
        private void label7_Click(object sender, EventArgs e) { }        
        //-----------------------------------------------------------------
        /// <summary>
        /// First load of combo box
        /// make sure that no empty display
        /// </summary>
        private void cargaComboBox()
        {
            comboOperacion.Text = "+ Suma";
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// First load of listBoxS
        /// make sure that no empty ListBox
        /// </summary>
        private void cargaListBoxs()
        {
            int matrix = datos.matrices.Count;
            for (int i = 0; i < matrix; i++) // recorrer matrices
            {
                int fil = datos.matrices[i].GetLength(0);//filas
                int col = datos.matrices[i].GetLength(1);//columnas

                string text = string.Format("Matriz{0}: {1}x{2}", i + 1, fil, col);//formato

                listbMatriz1.Items.Add(text);       //añadir a listBoxS
            }
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// Call process to load ListBoxS and Combo Box
        /// </summary>
        private void cargaOperaciones()
        {
            cargaComboBox();
            cargaListBoxs();
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// Make datagrid with lenght of selected matrix by index
        /// build rows and cells with lenghts of the selected matrix
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listbMatriz1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataMatriz1.AllowUserToAddRows = true;
            dataMatriz1.RowCount = 1;
            dataMatriz1.ColumnCount = 1;
            int select = listbMatriz1.SelectedIndex; //posicion seleccionada
            int fil = datos.matrices[select].GetLength(0);//filas
            int col = datos.matrices[select].GetLength(1);//columnas
            //crea datagrid ------------------------------------------
            System.Windows.Forms.DataGridViewTextBoxColumn Columna;

            for (int i = 1; i < fil; i++)         //añade columnas al datagrid
            {
                Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                Columna.Width = 50;
                Columna.HeaderText = "c " + (i + 1);
                this.dataMatriz1.Columns.Add(Columna);
            }

            for (int j = 0; j < col; j++)         //añade filas al datagrid
                this.dataMatriz1.Rows.Add();

            llenaGrid(this.dataMatriz1, datos.matrices[select]); // lena datagrid

            dataMatriz1.AllowUserToAddRows = false;
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// send data to datagrid
        /// </summary>
        /// <param name="data">datagridview for FULL</param>DataGridView
        /// <param name="matrix">matrix that show in DataGrid</param>float[,]
        private void llenaGrid(DataGridView data, float[,] matrix)
        {
            int col = matrix.GetLength(0); //columnas
            int fil = matrix.GetLength(1); //filas
            //recorrer matriz
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < fil; j++)
                {
                    float matr = matrix[i, j];
                    data[i, j].Value = matr;
                }
            }
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// select first index on the listBox
        /// </summary>
        private void selectedIndexFirst()
        {
            try
            {
                this.listbMatriz1.SelectedIndex = 0;
            }
            catch (Exception) { }
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// get selectedMatrix, Value of number, Operation
        /// and Call Process to Make Operations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int ma1 = listbMatriz1.SelectedIndex;       // indice de matriz seleccionada
            decimal num = numericUpDown1.Value;         // numero de operacion
            int opera = comboOperacion.SelectedIndex;   // indice de operacion a realizar
            realizarOperacion(ma1, num, opera);         // realizar operacion     
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// Matrix Operation with NUmber - Switch to diferent operation
        /// </summary>
        /// <param name="ma1">Indice de matriz seleccionada</param>
        /// <param name="num">numero necesario para la operacion</param>
        /// <param name="opera">operacion a realizar</param>
        private void realizarOperacion(int ma1, decimal num, int opera)
        {
            //todo - mostrar erro cuando sea necesrio- aora se muestra siempre
            // Guardar resultados en el objeto
            string err = "";
            //****************
            if (opera == 0)     //sumar----------
            {
                realizarSumaNum(ma1, num);                
            }
            //****************
            if (opera == 1)     //restar--------
            {
                realizarRestaNum(ma1, num);
            }
            //****************
            if (opera == 2)     //producto------
            {
                realizarMultiNum(ma1, num);
            }
            //****************
            if (opera == 3)         // division
            {
                realizarDiviNum(ma1, num);
            }
            //****************
            if (opera == 4)         // Inversa
            {
                realizarInversa(ma1);
            }
            //****************
            if (opera == 5)         // Gauss
            {
                realizarGauss(ma1);
            }
            //****************
            if (err != "")
                MessageBox.Show(err, "Fallo de Dimensiones", MessageBoxButtons.OK);
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// Make plus operation
        /// </summary>
        /// <param name="ma1">index of first matrix</param>
        /// <param name="num">index of second matrix of operation</param>
        private void realizarSumaNum(int ma1, decimal num)
        {
            float [,]aux = datos.opSumaNum(ma1, num);
            creaDataResult(datos.matrices[ma1]);
            llenaGrid(this.dataResultado, aux);
            this.labelOp.Text = "Matriz" + (ma1 + 1) + "  +  " + num.ToString();
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// Make less operation
        /// </summary>
        /// <param name="ma1">index of first matrix</param>
        /// <param name="num">index of second matrix of operation</param>
        private void realizarRestaNum(int ma1, decimal num)
        {
            float[,] aux = datos.opRestaNum(ma1, num);
            creaDataResult(datos.matrices[ma1]);
            llenaGrid(this.dataResultado, aux);
            this.labelOp.Text = "Matriz" + (ma1 + 1) + "  -  " + num.ToString();
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// Make multiply operation
        /// </summary>
        /// <param name="ma1">index of first matrix</param>
        /// <param name="num">index of second matrix of operation</param>
        private void realizarMultiNum(int ma1, decimal num)
        {
            float[,] aux = datos.opMultiNum(ma1, num);
            creaDataResult(datos.matrices[ma1]);
            llenaGrid(this.dataResultado, aux);
            this.labelOp.Text = "Matriz" + (ma1 + 1) + "  x  " + num.ToString();
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// Make div operation
        /// </summary>
        /// <param name="ma1">index of first matrix</param>
        /// <param name="num">index of second matrix of operation</param>
        private void realizarDiviNum(int ma1, decimal num)
        {
            float[,] aux = datos.opDiviNum(ma1, num);
            creaDataResult(aux);
            llenaGrid(this.dataResultado, aux);
            this.labelOp.Text = "Matriz" + (ma1 + 1) + "  %  " + num.ToString();
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// Realizar opreracion de matriz inversa
        /// Check - Matriz sea cuadrada y det distinto de 0
        /// </summary>
        /// <param name="ma1">Indice de matriz seleccionada</param>
        private void realizarInversa(int ma1)
        {
            if (datos.cuadrada(this.datos.matrices[ma1])) 
            {
                float deter = 0;  //--  determinante
                float[,] aux = datos.Inversa(datos.matrices[ma1], ref deter);
                //-check determinante ---------------
                if (deter != 0)
                {
                    creaDataResult(aux);
                    llenaGrid(this.dataResultado, aux);
                    inversa invAux = new inversa(ma1, aux, deter);
                    this.datos.opera.inversas.Add(invAux);
                    this.labelOp.Text = "Matriz" + (ma1 + 1) + " inversa\nDeterminante -> " + deter.ToString();
                }
                else // operacion no permitida
                {
                    string err = "No Permitido\nDeterminante = 0";
                    this.labelOp.Text = err;
                    MessageBox.Show(err, "Operacion no Permitida", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Matriz no Cuadrada", "Operacion no Permitida", MessageBoxButtons.OK);
            }
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// Metodo de gauss
        /// </summary>
        /// <param name="ma1">Indice de matriz utilizada</param>
        private void realizarGauss(int ma1)
        {
            float[,] aux = datos.Gauss(datos.matrices[ma1]);
            creaDataResult(aux);
            llenaGrid(this.dataResultado, aux);
            gauss auxGauss = new gauss(ma1, aux);
            datos.opera.mGauss.Add(auxGauss);
            this.labelOp.Text = "Matriz Resultado\nMetodo de gauss";
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// resize datagrid to matrix and call to full data
        /// : llenaGrid(DataGridView d, float[,] m) 
        /// </summary>
        /// <param name="data">matrix for datagrid</param>
        private void creaDataResult(float[,] data)
        {
            dataResultado.AllowUserToAddRows = true;
            dataResultado.RowCount = 1;
            dataResultado.ColumnCount = 1;
            int fil = data.GetLength(0);//filas
            int col = data.GetLength(1);//columnas
            //crea datagrid ------------------------------------------
            System.Windows.Forms.DataGridViewTextBoxColumn Columna;

            for (int i = 1; i < fil; i++)         //añade columnas al datagrid
            {
                Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                Columna.Width = 60;
                Columna.HeaderText = "Cr " + (i + 1);
                this.dataResultado.Columns.Add(Columna);
            }

            for (int j = 0; j < col; j++)         //añade filas al datagrid
                this.dataResultado.Rows.Add();

            llenaGrid(dataResultado, data); // lena datagrid

            dataResultado.AllowUserToAddRows = false;
        }
        //-----------------------------------------------------------------
        /// <summary>
        /// Activa o desactiva numericUpDown1, segun requiera la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.comboOperacion.SelectedIndex;
            if (index == 4 || index == 5)
                this.numericUpDown1.Enabled = false;
            else
                this.numericUpDown1.Enabled = true;
        }
        //-----------------------------------------------------------------
    }
}
/*<Copyright(C) 2015 Eladio Acosta> * 
 * 
 * This file is part of Matrix_Operations.

    Matrix_Operations is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Matrix_Operations is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Matrix_Operations.  If not, see <http://www.gnu.org/licenses/>.
 * */