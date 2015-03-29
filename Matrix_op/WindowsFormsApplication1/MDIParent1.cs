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
 Fecha creación: 08/03/2015
 Última modificación: 19/03/2015
 Versión: 1.1 - BETA
********************************/

namespace WindowsFormsApplication1
{
    public partial class MDIParent1 : Form
    {
        //----DECLARACIONES---------------------------------------------------
        //
        private int childFormNumber = 0;  // N Ventanas hijas utilizadas
        public prin datos = new prin();  // Objeto Principal, sobre el que se cargarn todos los datos
        public temaApp skin = new temaApp();
        FormWebBrowser FWebBrowser;     // Formulario para mostrar rtesultados en html
        OperacionesForm operaForm;      //Formulario para realizar operaciones
        ayudaForm ayuda;                //Formulario de ayuda de aplicacion
        FormOperaNumMa operaNumero;     //Formulario de operaciones con numeros
        FormAdministrador admin;        //Formulario de administracion de matrices
        Rellena Rellenar;        
        string help = Directory.GetCurrentDirectory().ToString() + "\\files\\help_m_op.html";
        //
        //--------------------------------------------------------------------        

        //------------------------FUNCIONES-----------------------------------
        /// <summary>
        /// Contructor de la ventana principal de la Aplicacion
        /// </summary>
        public MDIParent1()
        {            
            InitializeComponent();
            FWebBrowser = new FormWebBrowser(ref datos);
            datos.Nombre_Del_Archivo = "";
            FWebBrowser.MdiParent = this;
            ayuda = new ayudaForm(help);
            cargaTema();
            //todo - eliminar funcion en version final
            //cargaAutoPrueba();
        }
        //--------------------------------------------------------------------
        /// <summary>
        /// MUESTRA VENTANA DE NUEVAS MATRICES
        /// </summary>
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form2 childForm = new Form2(ref datos, skin.fondo, skin.letras);
            try
            {
                childForm.Text = "Nuevas Matrices " + childFormNumber++;
                childForm.StartPosition = FormStartPosition.CenterParent;
                childForm.ShowDialog();                
            }
            catch (Exception) {
                MessageBox.Show("Fallo al crear Form2 ChildForm", "caption", MessageBoxButtons.OK);
            }
            // despues de cerrar el modal
            // creamos la ventana de matriz *****************************************
            if (datos.resp)
            {
                Cerrar_Ventanas();
                try
                {
                    if (Rellenar == null)
                    {
                        Rellenar = new Rellena(ref this.datos, skin.fondo, skin.letras);
                        Rellenar.MdiParent = this;
                    }
                    else
                    {
                        Rellenar.refreshGrid();
                    }
                    //mostrar la ventana
                    Rellenar.BringToFront();
                    Rellenar.WindowState = FormWindowState.Maximized;
                    Rellenar.Show();
                }
                catch (ObjectDisposedException)
                {
                    Rellenar = new Rellena(ref this.datos, skin.fondo, skin.letras);
                    Rellenar.MdiParent = this;
                    //mostrar la ventana
                    Rellenar.BringToFront();
                    Rellenar.WindowState = FormWindowState.Maximized;
                    Rellenar.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Fallo al crear Rellenar matriz Form", "caption", MessageBoxButtons.OK);
                }              
            }            
        }
        //--------------------------------------------------------------------
        /// <summary>
        /// Windows Form -> Cargar Archivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de Matrices (*.mat)|*.mat|Todos los archivos (*.*)|*.*";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            //openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)//Solo al pulsar aceptar
            {                
                try//Si el archivo seleccionado Contiene datos compatibles
                {
                    datos.Nombre_Del_Archivo = openFileDialog1.FileName;
                    myStream = File.OpenRead(datos.Nombre_Del_Archivo);//Leemos el archivo seleccionado
                    BinaryFormatter deseri = new BinaryFormatter();

                    datos = deseri.Deserialize(myStream) as prin;//Abrimos el archivo
                    myStream.Close();
                    this.labelEstado.Text = "Archivo Cargado con Exito";
                    Cerrar_Ventanas();                    
                }
                catch (Exception ex)//Si el archivo seleccionado NO Contiene datos compatibles
                {
                    MessageBox.Show("Error: EL ARCHIVO SELECCIONADO NO CONTIENE DATOS COMPATIBLES." +
                        "\r\n Original error: " + ex.Message);

                    //INFORMACION EN LA BARRA DE ESTADO                    
                    this.labelEstado.Text = "ERROR INTENTANDO CARGAR :" + datos.Nombre_Del_Archivo;
                }//SE MUESTRA PANTALLA DE ERROR Y EL ERROR ORIGINAL
            }
            Mostrar_Formulario_HTML();
        }
        //--------------------------------------------------------------------
        /// <summary>
        /// Windows Form -> Guardar Archivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
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
        //--------------------------------------------------------------------
        /// <summary>
        /// Llama a -> comprobarGuardado();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            comprobarGuardado(sender, e);
        }
        //--------------------------------------------------------------------
        /// <summary>
        /// Llama a -> comprobarGuardado();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comprobarGuardado(sender, e);
        }
        //--------------------------------------------------------------------
        /// <summary>
        /// Elige entre opcion de Guardar o Guardar como 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comprobarGuardado(object sender, EventArgs e) 
        {
            if (datos.Nombre_Del_Archivo != "") // Comprobar que hay archivo cargado
            {
                guardar();
            }
            else
            {
                SaveAsToolStripMenuItem_Click(sender, e); // Guardar Como
            }
        }
        //--------------------------------------------------------------------
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
                this.labelEstado.Text = "Archivo GUARDADO CORRECTAMENTE en:" + datos.Nombre_Del_Archivo;
                MessageBox.Show("Datos Guardados en:\r\n\r\n" + datos.Nombre_Del_Archivo);
            }
            catch (Exception)
            {
                this.labelEstado.Text = "FALLO AL ESCRIBIR EN: " + datos.Nombre_Del_Archivo;
                MessageBox.Show("FALLO AL ESCRIBIR EN: " + datos.Nombre_Del_Archivo);
            }
        }
        //--------------------------------------------------------------------
        /// <summary>
        /// CERRAR VENTANA PRINCIPAL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //--------------------------------------------------------------------

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }
        //--------------------------------------------------------------------

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        //--------------------------------------------------------------------
        /// <summary>
        /// mostrar ventanas abiertas en cascada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        //--------------------------------------------------------------------
        /// <summary>
        /// mostrar ventanas abiertas en vertical
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        //--------------------------------------------------------------------
        /// <summary>
        /// mostrar ventanas abiertas en horizonal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        //--------------------------------------------------------------------
        /// <summary>
        /// organizacion de iconos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }       
        //--------------------------------------------------------------------
        /// <summary>
        /// Cierra Todos los formularios menos el de Menu Principal
        /// Se utiliza Al cargar un Archivo diferente al ejecutado
        /// </summary>
        public void Cerrar_Ventanas()
        {
            try
            {
                int tamano = this.MdiChildren.Count() - 1;
                for (int i = tamano; i >= 0; i--)
                {
                    this.MdiChildren[i].Close();
                }                
            }
            catch (Exception) { }
            Mostrar_Formulario_HTML();
        }
        //----------------------------------------------------------------------------------------------
        /// <summary> 
        /// Muestra FormWebBrowser
        /// </summary>
        /// <param name="Archivo">Nombre del archivo utilizado</param>string
        private void Mostrar_Formulario_HTML()
        {
            try
            {
                FWebBrowser.WindowState = FormWindowState.Maximized;
                FWebBrowser.Show();
            }
            catch (ObjectDisposedException)
            {
                FWebBrowser = new FormWebBrowser(ref datos);
                FWebBrowser.MdiParent = this;
                FWebBrowser.WindowState = FormWindowState.Maximized;
                FWebBrowser.Show();
            }
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Muestra ventana de datos html
        /// </summary>
        private void showForceHtml()
        {
            try
            {
                FWebBrowser.BringToFront();
                FWebBrowser.WindowState = FormWindowState.Maximized;
                FWebBrowser.Show();
            }
            catch (ObjectDisposedException)
            {
                FWebBrowser = new FormWebBrowser(ref datos);
                FWebBrowser.MdiParent = this;
                FWebBrowser.BringToFront();
                FWebBrowser.WindowState = FormWindowState.Maximized;
                FWebBrowser.Show();
            }
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// menu de opciones de aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo- menu de opciones de aplicacion principal
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// MUESTRA VENTANA DE NUEVAS MATRICES
        /// </summary>
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm(sender, e);
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Muestra ventana de operar con matrices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oPERACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            int matrix = this.datos.matrices.Count;
            if (matrix > 0)
            {
                //------------EXISTEN DATOS------------------------------------ 
                try
                {
                    if (operaForm == null)
                    {
                        operaForm = new OperacionesForm(this.datos, skin.fondo, skin.letras);
                        operaForm.MdiParent = this;
                    }
                    //mostrar la ventana
                    operaForm.BringToFront();
                    operaForm.WindowState = FormWindowState.Maximized;
                    operaForm.Show();
                }
                catch (ObjectDisposedException)
                {
                    operaForm = new OperacionesForm(this.datos, skin.fondo, skin.letras);
                    operaForm.MdiParent = this;
                    //mostrar la ventana
                    operaForm.BringToFront();
                    operaForm.WindowState = FormWindowState.Maximized;
                    operaForm.Show();
                }
                //------------------------------------------------------------
            }
            else
            {
                //--------------------NO EXISTEN DATOS--------------
                string text = "No hay Matrices para operar.\n\n\tAñada matrices";
                MessageBox.Show(text, "No hay matrices", MessageBoxButtons.OK);
            }
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// muestra el formulario de ayuda de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showHelp();          
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// muestra el formulario de ayuda de la aplicacion
        /// </summary>
        private void showHelp()
        {
            try
            {
                if (ayuda == null)
                {
                    ayuda = new ayudaForm(help);
                }
                ayuda.Show();
                ayuda.BringToFront();
                ayuda.WindowState = FormWindowState.Normal;
            }
            catch (ObjectDisposedException)
            {
                ayuda = new ayudaForm(help);
                ayuda.Show();
                ayuda.BringToFront();
                ayuda.WindowState = FormWindowState.Normal;
            }
            catch (Exception) { }
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// IMPRIMIR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            impresion();
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// IMPRIMIR
        /// </summary>
        private void impresion() 
        {
            this.FWebBrowser.webBrowser1.ShowPrintDialog();
        }    
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// IMPRIMIR
        /// </summary>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            impresion();
        }
        //----------------------------------------------------------------------------------------------
        private void MDIParent1_Enter(object sender, EventArgs e)
        {
            
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// evento de activacion de la ventana
        /// MUESTRA EL FORMULARIO HTML CON LOS DATOS DE LA APLICACION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MDIParent1_Activated(object sender, EventArgs e)
        {
            // mostrar datos al recuperar foco
            Mostrar_Formulario_HTML();
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// muestra el formulario de ayuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            showHelp();
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// MUESTRA EL FORMULARIO HTML CON LOS DATOS DE LA APLICACION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            showForceHtml();
            //Mostrar_Formulario_HTML();
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// MUESTRA EL FORMULARIO HTML CON LOS DATOS DE LA APLICACION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarDatosHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForceHtml();
            //Mostrar_Formulario_HTML();
        }
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// muestra vista pervia de impresion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            impresionPreview();
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// muestra vista pervia de impresion
        /// </summary>
        private void impresionPreview() 
        {
            this.FWebBrowser.webBrowser1.ShowPrintPreviewDialog();
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// muestra vista pervia de impresion
        /// </summary>
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            impresionPreview();
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Muestra ventana de operaciones Matriz-Numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operarConMatrizNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int matrix = this.datos.matrices.Count;
            if (matrix > 0)
            {
                //------------EXISTEN DATOS------------------------------------ 
                try
                {
                    if (operaNumero == null)
                    {
                        operaNumero = new FormOperaNumMa(this.datos, skin.fondo, skin.letras);
                        operaNumero.MdiParent = this;
                    }
                    //mostrar la ventana
                    operaNumero.BringToFront();
                    operaNumero.WindowState = FormWindowState.Maximized;
                    operaNumero.Show();
                }
                catch (ObjectDisposedException)
                {
                    operaNumero = new FormOperaNumMa(this.datos, skin.fondo, skin.letras);
                    operaNumero.MdiParent = this;
                    //mostrar la ventana
                    operaNumero.BringToFront();
                    operaNumero.WindowState = FormWindowState.Maximized;
                    operaNumero.Show();
                }
                //------------------------------------------------------------
            }
            else
            {
                //--------------------NO EXISTEN DATOS--------------
                string text = "No hay Matrices para operar.\n\n\tAñada matrices";
                MessageBox.Show(text, "No hay matrices", MessageBoxButtons.OK);
            }
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Carga datos para inicio rapido de datos
        /// DESACTIVAR EN VERSION FINAL - NO BETA
        /// </summary>
        private void cargaAutoPrueba() 
        {
            //todo - eliminar funcion en version final
            Stream myStream;
             try//Si el archivo seleccionado Contiene datos compatibles
                {
                    datos.Nombre_Del_Archivo = Directory.GetCurrentDirectory().ToString() + "\\matrices.mat";
                    myStream = File.OpenRead(datos.Nombre_Del_Archivo);//Leemos el archivo seleccionado
                    BinaryFormatter deseri = new BinaryFormatter();

                    datos = deseri.Deserialize(myStream) as prin;//Abrimos el archivo
                    myStream.Close();
                    this.labelEstado.Text = "Archivo Cargado con Exito";
                    Cerrar_Ventanas();                    
                }
                catch (Exception ex)//Si el archivo seleccionado NO Contiene datos compatibles
                {
                    MessageBox.Show("Error: EL ARCHIVO SELECCIONADO NO CONTIENE DATOS COMPATIBLES." +
                        "\r\n Original error: " + ex.Message);

                    //INFORMACION EN LA BARRA DE ESTADO                    
                    this.labelEstado.Text = "ERROR INTENTANDO CARGAR :" + datos.Nombre_Del_Archivo;
                }//SE MUESTRA PANTALLA DE ERROR Y EL ERROR ORIGINAL            
            Mostrar_Formulario_HTML();
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Muestra formulario de administracion de matrices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void administrarMatricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo admisnistrador de matrices
            int matrix = this.datos.matrices.Count;
            if (matrix > 0)
            {
                //------------EXISTEN DATOS------------------------------------ 
                try
                {
                    if (admin == null)
                    {
                        admin = new FormAdministrador(this.datos, skin.fondo, skin.letras);
                        admin.MdiParent = this;
                    }
                    //mostrar la ventana
                    admin.BringToFront();
                    admin.WindowState = FormWindowState.Maximized;
                    admin.Show();
                }
                catch (ObjectDisposedException)
                {
                    admin = new FormAdministrador(this.datos, skin.fondo, skin.letras);
                    admin.MdiParent = this;
                    //mostrar la ventana
                    admin.BringToFront();
                    admin.WindowState = FormWindowState.Maximized;
                    admin.Show();
                }
                //------------------------------------------------------------
            }
            else
            {
                //--------------------NO EXISTEN DATOS--------------
                string text = "No hay Matrices para operar.\n\n\tAñada matrices";
                MessageBox.Show(text, "No hay matrices", MessageBoxButtons.OK);
            }
        }
        //---------------------------------------------------------------------
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Matrix Opertions V1.1\n\n http://likiworld.blogspot.es";
            MessageBox.Show(text, "Acerca de:", MessageBoxButtons.OK);
        }
        //---------------------------------------------------------------------
        private void eDarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema(Color.DimGray, Color.Lime);
        }
        //---------------------------------------------------------------------
        private void predeterminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema((Color)SystemColors.Control, (Color)SystemColors.ControlText);
        }
        //---------------------------------------------------------------------
        private void lightYellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema(Color.LightYellow, Color.Black);
        }
        //---------------------------------------------------------------------
        private void tema(Color fond, Color letr)
        {
            skin = new temaApp(fond, letr);
            skin.fondo = fond;
            skin.letras = letr;
            this.menuStrip.BackColor = fond;
            this.menuStrip.ForeColor = letr;
            this.statusStrip.BackColor = fond;
            this.statusStrip.ForeColor = letr;
            this.toolStrip.BackColor = fond;
            this.toolStrip.ForeColor = letr;
            temaHijos(fond, letr);
            salvaTema(fond, letr);            
        }
        //---------------------------------------------------------------------
        private void temaHijos(Color c1, Color c2) 
        {
            int tamano = this.MdiChildren.Count() - 1;
            for (int i = tamano; i >= 0; i--)
            {
                this.MdiChildren[i].BackColor = c1;
                this.MdiChildren[i].ForeColor = c2;
            }
        }
        //---------------------------------------------------------------------
        private void lightBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema(Color.LightSteelBlue, Color.Black);
        }
        //---------------------------------------------------------------------
        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema(Color.LightPink, Color.Black);
        }
        //---------------------------------------------------------------------
        private void cargaTema()
        {
            try
            {
                string filSkin = Directory.GetCurrentDirectory().ToString() + "\\files\\skin.dat";
                Stream myStream = File.OpenRead(filSkin);//Leemos el archivo seleccionado
                BinaryFormatter deseri = new BinaryFormatter();
                skin = deseri.Deserialize(myStream) as temaApp;//Abrimos el archivo
                myStream.Close();
                tema(skin.fondo, skin.letras);
            }
            catch (Exception) { }            
        }

        //---------------------------------------------------------------------
        private void salvaTema(Color fond, Color letr)
        {
            try
            {
                string filSkin = Directory.GetCurrentDirectory().ToString() + "\\files\\skin.dat";
                Stream myStream;
                myStream = File.Create(filSkin);//se crea carchivo con el nombre seleccionado
                BinaryFormatter seri = new BinaryFormatter();
                seri.Serialize(myStream, skin);//Se guarda en el archivo el objeto Completo                
                myStream.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("fallo al guardar tema en memoria", "fallo", MessageBoxButtons.OK);
            }
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // licencia de la aplicacion
            string license = "Matrix Operations. License\n\n" +
            "Matrix Operations is free software: you can redistribute it and/or modify\n" +
            "it under the terms of the GNU General Public License as published by\n" +
            "the Free Software Foundation, either version 3 of the License, or\n" +
            "(at your option) any later version.\n" +
            "\n" +
            "Matrix Operations is distributed in the hope that it will be useful,\n" +
            "but WITHOUT ANY WARRANTY; without even the implied warranty of\n" +
            "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the\n" +
            "GNU General Public License for more details.\n" +
            "\n" +
            "You should have received a copy of the GNU General Public License\n" +
            "along with Matrix Operations.  If not, see <http://www.gnu.org/licenses/>.";
            // mostramos ventan con la licencia de la aplicacion
            MessageBox.Show(license, "License", MessageBoxButtons.OK);
        }
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