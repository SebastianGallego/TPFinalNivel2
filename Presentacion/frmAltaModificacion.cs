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

namespace Presentacion
{
    public partial class frmAltaModificacion : Form
    {

        private Articulo elementoArticulo = null;

        public frmAltaModificacion()  //Agregar
        {
            InitializeComponent();
            btnAceptar.Text = "Guardar";
            Text = "Agregar Nuevo Artículo";
        }


        public frmAltaModificacion(Articulo articulo)   //Modificar
        {
            InitializeComponent();
            elementoArticulo = articulo;
            btnAceptar.Text = "Modificar";
            Text = "Modificar Artículo";
        }

        private void frmAM_Load(object sender, EventArgs e)
        {
            CategoriaDatos categorias = new CategoriaDatos();
            MarcaDatos marcas = new MarcaDatos();


            try
            {
                cboCategoria.DataSource = categorias.listarCategoria();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "DescripcionCategoria";
                cboMarca.DataSource = marcas.listarMarca();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "DescripcionMarca";

                if (elementoArticulo != null)
                {
                    txtCodigo.Text = elementoArticulo.Codigo.ToString();
                    txtNombre.Text = elementoArticulo.Nombre;
                    txtDescripcion.Text = elementoArticulo.Descripcion;
                    txtImagenUrl.Text = elementoArticulo.ImagenUrl;
                    cargarImagen(txtImagenUrl.Text);
                    txtPrecio.Text = Math.Round(elementoArticulo.Precio,2).ToString();
                    cboCategoria.SelectedValue = elementoArticulo.Categoria.Id;
                    cboMarca.SelectedValue = elementoArticulo.Marca.Id;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conexión con la Base de Datos");
            }
        }


        private void cargarImagen(string cadenaImagen)
        {
            try
            {
                pbImagen.Load(cadenaImagen);
            }
            catch (Exception)
            {
                pbImagen.Load("https://www.trinomusic.com/sites/default/files/default_images/imagen-no-disponible.gif");
            }
        }


        private void validarNumerico() 
        { 
        //txtPrecio.Text 
        
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                if (elementoArticulo == null)
                    elementoArticulo = new Articulo();

                elementoArticulo.Codigo = txtCodigo.Text;
                elementoArticulo.Nombre = txtNombre.Text;
                elementoArticulo.Descripcion = txtDescripcion.Text;
                elementoArticulo.ImagenUrl = txtImagenUrl.Text;
                elementoArticulo.Precio = decimal.Parse(txtPrecio.Text); 
                elementoArticulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                elementoArticulo.Marca = (Marca)cboMarca.SelectedItem;

                if (elementoArticulo.Id != 0)
                {
                    datos.modificarArticulo(elementoArticulo);
                    MessageBox.Show("Artículo Modificado");
                }
                else
                {
                    datos.agregarArticulo(elementoArticulo);
                    MessageBox.Show("Artículo Guardado");
                }

               

                
                Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al Guardar o Modificar Artículo");
            }


        }

       
    }
}
