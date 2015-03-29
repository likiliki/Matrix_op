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
using System.Drawing;
/********************************
 Autor: ELADIO ACOSTA VALDAYO
 Fecha creación: 10/03/2015
 Última modificación: 18/03/2015
 Versión: 1.1
*********************************/
namespace WindowsFormsApplication1
{
    //*************************************************************************
    /// <summary>
    /// Clase tema de aplicacion guarda olor de barras y color de texto
    /// </summary>
    [Serializable()]
    public class temaApp
    {
        /// <summary>
        /// Constructor de tema
        /// </summary>
        /// <param name="fon">Color de fondo</param>
        /// <param name="let">Color de letras</param>
        public temaApp(Color fon, Color let)
        {
            fondo = fon;
            letras = let;
        }
        public temaApp()
        {
            fondo = (Color)SystemColors.Control;
            letras = (Color)SystemColors.ControlText;
        }        
        public Color fondo;
        public Color letras;
    }
    //*************************************************************************
    [Serializable()]
    public class prin
    {
        //---------------------------------------------------------------------
        public prin()
        {
            opera = new operaciones();
            html = new htmlclass();
            matrices = new List<float[,]>();
        }
        public bool noEmpty = false;
        //---------------------------------------------------------------------
        /// <summary>
        /// Lista de matrices principal
        /// </summary>
        public List<float[,]> matrices;
        //---------------------------------------------------------------------
        /// <summary>
        /// objeto html para mostrar los datos
        /// </summary>
        public htmlclass html;
        //--------------------------------------------------------------------- 
        /// <summary>
        /// Lista de Operaciones - Contiene Sumas, Resta
        /// </summary>
        public operaciones opera;
        //---------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public float[,] matriz;
        //---------------------------------------------------------------------
        /// <summary>
        ///     Respuesta
        /// </summary>
        public bool resp;
            //---------------------------------------------------------------------
            /// <summary>
            /// n Filas
            /// </summary>
        public int filas;
            //---------------------------------------------------------------------
            /// <summary>
            /// N Columans
            /// </summary>
        public int columnas;

        public string Nombre_Del_Archivo;
       
