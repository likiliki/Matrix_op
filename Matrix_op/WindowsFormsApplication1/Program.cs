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
using System.Linq;
using System.Windows.Forms;
/********************************
 Autor: ELADIO ACOSTA VALDAYO
 Fecha creación: 21/03/2015
 Última modificación: 21/03/2015
 Versión: 1.1
*********************************/
namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent1());
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