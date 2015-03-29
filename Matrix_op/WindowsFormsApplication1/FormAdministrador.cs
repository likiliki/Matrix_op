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
using System.Runtime.Serialization.Formatters.Binary;
/********************************
 Autor: ELADIO ACOSTA VALDAYO
 Fecha creación: 18/03/2015
 Última modificación: 22/03/2015
 Versión: 1.1
*********************************/
namespace WindowsFormsApplication1
{
    public partial class FormAdministrador : Form
    {
        //-------------------------------------------------------------
        prin datos;     // objeto de datos principal
        //-------------------------------------------------------------
        public FormAdministrador(prin dato, Color fondo, Color letras)
        {
            InitializeComponent();
            datos = dato;
            firstLoad();
            this.BackColor = fondo;
            this.ForeColor = letras;
        }
        //-------------------------------------------------------------
        private void firstLoad()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.buttonSaveMatriz.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            cargaListBoxs();
            selectedIndexFirst();
        }
        //-------------------------------------------------------------
        /// <summary>
        /// Selecciona el primer elemento en ambos lsitbox
        /// </summary>
        private void selectedIndexFirst()
        {
            try
            {
                this.listBoxMatricesOpera.SelectedIndex = 0;
            }
            catch (Exception) { }
        }
        //-------------------------------------------------------------
        private void cargaListBoxs()
        {
            string text = "";
            // matrices operacion
            int matrix = datos.matrices.Count; 
            for (int i = 0; i < matrix; i++) // recorrer matrices operacion
            {
                int fil = datos.matrices[i].GetLength(0);//filas
                int col = datos.matrices[i].GetLength(1);//columnas
                text = string.Format("  Matriz{0}:   {1}x{2}", i + 1, fil, col);//formato

                listBoxMatricesOpera.Items.Add(text);       //añadir a listBoxS
            }
            // matrices resultado
            int sumas = datos.opera.sumas.Count;
            for (int i = 0; i < sumas; i++)     // sumas-------------------
            {
                int ma = datos.opera.sumas[i].ma;
                int mb = datos.opera.sumas[i].mb;
                text = string.Format("+" + (i + 1) + "  Suma  -> M{0} + M{1}", ma+1, mb+1);
                listBoxMatricesResult.Items.Add(text);
            }

            int restas = datos.opera.restas.Count;
            for (int i = 0; i < restas; i++)     // restas-------------------
            {
                int ma = datos.opera.restas[i].ma;
                int mb = datos.opera.restas[i].mb;
                text = string.Format("-" + (i+1) + "   Resta -> M{0} - M{1}", ma+1, mb+1);
                listBoxMatricesResult.Items.Add(text);
            }

            int multis = datos.opera.multi.Count;
            for (int i = 0; i < multis; i++)     // Productos-----------------
            {
                int ma = datos.opera.multi[i].ma;
                int mb = datos.opera.multi[i].mb;
                text = string.Format("x" + (i + 1) + "   Multi   -> M{0} - M{1}", ma+1, mb+1);
                listBoxMatricesResult.Items.Add(text);
            }

            int invert = datos.opera.inversas.Count;
            for (int i = 0; i < invert; i++)     // Inversas-----------------
            {
                int ma = datos.opera.inversas[i].ma;
                text = string.Format(">" + (i + 1) + "  Inversa -> M{0} ><", ma+1);
                listBoxMatricesResult.Items.Add(text);
            }

            int gau = datos.opera.mGauss.Count;
            for (int i = 0; i < gau; i++)     // Gauss-----------------
            {
                int ma = datos.opera.mGauss[i].ma;
                text = string.Format("~" + (i + 1) + "  Gaus -> Ma{0} ~", ma + 1);
                listBoxMatricesResult.Items.Add(text);
            }
        }
        //-------------------------------------------------------------
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int select = this.listBoxMatricesResult.SelectedIndex; // pos seleccionada
            string aux= listBoxMatricesResult.Items[select].ToString();
            char selecMatrixRes = aux[0];                           // Operacdor seleccionado
            int num = Convert.ToInt32(aux[1]) - 49;
            // Elegir segun operador
            switch (selecMatrixRes) 
            {
                    //---suma-------------------------
                case '+':

                    int f = datos.opera.sumas[num].resultado.GetLength(0);
                    int c = datos.opera.sumas[num].resultado.GetLength(1);
                    creaDataResult(f, c);
                    llenaGrid(dataMatriz2, datos.opera.sumas[num].resultado);
                    break;
                //---resta-------------------------
                case '-':

                    int fi = datos.opera.restas[num].resultado.GetLength(0);
                    int ci = datos.opera.restas[num].resultado.GetLength(1);
                    creaDataResult(fi, ci);
                    llenaGrid(dataMatriz2, datos.opera.restas[num].resultado);
                    break;
                //---producto-------------------------
                case 'x':

                    int fm = datos.opera.multi[num].resultado.GetLength(0);
                    int cm = datos.opera.multi[num].resultado.GetLength(1);
                    creaDataResult(fm, cm);
                    llenaGrid(dataMatriz2, datos.opera.multi[num].resultado);
                    break;
                //---inversa-------------------------
                case '>':

                    int fa = datos.opera.inversas[num].resultado.GetLength(0);
                    int ca = datos.opera.inversas[num].resultado.GetLength(1);
                    creaDataResult(fa, ca);
                    llenaGrid(dataMatriz2, datos.opera.inversas[num].resultado);
                    break;
                //---gauss-------------------------
                case '~':

                    int fg = datos.opera.mGauss[num].resultado.GetLength(0);
                    int cg = datos.opera.mGauss[num].resultado.GetLength(1);
                    creaDataResult(fg, cg);
                    llenaGrid(dataMatriz2, datos.opera.mGauss[num].resultado);
                    break;
                    // fin del switch-----------------
            }
        }
        //-------------------------------------------------------------
        private void creaDataResult(int fil, int col) 
        {
            dataMatriz2.AllowUserToAddRows = true;
            dataMatriz2.RowCount = 1;
            dataMatriz2.ColumnCount = 1;
            //crea datagrid ------------------------------------------
            System.Windows.Forms.DataGridViewTextBoxColumn Columna;

            for (int i = 1; i < fil; i++)         //añade columnas al datagrid
            {
                Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                Columna.Width = 50;
                Columna.HeaderText = "c " + (i + 1);
                this.dataMatriz2.Columns.Add(Columna);
            }
            for (int j = 0; j < col; j++)         //añade filas al datagrid
                this.dataMatriz2.Rows.Add();

            dataMatriz2.AllowUserToAddRows = false;
        }
        //-------------------------------------------------------------
        private void listBoxMatricesOpera_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataMatriz1.AllowUserToAddRows = true;
            dataMatriz1.RowCount = 1;
            dataMatriz1.ColumnCount = 1;
            int select = this.listBoxMatricesOpera.SelectedIndex; //posicion seleccionada
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

            llenaGrid(dataMatriz1, datos.matrices[select]); // lena datagrid

            labelMaOp.Text = "Matriz " + (select + 1).ToString();
            dataMatriz1.AllowUserToAddRows = false;
        }
        //-------------------------------------------------------------
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
                    data[i, j].Value = matr;
                }
            }
        }
        //-------------------------------------------------------------
        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            anadeAlDatagrid(this.dataMatriz1, 1);
        }
        //-------------------------------------------------------------
        private void buttonAddColum_Click(object sender, EventArgs e)
        {
            anadeAlDatagrid(this.dataMatriz1, 0);
        }
        //-------------------------------------------------------------
        /// <summary>
        /// Añade fila o columan al datagrid e inicializa con 0
        /// 0- añade columna
        /// 1- añade fila
        /// </summary>
        /// <param name="data">datagrid utilizado</param>
        /// <param name="selec">parametro de seleccion: 0 o 1</param>
        private void anadeAlDatagrid(DataGridView data, int selec) 
        {
            int col = this.dataMatriz1.ColumnCount;
            int fil = this.dataMatriz1.RowCount;

            if (selec == 0) // añadir columna e iniciar a 0
            {
                System.Windows.Forms.DataGridViewTextBoxColumn Columna;
                Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                //-------------------
                Columna.Width = 50;                
                Columna.HeaderText = "c " + col;
                data.Columns.Add(Columna);
                //---llenar de 0
                for (int c = 0; c < fil; c++)
                {
                    data[col, c].Value = 0;
                }
            }
            if (selec == 1) // añadir fila e iniciar con 0
            {
                this.dataMatriz1.Rows.Add();
                //--- llenar con 0
                for (int c = 0; c < col; c++)
                {
                    data[c, fil].Value = 0;
                }
            }
        }
        //-------------------------------------------------------------
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------
        private void buttonDelFil_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea eliminar la fila seleccionada?","Confirmar" , MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                int selec = this.dataMatriz1.CurrentRow.Index;
                this.dataMatriz1.Rows.RemoveAt(selec);
            }            
        }
        //-------------------------------------------------------------
        private void buttonDelCol_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea eliminar la columna seleccionada?", "Confirmar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                int selec = this.dataMatriz1.CurrentCell.ColumnIndex;
                this.dataMatriz1.Columns.RemoveAt(selec);
            }  
        }
        //-------------------------------------------------------------
        private void buttonSaveMatriz_Click(object sender, EventArgs e)
        {
            int selec=this.listBoxMatricesOpera.SelectedIndex;
            updateMatriz(selec);
        }
        //-------------------------------------------------------------
        private void updateMatriz(int ma1) 
        {
            try
            {
                int col = this.dataMatriz1.ColumnCount;
                int fil = this.dataMatriz1.RowCount;
                //------------
                //this.datos.matrices[ma1]
                float[,] aux = new float[col, fil];
                for (int f = 0; f < fil; f++)
                {
                    for (int c = 0; c < col; c++)
                    {
                        aux[c, f] = (float)Convert.ToDouble(dataMatriz1[c, f].Value);
                    }
                }
                this.datos.matrices[ma1] = new float[col, fil];
                this.datos.matrices[ma1] = aux;
                // si  no a habido fallos - guardamos en fichero
                comprobarGuardado();
            }
            catch (FormatException)
            {
                string text = "Introduccion de datos no permitida\n\n" + 
                            "Solo se permiten numeros\n\n\tEj: 1234,123";
                MessageBox.Show(text,"",MessageBoxButtons.OK);
            }
        }
        //-------------------------------------------------------------
        private void comprobarGuardado() 
        {
            if (datos.Nombre_Del_Archivo != "") // Comprobar que hay archivo cargado
            {
                guardar();
            }
            else 
            {
                guardarComo();
            }
        }
        //-------------------------------------------------------------
        /// <summary>
        /// Funcion que guarda en archivo .mat
        /// </summary>
        private void guardar()
        {
            try
            {
                Stream myStream;
                myStream = File.Create(datos.Nombre_Del_Archivo);//se crea carchivo con el nombre seleccionado
                BinaryFormatter seri = new BinaryFormatter();
                seri.Serialize(myStream, datos);//Se guarda en el archivo el objeto Completo                
                myStream.Close();
                //Informamos del guardado correcto                
                MessageBox.Show("Datos Guardados en:\r\n\r\n" + datos.Nombre_Del_Archivo);
            }
            catch (Exception)
            {
                MessageBox.Show("FALLO AL ESCRIBIR EN: " + datos.Nombre_Del_Archivo);
            }
        }
        //-------------------------------------------------------------
        private void guardarComo() 
        {
            SaveFileDialog Guardar = new SaveFileDialog();//Cuadro de dialogo de guardar como
            Guardar.Filter = "Archivos Dat (*.mat)|*.mat";//Archivos que deseamos mostrar   
            Guardar.InitialDirectory = Directory.GetCurrentDirectory();
            //Guardar.RestoreDirectory = true;

            if (Guardar.ShowDialog() == DialogResult.OK)//Solo al pulsar aceptar
            {
                datos.Nombre_Del_Archivo = Guardar.FileName;
                guardar();  //  Funcion gUARDAR
            }
        }
        //-------------------------------------------------------------
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