        //----------------OPERACIONES DE MATRICES------------------------------
        /// <summary>
        /// Suma de dos matrices
        /// seleccionadas por el indice
        /// </summary>
        /// <param name="a">indice matriz a</param>
        /// <param name="b">indice matriz b</param>
        /// <returns></returns>
        public float[,] opSumar(int a, int b) 
        {            
            int filas = this.matrices[a].GetLength(0);
            int columnas = this.matrices[a].GetLength(1);
            float[,] resultado = new float[filas, columnas];
            float valor = 0;
            //-------------
            for (int i = 0; i < filas; i++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    //realiza suma
                    valor = matrices[a][i, c] + matrices[b][i, c];
                    resultado[i, c] = valor;
                }
            }
            //-------------
            return resultado;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// resta de dos matrices
        /// seleccionadas por indice
        /// </summary>
        /// <param name="a">indice matriz a</param>
        /// <param name="b">indice matriz b</param>
        /// <returns>matriz resultado</returns>
        public float[,] opRestar(int a, int b)
        {
            int filas = this.matrices[a].GetLength(0);
            int columnas = this.matrices[a].GetLength(1);
            float[,] resultado = new float[filas, columnas];
            float valor = 0;
            //-------------
            for (int i = 0; i < filas; i++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    //realiza suma
                    valor = matrices[a][i, c] - matrices[b][i, c];
                    resultado[i, c] = valor;
                }
            }
            //-------------
            return resultado;
        }
        //---------------------------------------------------------------------        
        /// <summary>
        /// producto de mtriz b X A
        /// seleccionadas por indice
        /// </summary>
        /// <param name="a">indice matriz a</param>
        /// <param name="b">indice matriz b</param>
        /// <returns>matriz resultado</returns>
        public float[,] opProductoB_A(int a, int b)
        {
            int filas = this.matrices[a].GetLength(0);
            int columnas = this.matrices[a].GetLength(1);
            float[,] resultado = new float[filas, filas];
            //-------------
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    //filas y columnas
                    float valor = 0;
                    for (int p = 0; p < filas; p++)
                    {
                        //operaciones de producto b x a
                        float aux = this.matrices[a][j, p] * this.matrices[b][p, i];
                        valor += aux;
                    }
                    resultado[j, i] = valor;
                }
            }
            //-------------
            return resultado;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// comprueba filas iguales y columnas iguales
        /// entre ambas matrices
        /// seleccionadas por indice
        /// </summary>
        /// <param name="a">indice matriz a</param>
        /// <param name="b">indice matriz b</param>
        /// <returns>true - coincide</returns>false - no coincide
        public bool check(int a, int b)
        {
            int filA = this.matrices[a].GetLength(0); // filas matriz A
            int colA = this.matrices[a].GetLength(1); // Columnas matriz A
            int filB = this.matrices[b].GetLength(0); // filas matriz B
            int colB = this.matrices[b].GetLength(1); // Columnas matriz A
            bool res = false;           // respuesta de la funcion
            //--------------------------// Funcion
            if (filA == filB && colA == colB)
                res = true;
            //--------------------------// Fin Funcion
            return res;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Comprueba que la matriz sea valida para producto de matrices
        /// seleccionadas por indice
        /// </summary>
        /// <param name="a">indice matriz a</param>
        /// <param name="b">indice matriz b</param>
        /// <returns>true - posible</returns>flase - no posible
        public bool checkMulti(int a, int b)
        {
            int filA = this.matrices[a].GetLength(0); // filas matriz A
            int colA = this.matrices[a].GetLength(1); // Columnas matriz A
            int filB = this.matrices[b].GetLength(0); // filas matriz B
            int colB = this.matrices[b].GetLength(1); // Columnas matriz A
            bool res = false;           // respuesta de la funcion
            
            //--------------------------// Funcion
            if (filA == colA && filB == colB && filA == filB)
                res = true;
            //--------------------------// Fin Funcion
            return res;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Operacion de suma Matriz-Numero
        /// </summary>
        /// <param name="a">Indice de matriza a utilizar</param>
        /// <param name="num">numero para la operacion</param>
        /// <returns></returns>
        public float[,] opSumaNum(int a, decimal num)
        {
            int filas = this.matrices[a].GetLength(0);
            int columnas = this.matrices[a].GetLength(1);
            float[,] resultado = new float[filas, columnas];
            //-------------
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    //realiza operacion suma de una casilla
                    float valor = matrices[a][i, j] + (float)num;
                    resultado[i, j] = valor;
                }
            }
            //-------------
            return resultado; 
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Operacion de resta Matriz-Numero
        /// </summary>
        /// <param name="a">Indice de matriza a utilizar</param>
        /// <param name="num">numero para la operacion</param>
        /// <returns></returns>
        public float[,] opRestaNum(int a, decimal num)
        {
            int filas = this.matrices[a].GetLength(0);
            int columnas = this.matrices[a].GetLength(1);
            float[,] resultado = new float[filas, columnas];
            //-------------
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    //realiza operacion suma de una casilla
                    float valor = matrices[a][i, j] - (float)num;
                    resultado[i, j] = valor;
                }
            }
            //-------------
            return resultado;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Operacion de Multiplicar Matriz-Numero
        /// </summary>
        /// <param name="a">Indice de matriza a utilizar</param>
        /// <param name="num">numero para la operacion</param>
        /// <returns></returns>
        public float[,] opMultiNum(int a, decimal num)
        {
            int filas = this.matrices[a].GetLength(0);
            int columnas = this.matrices[a].GetLength(1);
            float[,] resultado = new float[filas, columnas];
            //-------------
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    //realiza operacion suma de una casilla
                    float valor = matrices[a][i, j] * (float)num;
                    resultado[i, j] = valor;
                }
            }
            //-------------
            return resultado;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Operacion de Multiplicar Matriz-Numero
        /// </summary>
        /// <param name="a">Indice de matriza a utilizar</param>
        /// <param name="num">numero para la operacion</param>
        /// <returns></returns>
        public float[,] opDiviNum(int a, decimal num)
        {
            int filas = this.matrices[a].GetLength(0);
            int columnas = this.matrices[a].GetLength(1);
            float[,] resultado = new float[filas, columnas];
            //-------------
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    //realiza operacion suma de una casilla
                    float valor = matrices[a][i, j] / (float)num;
                    resultado[i, j] = valor;
                }
            }
            //-------------
            return resultado;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Halla matriz inversa
        /// devuelve matriz y determinante utilizado
        /// </summary>
        /// <param name="matriz">matriz utilizada</param>
        /// <param name="determinante">determinante obtenido para la operacion</param>
        /// <returns>matriz inversa</returns>
        public float[,] Inversa(float[,] matriz, ref float determinante)
        {
            determinante = Determinante(matriz);
            float[,] result = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = (float)Math.Pow(-1, i + j) * Determinante(ElimFilCol(matriz, i, j));
                }
            }
            result = EscalarMult(Transpuesta(result), 1 / determinante);
            return result;
        }
        //---------------------------------------------------------------------     
        /// <summary>
        /// Obtiene el determinante de una matriz
        /// </summary>
        /// <param name="m">matriz utilizada</param>
        /// <returns>determinante de la matriz</returns>float
        private float Determinante(float[,] m)
        {
            float determinante = 0;


            if (m.Length == 1)
                return m[0, 0];

            else
            {
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    determinante += (float)Math.Pow(-1, i) * m[i, 0] * Determinante(ElimFilCol(m, i, 0));
                }
            }

            return determinante;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Elimina fila y columna
        /// metodo para matriz inversa
        /// </summary>
        /// <param name="a">matriz</param>
        /// <param name="fila">fila</param>
        /// <param name="column">columna</param>
        /// <returns>matriz reducida</returns>
        private float[,] ElimFilCol(float[,] a, int fila, int column)
        {
            float[,] result = new float[a.GetLength(0) - 1, a.GetLength(1) - 1];
            bool fil = false;
            bool col = false;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                col = false;
                if (i == fila) { fil = true; }
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (j == column) { col = true; }
                    if (!fil && !col) { result[i, j] = a[i, j]; }
                    if (!fil && col) { result[i, j] = a[i, j + 1]; }
                    if (fil && !col) { result[i, j] = a[i + 1, j]; }
                    if (fil && col) { result[i, j] = a[i + 1, j + 1]; }

                }
            }
            return result;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// halla el escalar de una matriz
        /// </summary>
        /// <param name="matriz">matriz</param>
        /// <param name="escalar">escalar</param>
        /// <returns>matriz resultado</returns>
        float[,] EscalarMult(float[,] matriz, float escalar)
        {
            float[,] multiplicada = new float[matriz.GetLength(0), matriz.GetLength(1)];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    multiplicada[i, j] = escalar * matriz[i, j];
                }
            }

            return multiplicada;
        }
        /// <summary>
        /// devuelva la misma matriz pero traspuesta
        /// </summary>
        /// <param name="m">matriz</param>
        /// <returns>matriz resultado</returns>
        public float[,] Transpuesta(float[,] m)
        {
            float[,] result = new float[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = m[j, i];
                }
            }
            return result;
        }
        //---------------------------------------------------------------------              
        /// <summary>
        /// metodo de gauss
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>
        public float[,] Gauss(float[,] matriz)
        {
            bool sePuedeContinuar = true;
            float[,] result = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = matriz[i, j];
                }

            }
            for (int i = 0; i < Math.Min(result.GetLength(0), result.GetLength(1)); i++)
            {
                if (result[i, i] == 0)
                {
                    for (int j = i + 1; j < result.GetLength(0); j++)
                    {
                        if (result[j, i] != 0)
                        {
                            IntercambiarFilas(result, i, j);
                            sePuedeContinuar = true;
                            break;
                        }
                        else
                        {
                            sePuedeContinuar = false;
                        }
                    }
                }
                if (sePuedeContinuar)
                {
                    AnulaColumna(result, i);
                }

            }
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = (float)Math.Round(result[i, j], 2);
                }
            }
            return result;
        }
        //---------------------------------------------------------------------
        private void IntercambiarFilas(float[,] result, int i, int j)
        {
            float[] fila1 = new float[result.GetLength(1)];
            for (int k = 0; k < result.GetLength(1); k++)
            {
                fila1[k] = result[i, k];
            }
            for (int k = 0; k < result.GetLength(1); k++)
            {
                result[i, k] = result[j, k];
                result[j, k] = fila1[k];

            }
        }
        //---------------------------------------------------------------------
        private void AnulaColumna(float[,] matriz, int i)
        {
            float terminoAnulante = 0;
            for (int j = i + 1; j < matriz.GetLength(0); j++)
            {
                terminoAnulante = -1 * matriz[j, i] / matriz[i, i];
                for (int k = i; k < matriz.GetLength(1); k++)
                {
                    matriz[j, k] = matriz[i, k] * terminoAnulante + matriz[j, k];
                }
            }
        }       
        //---------------------------------------------------------------------
        /// <summary>
        /// Comprueba que la matriz sea cuadrada
        /// </summary>
        /// <param name="matriz">mareiz para analizar</param>
        /// <returns>true- es cuadrada</returns>false- no cuadrada
        public bool cuadrada(float[,] matriz)
        {
            if (matriz.GetLength(0) == matriz.GetLength(1))
                return true;
            //---------------
            return false;  
        }
        //---------------------------------------------------------------------
        ///// <summary>
        ///// producto de dos matrices
        ///// seleccionadas por indice
        ///// </summary>
        ///// <param name="a">indice matriz a</param>
        ///// <param name="b">indice matriz a</param>
        ///// <returns>matriz resultado</returns>
        //public float[,] opProducto(int a, int b) 
        //{
        //    int filas = this.matrices[a].GetLength(0);
        //    int columnas = this.matrices[a].GetLength(1);
        //    float[,] result = new float[filas, filas];
        //    //-------------
        //    for (int i = 0; i < filas; i++)
        //    {
        //        for (int j = 0; j < columnas; j++)
        //        {
        //            float valor = 0;
        //            for (int k = 0; k < columnas; k++)
        //            {
        //                valor += this.matrices[a][i, k] *this.matrices[b][j, k];
        //            }
        //            result[i, j] = valor;
        //        }
        //    }
        //    //-------------
        //    return result;
        //}
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