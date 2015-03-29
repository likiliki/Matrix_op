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
    /// <summary>
    /// Form que muestra los datso de la aplicacion en html
    /// </summary>
    public partial class FormWebBrowser : Form
    {
        //----------------------------------------------------------------------
        /// <summary>
        /// Objet Principal- datos de aplicacion
        /// </summary>
        private prin data;
        //----------------------------------------------------------------------
        /// <summary>
        /// Constructr de Formulario para ver los datso en html
        /// </summary>
        /// <param name="datos">Objeto Principal de datos</param>
        public FormWebBrowser(ref prin datos)
        {            
            InitializeComponent();      
            this.Size = new System.Drawing.Size(712, 515);
            this.WindowState = FormWindowState.Maximized;
            data = datos;
        }
        //---------------------------------------------------------------------- 
        /// <summary>
        /// Refresca la informacion  mostrada en pantalla
        /// </summary>
        private void refersh() 
        {
            this.WindowState = FormWindowState.Maximized;
            data.html.saveHtml(ref data);
            this.webBrowser1.Navigate(data.html.fileHtml);
        }
        //----------------------------------------------------------------------
        /// <summary>
        /// Refresca al recuperar el foco
        /// </summary>
        private void FormWebBrowser_Enter(object sender, EventArgs e)
        {
            this.refersh();
        }
        //----------------------------------------------------------------------
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