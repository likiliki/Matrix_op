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
using System.Text;
using System.IO;
/********************************
 Autor: ELADIO ACOSTA VALDAYO
 Fecha creación: 10/03/2015
 Última modificación: 19/03/2015
 Versión: 1.1
*********************************/
namespace WindowsFormsApplication1
{
    /// <summary>
    /// Clase html
    /// Incluye los metodos necesarios para crear
    /// y mostrar la informacion del objeto principal en html
    /// </summary>
     [Serializable()]
    public class htmlclass
    {
//*************************************************************************
        /// <summary>
        /// Constructor principal, asigna Fichero de ayuda y html
        /// </summary>
         public htmlclass()
         {
             string ruta = Directory.GetCurrentDirectory().ToString();
             fileHelp = ruta + "\\files\\help_m_op.html";
             fileHtml = ruta + "\\files\\contenido_de_matrices_html";
             fileCss = ruta + "\\files\\table.css";
        }
//---------------------------------------------------------------------
         /// <summary>
         /// Archivo CSS
         /// </summary>
         public string fileCss;         
//---------------------------------------------------------------------
        /// <summary>
        /// Archivo html sobre el que se trabajara
        /// </summary>
        public string fileHtml;
//---------------------------------------------------------------------
        /// <summary>
        /// Archivo html de Ventana de ayuda
        /// </summary>
        public string fileHelp;
//---------------------------------------------------------------------  
        /// <summary>
        /// METODO PRINCIPAL -- >Crea archivo y llama a metodos para adquirir html
        /// </summary>
        /// <param name="matrices">lista de matrices</param>
        /// <returns>string html</returns>
        public string saveHtml(ref prin principal)
            {
                fileHtml = Directory.GetCurrentDirectory().ToString() + "\\files\\contenido_de_matrices.html";
                Stream myStream = File.Create(fileHtml);//se crea carchivo con el nombre seleccionado
                myStream.Close();
                string Texto = "";
                //-----------------------------------------------               
                    Texto = crearHtml(ref principal);
                    StreamWriter sw = new StreamWriter(fileHtml, true, Encoding.UTF8);
                    sw.Write(Texto);//Se escribe el texto en HTML en el archivo
                    sw.Close();
                return Texto;
            }
//--------------------------------------------------------------------
        /// <summary>
        /// llama creador css, y creador de matrices - Para html
        /// </summary>
        /// <param name="matrices">lista de matrices</param>
        /// <returns>string html completo</returns>
        private string crearHtml(ref prin principal)
        {
                string Archivo = "";
                //Cabecera de la pagina y tabla encabezado
                Archivo += "<html >" + cssHtml();
                Archivo += "<body bgcolor=#A9D0F5> <title>Matrix Operations</title><body style='width:800px;'>";
                Archivo += "<div style='float: left; width: 49%;'><center><h1>Lista de Matrices</h1></center>";
                // Muestra de matrices en memoria
                Archivo += matrizHtml(ref principal.matrices);   
                // Muestra Operaciones
                Archivo += operaciones(principal.opera);
                // Fin de web
                Archivo += "</body> </html>";
                Archivo += "";
                //************************
                return Archivo;
        }
//---------------------------------------------------------------------
        /// <summary>
        /// crea tablas de todas las matrices iniciales, en html 
        /// </summary>
        /// <param name="matrices">lista de matrices</param>
        /// <returns>string html</returns>
        private string matrizHtml(ref List<float[,]> matrices)
        {
            string text = "";
            int col, fil;
            int fin = matrices.Count;
            //---------------------
            for (int m = 0; m < fin; m++) // bucle matrices
            {
                text += cabeceraTabla(m+1);
                col = matrices[m].GetLength(0);
                fil = matrices[m].GetLength(1);
                for (int f = 0; f < fil; f++) // bucle filas
                {
                    text += "<tr>";
                    for (int c = 0; c < col; c++)   // bucle columnas
                    {
                        float valor = matrices[m][c, f];
                        text += "  <td>"+ valor + "</td>"+
                                "";
                    }
                    text += "</tr>";
                }
                text += "</table></div>";
            }
            text += "</div>";
            //---------------------
            return text;
        }
//---------------------------------------------------------------------
         /// <summary>
         /// Creacion de las tablas de operaciones
         /// llamada secuencial a operaciones
         /// </summary>
         /// <param name="opera">objeto de operaciones</param>
         /// <returns>texto en html</returns>
        private string operaciones(operaciones opera) 
        {
            string text = "";
            //----------------
            text += "<div style='float: right; width: 49%;'><center><h1>Operaciones</h1></center>";
            // -------------------SUMAS-----------------------------------------
            text += muestraSumas(opera.sumas);
            // -------------------RESTAS----------------------------------------
            text += muestraRestas(opera.restas);
            // -------------------PRODUCTOS-------------------------------------
            text += muestraMulti(opera.multi);
            //----------------------INVERTIDAS-----------------------------------
            text += muestraInversas(opera.inversas);
            //----------------------GAUSS----------------------------------------
            text += muestraGauss(opera.mGauss);
            //---------------------------------------------------
            text += "</div>";
            //----------------
            return text;
        }
//---------------------------------------------------------------------
        /// <summary>
        /// muestra operaciones de Sumas en html
        /// </summary>
        /// <param name="mRestas">Lista de restas</param>
        /// <returns>Texto en html</returns>
        private string muestraSumas(List<suma> mSumas) 
        {
            string text = "";
            int finSum = mSumas.Count;
            //-------------------
            if (finSum > 0) // Comprobar si hay operaciones
                text += "<center><h2>Sumas</h2></center>";
            for (int s = 0; s < finSum; s++)             // bucle de sumas
            {
                int finFila = mSumas[s].resultado.GetLength(0); // filas
                int finColu = mSumas[s].resultado.GetLength(1); // columnas
                text += cabeceraSuma(mSumas[s].ma, mSumas[s].mb);
                
                //RECORRER UNA MATRIZ
                for (int c = 0; c < finColu; c++)
                {
                    text += "<tr>";
                    for (int f = 0; f < finFila; f++)
                    {
                        float valor = mSumas[s].resultado[f, c];
                        text += "  <td>" + valor + "</td>" +
                                "";
                    }
                    text += "<tr>";
                }
                text += "</table></div>";
            }
            //-------------------
            return text;
        }
//---------------------------------------------------------------------
        /// <summary>
        /// incrusta el archivo css para estilo de la web
        /// </summary>
        /// <returns></returns>
        private string cssHtml()
            {
                string css = "";
                //---------
                css += "<head> <link rel='stylesheet' type='text/css' href='"+ fileCss +"'/> </head>" +
                    "";
                //---------
                return css;
            }
//---------------------------------------------------------------------
        /// <summary>
        /// crea cabezera de tabka html
        /// </summary>
        /// <param name="num">num de matriz</param>
        /// <returns></returns>
        private string cabeceraTabla(int num)
            {
                string text = "<center><h2>Matriz " + num + "</h2></center>" +
                                "<div class='CSS_Table_Example'><table>";
                return text;
            }
//---------------------------------------------------------------------
        /// <summary>
        /// crea cabezera de tabka suma html
        /// </summary>
        /// <param name="num">num de matriz</param>
        /// <returns></returns>
        private string cabeceraSuma(int num, int num2)
        {
            num++;
            num2++;
            string text = "<center><h3>Suma> M_" + num.ToString() + " + M_" + num2.ToString() + "</h3></center>" +
                            "<div class='CSS_Table_Example'><table>";
            return text;
        }
//---------------------------------------------------------------------
         /// <summary>
         /// muestra operaciones de Restas en html
         /// </summary>
         /// <param name="mRestas">Lista de restas</param>
         /// <returns>Texto en html</returns>
        private string muestraRestas(List<resta> mRestas)
        {
            string text = "";
            int fin = mRestas.Count;
            //-------------------
            if (fin > 0) // Comprobar si hay operaciones
                text += "<center><h2>Restas</h2></center>";
            for (int s = 0; s < fin; s++)             // bucle de resta
            {
                int finFila = mRestas[s].resultado.GetLength(0); // filas
                int finColu = mRestas[s].resultado.GetLength(1); // columnas

                text += cabeceraResta(mRestas[s].ma, mRestas[s].mb);

                //RECORRER UNA MATRIZ
                for (int c = 0; c < finColu; c++)                
                {
                    text += "<tr>";
                    for (int f = 0; f < finFila; f++)
                    {
                        float valor = mRestas[s].resultado[f, c];
                        text += "  <td>" + valor + "</td>" +
                                "";
                    }
                    text += "<tr>";
                }
                text += "</table></div>";
            }
            //-------------------
            //float valor = mRestas[s].resultado[f, c];
            return text;
        }
//---------------------------------------------------------------------
        /// <summary>
        /// crea cabezera de tabla Resta html
        /// </summary>
        /// <param name="num">num de matriz</param>
        /// <returns></returns>
        private string cabeceraResta(int num, int num2)
        {
            num++;
            num2++;
            string text = "<center><h3>Resta> M_" + num.ToString() + " - M_" + num2.ToString() + "</h3></center>" +
                            "<div class='CSS_Table_Example'><table>";
            return text;
        }
//---------------------------------------------------------------------
        /// <summary>
        /// muestra operaciones de Producto en html
        /// </summary>
        /// <param name="mRestas">Lista de restas</param>
        /// <returns>Texto en html</returns>
        private string muestraMulti(List<producto> mMulti)
        {
            string text = "";
            int fin = mMulti.Count;
            //-------------------
            if (fin > 0) // Comprobar si hay operaciones
                text += "<center><h2>Productos</h2></center>";
            for (int s = 0; s < fin; s++)             // bucle de resta
            {
                int finFila = mMulti[s].resultado.GetLength(0); // filas
                int finColu = mMulti[s].resultado.GetLength(1); // columnas

                text += cabeceraMulti(mMulti[s].ma, mMulti[s].mb);

                //RECORRER UNA MATRIZ
                for (int c = 0; c < finColu; c++)
                {
                    text += "<tr>";
                    for (int f = 0; f < finFila; f++)
                    {
                        float valor = mMulti[s].resultado[f, c];
                        text += "  <td>" + valor + "</td>" +
                                "";
                    }
                    text += "<tr>";
                }
                text += "</table></div>";
            }
            //-------------------
            return text;
        }
//---------------------------------------------------------------------
        /// <summary>
        /// crea cabezera de tabla Producto html
        /// </summary>
        /// <param name="num">num de matriz</param>
        /// <returns></returns>
        private string cabeceraMulti(int num, int num2)
        {
            num++;
            num2++;
            string text = "<center><h3>Producto> M_" + num.ToString() + " - M_" + num2.ToString() + "</h3></center>" +
                            "<div class='CSS_Table_Example'><table>";
            return text;
        }
//---------------------------------------------------------------------
         /// <summary>
         /// muestra en html las matrices inversas
         /// </summary>
         /// <param name="mInvert">Lista de matrices invertidas</param>
         /// <returns>codigo html</returns>
        private string muestraInversas(List<inversa> mInvert)
        {
            string text = "";
            int fin = mInvert.Count;
            //-------------------
            if (fin > 0) // Comprobar si hay operaciones
                text += "<center><h2>Inversas</h2></center>";
            for (int s = 0; s < fin; s++)             // bucle de resta
            {
                int finFila = mInvert[s].resultado.GetLength(0); // filas
                int finColu = mInvert[s].resultado.GetLength(1); // columnas

                text += cabeceraInvert(mInvert[s].ma, mInvert[s].determinante);

                //RECORRER UNA MATRIZ
                for (int c = 0; c < finColu; c++)
                {
                    text += "<tr>";
                    for (int f = 0; f < finFila; f++)
                    {
                        float valor = mInvert[s].resultado[f, c];
                        text += "  <td>" + valor + "</td>" +
                                "";
                    }
                    text += "<tr>";
                }
                text += "</table></div>";
            }
            //-------------------
            return text;
        }
        //---------------------------------------------------------------------
         /// <summary>
         /// cabezera de tabla matriz invertida
         /// </summary>
         /// <param name="num"></param>numero de la matriz utilizada
         /// <param name="deter"></param>determinante obtenido en la operacion
         /// <returns></returns>
        private string cabeceraInvert(int num, float deter)
        {
            num++;
            string text = "<center><h3>M_" + num.ToString() + " Invertida - Det> " + deter.ToString() + "</h3></center>" +
                            "<div class='CSS_Table_Example'><table>";
            return text;
        }
        //---------------------------------------------------------------------
         /// <summary>
         /// muestra en html las matrice de gauss
         /// </summary>
         /// <param name="mGausses">lista de matrices de gauss</param>
         /// <returns>codigo html</returns>
        private string muestraGauss(List<gauss> mGausses)
        {
            string text = "";
            int fin = mGausses.Count;
            //-------------------
            if (fin > 0) // Comprobar si hay operaciones
                text += "<center><h2>Inversas</h2></center>";
            for (int s = 0; s < fin; s++)             // bucle de resta
            {
                int finFila = mGausses[s].resultado.GetLength(0); // filas
                int finColu = mGausses[s].resultado.GetLength(1); // columnas

                text += cabeceraGauss(mGausses[s].ma);

                //RECORRER UNA MATRIZ
                for (int c = 0; c < finColu; c++)
                {
                    text += "<tr>";
                    for (int f = 0; f < finFila; f++)
                    {
                        float valor = mGausses[s].resultado[f, c];
                        text += "  <td>" + valor + "</td>" +
                                "";
                    }
                    text += "<tr>";
                }
                text += "</table></div>";
            }
            //-------------------
            return text;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// cabezera de tabla matriz x Gauss
        /// </summary>
        /// <param name="num"></param>numero de la matriz utilizada
         /// <returns>codigo html</returns>
        private string cabeceraGauss(int num)
        {
            num++;
            string text = "<center><h3>M_" + num.ToString() + " x Gauss</h3></center>" +
                            "<div class='CSS_Table_Example'><table>";
            return text;
        }
        //---------------------------------------------------------------------
     }

//*************************************************************************
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