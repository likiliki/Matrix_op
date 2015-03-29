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
 Última modificación: 10/03/2015
 Versión: 1.1
*********************************/
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Objeto - datos de la aplicacion
        /// </summary>
        private prin datos;
        //---------------------------------------------------------------------
        /// <summary>
        /// Constructor de fORM2
        /// Crear nueva matriz, seleccionar filas y columnas
        /// </summary>
        /// <param name="dat">Objeto principal de datos</param>
        /// <param name="fondo">Color de fondo</param>
        /// <param name="letras">Color de letras</param>
        public Form2(ref prin dat, Color fondo, Color letras)
        {            
            InitializeComponent();
            datos = dat;
            datos.resp = false;
            this.BackColor = fondo;
            this.ForeColor = letras;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Agregar nueva matriz
        /// Envia - int Filas, int columnas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            datos.filas = (int)numericFilas.Value;
            datos.columnas = (int)numericColumnas.Value;
            datos.resp = true;
            this.Close();
        }
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