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
/********************************
 Autor: ELADIO ACOSTA VALDAYO
 Fecha creación: 10/03/2015
 Última modificación: 14/03/2015
 Versión: 1.1
*********************************/
namespace WindowsFormsApplication1
{
    /// <summary>
    /// CLASE OPERACIONES - CONTIENE LISTAS DE CLASES:
    /// SUMA, RESTA, PRODUCTO, Invertsa, Gauss
    /// 
    /// ES SERIALIZABLE PARA GUARDAR OBJETO COMPLETO EN FICHERO
    /// </summary>
    [Serializable()]    
    public class operaciones
    {
        //---------------------------------------------------------------------
        /// <summary>
        /// Contructor de operaciones
        /// 
        /// crea listas de diferentes operaciones
        /// </summary>
        public operaciones()
        {
            sumas = new List<suma>();
            restas = new List<resta>();
            multi = new List<producto>();
            inversas = new List<inversa>();
            mGauss = new List<gauss>();
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Lista de sumas
        /// </summary>
        public List<suma> sumas;
        //---------------------------------------------------------------------
        /// <summary>
        /// Lista de restas
        /// </summary>
        public List<resta> restas;
        //---------------------------------------------------------------------
        /// <summary>
        /// Lista de productos
        /// </summary>
        public List<producto> multi;
        //---------------------------------------------------------------------
        /// <summary>
        /// Lista de matrices Inversas
        /// </summary>
        public List<inversa> inversas;
        //---------------------------------------------------------------------
        /// <summary>
        /// Lista de matrices de gauss
        /// </summary>
        public List<gauss> mGauss;
        //---------------------------------------------------------------------
    }

    /// <summary>
    /// Clase suma - Contiene ->Resultado y numero de matrices utilizadas
    /// </summary>
    [Serializable()]
    //*************************************************************************        
    public class suma
    {
        //---------------------------------------------------------------------
        /// <summary>
        /// Contructor de suma
        /// </summary>
        /// <param name="a">matriz A</param>int
        /// <param name="b">matriz B</param>int
        public suma(int a, int b) 
        {
            ma = a;
            mb = b;
        }        
        //---------------------------------------------------------------------
        /// <summary>
        /// Matriz resultante de la Suma
        /// </summary>
        public float[,] resultado;             
        //---------------------------------------------------------------------
        public int ma;
        //---------------------------------------------------------------------
        public int mb;
        //---------------------------------------------------------------------
    }
    //*************************************************************************

    /// <summary>
    /// Clase Resta - Contiene ->Resultado y numero de matrices utilizadas
    /// </summary>
    [Serializable()]
    public class resta
    {
        //---------------------------------------------------------------------
        /// <summary>
        /// Contructor de Resta
        /// </summary>
        /// <param name="a">matriz A</param>int
        /// <param name="b">matriz B</param>int
        public resta(int a, int b) 
        {
            ma = a;
            mb = b;
        }
        //---------------------------------------------------------------------       
        /// <summary>
        /// Matriz resultante de la Resta
        /// </summary>
        public float[,] resultado;
        //--------------------------------------------------------------------- 
        public int ma;
        //---------------------------------------------------------------------
        public int mb;
        //---------------------------------------------------------------------
    }
    //*************************************************************************

    /// <summary>
    /// Clase Producto - Contiene ->Resultado y numero de matrices utilizadas
    /// </summary>
    [Serializable()]
    public class producto
    {
        //---------------------------------------------------------------------
        /// <summary>
        /// Contructor de Producto
        /// </summary>
        /// <param name="a">matriz A</param>int
        /// <param name="b">matriz B</param>int
        public producto(int a, int b)
        {
            ma = b;
            mb = a;
        }
        //---------------------------------------------------------------------       
        /// <summary>
        /// Matriz resultante del Producto
        /// </summary>
        public float[,] resultado;
        //--------------------------------------------------------------------- 
        public int ma;
        //---------------------------------------------------------------------
        public int mb;
        //---------------------------------------------------------------------
    }
    //*************************************************************************
    /// <summary>
    /// Clase Inversa - Contiene ->Resultado y numero de matrices utilizadas
    /// </summary>
    [Serializable()]
    public class inversa
    {
        //---------------------------------------------------------------------
        /// <summary>
        /// Contructor de Inversa
        /// </summary>
        /// <param name="a">matriz A</param>int
        /// <param name="num">matriz resultado</param>
        /// <param name="deter">determinante obtenido</param>
        public inversa(int ma1, float[,] matrix, float deter)
        {
            ma = ma1;
            resultado = matrix;
            determinante = deter;
        }
        //---------------------------------------------------------------------       
        /// <summary>
        /// Matriz Inversa
        /// </summary>
        public float[,] resultado;
        //--------------------------------------------------------------------- 
        public int ma;        
        //---------------------------------------------------------------------
        public float determinante;
        //---------------------------------------------------------------------
    }
    /// <summary>
    /// Clase Gauss
    /// almacena matrices sometidas al metodo de gauss
    /// almacena matriz y el indice de la matriz original utilizada
    /// </summary>
    [Serializable()]    
    public class gauss
    {
        //---------------------------------------------------------------------
        /// <summary>
        /// Constructor de matriz gauss
        /// </summary>
        /// <param name="ma1">indice de matriz original</param>
        /// <param name="matrix">matriz resultado de operacion gauss</param>
        public gauss(int num, float[,] matrix)
        {
            ma = num;
            resultado = matrix;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// resultado de la operacion gauss
        /// </summary>
        public float[,] resultado;
        //--------------------------------------------------------------------- 
        /// <summary>
        /// Indice de martiz original
        /// </summary>
        public int ma;
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