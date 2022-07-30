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


        private List<Categoria> listaCategoria;
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


            if (condicion == "Categoria")
                MessageBox.Show("Viene de Categoria");
            else
                MessageBox.Show("Viene de Marca");


            
            
            actualizarLista();


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConectarDatos datos = new ConectarDatos();

            try
            {
                datos.setearConsulta("Insert into categorias (Descripcion) values (@desc) ");
                datos.setearParametro("@desc", txtNuevoItem.Text); 
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión con la Base de Datos");
            }
            finally
            {
                datos.cerrarConexion();
            }
            txtNuevoItem.Text = "";
            lwItems.Clear();
            actualizarLista();


        }


        private void actualizarLista()
        {
            CategoriaDatos item = new CategoriaDatos();

            try
            {
                listaCategoria = item.listar();

                foreach (var categoria in listaCategoria)
                {
                    lwItems.Items.Add(categoria.DescripcionCategoria);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión con la Base de Datos");
            }

        }

    }
}
