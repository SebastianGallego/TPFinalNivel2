using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoADatos;
using Entidades;


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


//Funcionalidades:

// -Formulario Principal



// -Formulario AltaModificacion





// -Formulario NuevoItem
//  Se utiliza para agregar o quilar elementos de las tablas "Categorias" y "Marcas" 
//  Muestra el contenido en un ListBox segun de donde viene desde el formulario principal (Categoria ó Marca).
//  Se puede agregar un Item Nuevo, esta validado que no sea un valor nulo. El alta funciona con el boton "Aceptar" como con enter dentro del Texbox.
//  El boton eliminar solo esta disponible si hay un Item seleccionado en el listbox.
//  Cuando se selecciona un Item se deshabilita el boton Aceptar para que no se pueda hacer un Alta.

// -Formulario AcercaDe
// Muestra informacion de la App. 
// La etiquieta www.maxiprograma.com funciona como un link a la web.
// Las imagenes de Correo, Linkedin y Github contiene link a dichas direcciones del desarrollador.








namespace Presentacion
{
    public partial class frmPrincipal : Form
    {

        private List<Articulo> listaArticulo;


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

     

        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmNuevoItem categoria = new frmNuevoItem(sender.ToString());
           categoria.ShowDialog();
        }

        private void MarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoItem marca = new frmNuevoItem(sender.ToString());
            marca.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe ventana = new frmAcercaDe();
            ventana.ShowDialog();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            ActualizarGrilla();


        }






        private void ActualizarGrilla()
        {
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                listaArticulo = datos.listarArticulo();
                dgvArticulos.DataSource = listaArticulo;
                //ocultarColumnas();
                //cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Conexión con la Base de Datos");
            }
        }







    }
}
