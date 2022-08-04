using Entidades;
using AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmNuevoItem : Form
    {
                   
        private string condicion;
        
       
        public frmNuevoItem()
        {
            InitializeComponent();
        }


        public frmNuevoItem(string clicEn)
        {
            InitializeComponent();
            condicion = clicEn;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNuevoItem_Load(object sender, EventArgs e)
        {
            if (condicion == "Categoria")   //Hizo Clic en Categoria
                {
                actualizarListaCategoria();
                lblLista.Text = "Listado de Categorias:";
                lblNuevoItem.Text = "Ingrese Nueva Categoria:";
    
                }
                else                       //Hizo Clic en Marca
                    {
                    actualizarListaMarca();
                    lblLista.Text = "Listado de Marcas:";
                    lblNuevoItem.Text = "Ingrese Nueva Marca:";

            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardarDato();
        }


        private void actualizarListaCategoria()
        {
            CategoriaDatos items = new CategoriaDatos();
            List<Categoria> listaCategoria;
            lbItems.Items.Clear();
            try
            {
                listaCategoria = items.listarCategoria();

                foreach (var categoria in listaCategoria)
                {
                    lbItems.Items.Add(categoria.DescripcionCategoria);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión con la Base de Datos");
            }
            txtNuevoItem.Text = "";

        }


        private void actualizarListaMarca()
        {
            MarcaDatos items = new MarcaDatos();
            List<Marca> listaMarca;

            lbItems.Items.Clear();
            try
            {
                listaMarca = items.listarMarca();

                foreach (var marca in listaMarca)
                {
                    lbItems.Items.Add(marca.DescripcionMarca);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión con la Base de Datos");
            }
            txtNuevoItem.Text = "";
        }

        private void txtNuevoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                guardarDato();

        }


        private void guardarDato()
        {
            if (txtNuevoItem.Text != "")
            {
                try
                {
                    if (condicion == "Categoria")   //Hizo Clic en Categoria
                    {
                        CategoriaDatos datos = new CategoriaDatos();
                        string cadena = txtNuevoItem.Text;
                        datos.agregarCategoria(cadena);
                        MessageBox.Show("La nueva Categoria fue guardada con éxito");
                        actualizarListaCategoria();

                    }
                    else                       //Hizo Clic en Marca
                    {

                        MarcaDatos datos = new MarcaDatos();
                        string cadena = txtNuevoItem.Text;
                        datos.agregarMarca(cadena);
                        MessageBox.Show("La nueva Marca fue guardada con éxito");
                        actualizarListaMarca();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error de conexión con la Base de Datos");
                }
                
            }
        }

     

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNuevoItem.Text = lbItems.SelectedItem.ToString();
            btnAceptar.Enabled = false;
            btnEliminar.Enabled = true;
            txtNuevoItem.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (condicion == "Categoria")   //Hizo Clic en Categoria
                {
                    CategoriaDatos datos = new CategoriaDatos();
                    string cadena = lbItems.SelectedItem.ToString();
                    datos.eliminarCategoria(cadena);
                    MessageBox.Show("La  Categoria fue Eliminada con éxito");
                    actualizarListaCategoria();

                }
                else                       //Hizo Clic en Marca
                {
                    MarcaDatos datos = new MarcaDatos();
                    string cadena = lbItems.SelectedItem.ToString();
                    datos.eliminarMarca(cadena);
                    MessageBox.Show("La  Marca fue Eliminada con éxito");
                    actualizarListaMarca();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión con la Base de Datos");
            }
           
            btnEliminar.Enabled = false;
            txtNuevoItem.Enabled = true;

        }

        private void txtNuevoItem_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
        }
    }
}
