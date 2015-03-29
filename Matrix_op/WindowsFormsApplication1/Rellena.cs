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
using System.IO;
/********************************
 Autor: ELADIO ACOSTA VALDAYO
 Fecha creación: 10/03/2015
 Última modificación: 16/03/2015
 Versión: 1.1
*********************************/
namespace WindowsFormsApplication1
{
    //*********************************************************
    /// <summary>
    /// Formulario para rellenar una matriz nueva
    /// </summary>
    public partial class Rellena : Form
    {
        //-----------------------------------------------------------------------------------
        prin datos;                  // objeto principal de datos
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// constructor de Rellea Form
        /// </summary>
        /// <param name="dat">objeto principal</param>
        public Rellena(ref prin dat, Color fondo, Color letras)
        {
            InitializeComponent();
            rellenaDatagrid(dat.filas, dat.columnas);
            datos = dat;
            this.BackColor = fondo;
            this.ForeColor = letras;
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Refresca Informacion contenida en dataGridView
        /// </summary>
        public void refreshGrid()
        {
            rellenaDatagrid(datos.filas, datos.columnas);
            this.dataGridView1.AllowUserToAddRows = false;
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Crea dimensiones del datagrid y manda a llenar con matriz
        /// </summary>
        /// <param name="filas">filas</param>
        /// <param name="columnas">columnas</param>
        public void rellenaDatagrid(int filas, int columnas)
        {
            string text = "Columna " + 1;
            System.Windows.Forms.DataGridViewTextBoxColumn Columna;
            this.dataGridView1.AllowUserToAddRows = true;
            this.dataGridView1.AllowUserToDeleteRows = true;
            this.dataGridView1.RowCount = 1;
            this.dataGridView1.ColumnCount = 1;
          
            //añade columnas al datagrid
            for (int i = 1; i < columnas; i++)
            {
                Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                Columna.HeaderText = "C " + i;
                this.dataGridView1.Columns.Add(Columna);                 
            } 
            //añade filas al datagrid
            for (int j = 0; j < filas; j++)
                this.dataGridView1.Rows.Add(); 
            //rellena el datagrid con ceros 0
            llenaGrid(filas, columnas);
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// RELLENA EL DATAGRID COMPLETO CON CEROS 0
        /// </summary>
        /// <param name="fila">numero de filas del datagrid   </param>  int
        /// <param name="colu">numero de columnas del datagrid</param>  int
        private void llenaGrid(int fila, int colu)
        {
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < colu; j++)
                {
                    this.dataGridView1[j, i].Value = 0;
                }
            }
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Pasa a matriz los datos del DataGridView
        /// </summary>
        /// <param name="dat">objeto principal</param>
        private void llenaMatriz(prin dat)
        {           
                int fila = dat.filas;
                int colu = dat.columnas;
                dat.matriz = new float[colu, fila];
                for (int i = 0; i < fila; i++)
                {
                    for (int j = 0; j < colu; j++)
                    {
                        dat.matriz[j, i] = (float)Convert.ToDouble(this.dataGridView1[j, i].Value);
                    }
                }
        }
        //-----------------------------------------------------------------------------------        
        /// <summary>
        /// cancelar operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancela_Click(object sender, EventArgs e)
        {
            datos.resp = false;
            this.Close();
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Guardar Datos en el objeto
        /// añade matriz al objeto
        /// crea html y lo muestra en WebBrowser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {            
            //***************
            try
            {
                llenaMatriz(datos);
                datos.matrices.Add(datos.matriz);
                datos.noEmpty = true;
            }
            catch (FormatException)
            {
                string text = "Introduccion de datos no permitida\n\n" +
                            "Solo se permiten numeros\n\n\tEj: 1234,123";
                MessageBox.Show(text, "", MessageBoxButtons.OK);
            }
            catch(Exception)
            {
                MessageBox.Show("fallo matriz add");
            }
            //***************            
            this.Close();
        }             
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// not used
        /// </summary>
        private void Rellena_FormClosed(object sender, FormClosedEventArgs e) { }       
        //-----------------------------------------------------------------------------
        /// <summary>
        /// not used
        /// </summary>
        private void Rellena_FormClosing(object sender, FormClosingEventArgs e) 
        {        }        
        //-----------------------------------------------------------------------------    
    }
    //*********************************************************
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