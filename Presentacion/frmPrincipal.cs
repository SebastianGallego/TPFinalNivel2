using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Consigna TP Integrador

//Se necesita una aplicación para la gestión de artículos de un catálogo de un comercio.
//La aplicación debe ser genérica es decir, aplicar para cualquier tipo de comercio.

//Deberá ser una aplicación de escritorio que contemple la administración de artículos.
//Las funcionalidades que deberá tener la aplicación serán:

//    Listado de artículos.
//    Búsqueda de artículos por distintos criterios.
//    Agregar artículos.
//    Modificar artículos.
//    Eliminar artículos.
//    Ver detalle de un artículo.


//Los datos mínimos con los que deberá contar el artículo son los siguientes:

//    Código de artículo.
//    Nombre.
//    Descripción.
//    Marca (seleccionable de una lista desplegable).
//    Categoría(seleccionable de una lista desplegable.
//    Imagen.
//    Precio.


//Etapa 1: Construir las clases necesarias para el modelo de dicha aplicación junto a las ventanas con las que contará y su navegación.

//Etapa 2: Construir la interacción con la base de datos y validaciones correspondiente para dar vida a la funcionalidad.

//Consideraciones: la app debe manejar arquitectura en capas, manejo de excepciones y validaciones cuando corresponda.






namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaModificacion ventana = new frmAltaModificacion();
            ventana.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaModificacion ventana = new frmAltaModificacion();    
            ventana.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaModificacion ventana = new frmAltaModificacion();
            ventana.ShowDialog();
        }

        private void agrgarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoItem ventana = new frmNuevoItem();
            ventana.ShowDialog();
        }
    }
}
