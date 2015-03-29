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
 Fecha creación: 10/03/2015
 Última modificación: 14/03/2015
 Versión: 1.1
*********************************/
namespace WindowsFormsApplication1
{
    public partial class OperacionesForm : Form
    {
        //----------------------------------------------------------------------------------------------
        prin datos;     // objeto de datos principal
        int opera = 0;  // operacion seleccionada
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dato">Objeto principal con datos de aplicacion</param>
        public OperacionesForm(prin dato, Color fondo, Color letras)
        {
            InitializeComponent();
            datos = dato;
            cargaOperaciones();
            selectedIndexFirst();
            this.BackColor = fondo;
            this.ForeColor = letras;
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Selecciona el primer elemento en ambos lsitbox
        /// </summary>
        private void selectedIndexFirst() 
        {
            try
            {
                this.listbMatriz1.SelectedIndex = 0;
                this.listbMatriz2.SelectedIndex = 0;
            }
            catch (Exception) { }
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Llama metodos de carga - ComboBox y ListBox
        /// </summary>
        private void cargaOperaciones() 
        {
            cargaComboBox();
            cargaListBoxs();
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Carga info en los listbox
        /// </summary>
        private void cargaListBoxs() 
        {
            int matrix = datos.matrices.Count;
            for (int i = 0; i < matrix; i++) // recorrer matrices
            {
                int fil = datos.matrices[i].GetLength(0);//filas
                int col = datos.matrices[i].GetLength(1);//columnas

                string text = string.Format("Matriz{0}: {1}x{2}", i+1, fil, col);//formato

                listbMatriz1.Items.Add(text);       //añadir a listBoxS
                listbMatriz2.Items.Add(text);
            }
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Carga info en comboBox
        /// </summary>
        private void cargaComboBox() 
        {
            comboOperacion.Text = "+ Suma";            
        }       
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// adapta datagrid a la matriz y ordena llenar con datos: llenaGrid(DataGridView d, float[,] m) 
        /// </summary>
        /// <param name="data">matriz que se utilizara</param>
        private void listbMatriz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataMatriz2.AllowUserToAddRows = true;
            dataMatriz2.RowCount = 1;
            dataMatriz2.ColumnCount = 1;
            int select = listbMatriz2.SelectedIndex; //posicion seleccionada
            int fil = datos.matrices[select].GetLength(0);//filas
            int col = datos.matrices[select].GetLength(1);//columnas
            //crea datagrid ------------------------------------------
            System.Windows.Forms.DataGridViewTextBoxColumn Columna;

            for (int i = 1; i < fil; i++)         //añade columnas al datagrid
            {
                Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                Columna.Width = 50;
                Columna.HeaderText = "C2_ " + (i + 1);
                this.dataMatriz2.Columns.Add(Columna);
            }

            for (int j = 0; j < col; j++)         //añade filas al datagrid
                this.dataMatriz2.Rows.Add();

            llenaGrid(dataMatriz2, datos.matrices[select]); // lena datagrid

            dataMatriz2.AllowUserToAddRows = false;
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// adapta datagrid a la matriz y ordena llenar con datos: llenaGrid(DataGridView d, float[,] m) 
        /// </summary>
        /// <param name="data">matriz que se utilizara</param>
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
                Columna.HeaderText = "C_ " + (i + 1);
                this.dataMatriz1.Columns.Add(Columna);
            }

            for (int j = 0; j < col; j++)         //añade filas al datagrid
                this.dataMatriz1.Rows.Add();

            llenaGrid(dataMatriz1, datos.matrices[select]); // lena datagrid

            dataMatriz1.AllowUserToAddRows = false;
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// adapta datagrid a la matriz y ordena llenar con datos: llenaGrid(DataGridView d, float[,] m) 
        /// </summary>
        /// <param name="data">matriz que se utilizara</param>
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
                Columna.HeaderText = "C_ " + (i + 1);
                this.dataResultado.Columns.Add(Columna);
            }

            for (int j = 0; j < col; j++)         //añade filas al datagrid
                this.dataResultado.Rows.Add();

            llenaGrid(dataResultado, data); // lena datagrid

            dataResultado.AllowUserToAddRows = false;
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// pasa datos a un datagrid
        /// </summary>
        /// <param name="data">datagridview que queremos llenar</param>DataGridView
        /// <param name="matrix">matriz que se mostrara en el grid</param>float[,]
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
                    data[i,j].Value = matr;
                }
            }
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// not used
        /// </summary>
        private void vaciarDatagrid1(DataGridView data) { }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Guarda en variable Opera el idice seleccionado
        /// INDICE UTILIZADO COMO SELECTOR DE OPERACION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            opera = comboOperacion.SelectedIndex;
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Obtiene idice selectIndex in the listBoxS, 
        /// and call to process -realizarOperacion()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int ma1 = listbMatriz1.SelectedIndex;
            int ma2 = listbMatriz2.SelectedIndex;
            realizarOperacion(ma1, ma2, opera);  // realizar operacion           
        }                
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// switch to diferents operations based on the -Int - Oprea
        /// and call right process to make operation
        /// </summary>
        /// <param name="ma1"></param>
        /// <param name="ma2"></param>
        /// <param name="opera"></param>
        private void realizarOperacion(int ma1, int ma2, int opera) 
        {
            //todo - mostrar erro cuando sea necesrio- aora se muestra siempre
            string err = "";
            //********************************************************
            if (opera == 0)     //sumar----------
            {
                if (datos.check(ma1, ma2))  
                {
                    this.labelOp.Text = "+";                    
                    realizarSuma(ma1, ma2);
                }
                else  {
                    err = "No Coinciden las dimensiones de las para esta operacion\n\n" +
                                "\tEj: 3x3 + 3x3.\n\n\tEj: 3x2 + 3x2";
                }
            }
            //********************************************************
            if (opera == 1)     //restar--------
            {
                if (datos.check(ma1, ma2))
                {
                    this.labelOp.Text = "-";                    
                    realizarResta(ma1, ma2);
                }
                else  {
                    err = "No Coinciden las dimensiones de las para esta operacion\n\n" +
                                "\tEj: 3x3 - 3x3.\n\n\tEj: 3x2 - 3x2";                    
                }
            }
            //********************************************************
            if (opera == 2)     //producto------
            {
                if (datos.checkMulti(ma1, ma2))
                {
                    this.labelOp.Text = "x >";
                    
                    realizarProductoBxA(ma2, ma1);
                }
                else  {
                    err = "No Coinciden las dimensiones de las para esta operacion\n\n" +
                           "  Solo Matrices Cuadradas Similares";
                }
            }
            //********************************************************
            if (opera == 3)         //producto b x a
            {
                if (datos.checkMulti(ma1, ma2))
                {
                    this.labelOp.Text = "< x";
                    realizarProductoBxA(ma1, ma2);
                }
                else  {
                    err = "No Coinciden las dimensiones de las para esta operacion\n\n" +
                           "  Solo Matrices Cuadradas Similares";
                }                 
            }            
            //********************************************************
            if (err != "")// hay errores
            {
                MessageBox.Show(err, "Fallo de Dimensiones", MessageBoxButtons.OK);
            }
            else // operaciones realizadas
            {
                this.labelM1.Text = "Matriz " + (ma1 + 1);
                this.labelM2.Text = "Matriz " + (ma2 + 1);
            }
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Realiza suma de matrices, Añade resultado a objeto en memoria y muestra en datagrid
        /// </summary>
        /// <param name="ma1">indice de matriz 1</param>
        /// <param name="ma2">indice de matriz 2</param>
        private void realizarSuma(int ma1, int ma2)
        {           
            suma sum = new suma(ma1, ma2);          // crear suma
            sum.resultado = datos.opSumar(ma1, ma2);// sumar
            datos.opera.sumas.Add(sum);             //añadir a lista de sumas
            datos.noEmpty = true;
            //pasar resultado al datagrid
            creaDataResult(sum.resultado);
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Realiza Resta de matrices, Añade resultado a objeto en memoria y muestra en datagrid
        /// </summary>
        /// <param name="ma1">indice de matriz 1</param>
        /// <param name="ma2">indice de matriz 2</param>
        private void realizarResta(int ma1, int ma2)
        {
            resta rest = new resta(ma1, ma2);          // crear suma
            rest.resultado = datos.opRestar(ma1, ma2);// restar
            datos.opera.restas.Add(rest);             //añadir a lista de Resta
            datos.noEmpty = true;
            //pasar resultado al datagrid
            creaDataResult(rest.resultado);
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Realiza producto de matrices, Añade resultado a objeto en memoria y muestra en datagrid
        /// </summary>
        /// <param name="ma1">indice de matriz 1</param>
        /// <param name="ma2">indice de matriz 2</param>
        private void realizarProducto(int ma1, int ma2)
        {
            producto pro = new producto(ma1, ma2);          // crear suma
            pro.resultado = datos.opProductoB_A(ma2, ma1);// sumar
            datos.opera.multi.Add(pro);            //añadir a lista de producto
            datos.noEmpty = true;
            //pasar resultado al datagrid
            creaDataResult(pro.resultado);
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// make multiply matrix operation, and view results in datagridView
        /// Multiplies two matrices selected by index
        /// </summary>
        /// <param name="ma1">index of Matrix List</param>
        /// <param name="ma2">index of matrix list</param>
        private void realizarProductoBxA(int ma1, int ma2)
        {
            producto pro = new producto(ma1, ma2);
            pro.resultado = datos.opProductoB_A(ma1, ma2);
            datos.opera.multi.Add(pro);
            datos.noEmpty = true;
            //view info on datagrid
            creaDataResult(pro.resultado);
        }
        //----------------------------------------------------------------------------------------------        
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