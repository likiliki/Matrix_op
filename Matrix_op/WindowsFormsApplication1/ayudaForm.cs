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
 Última modificación: 11/03/2015
 Versión: 1.1
*********************************/
namespace WindowsFormsApplication1
{
    /// <summary>
    /// Formulario que muestra la ayuda de aplicacion
    /// </summary>
    public partial class ayudaForm : Form
    {
        //---------------------------------------------------------------------
        /// <summary>
        /// Constructor de formulario de ayuda
        /// </summary>
        /// <param name="Fil">Archivo de ayuda - html</param>
        public ayudaForm(string Fil)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.WindowsDefaultBounds;
            webBrowser1.Navigate(Fil); // System.Windows.Controls.WebBrowser
            this.Size = new System.Drawing.Size(600, 600);
        }
        //---------------------------------------------------------------------
        private void ayudaForm_FormClosed(object sender, FormClosedEventArgs e) { }        
        //---------------------------------------------------------------------
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