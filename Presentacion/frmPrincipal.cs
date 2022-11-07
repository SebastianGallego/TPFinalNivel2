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
using Presentacion;


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
//  Al iniciar carga todo el listado de Articulos.
//  Al hacer clic en el DataGrid se actualiza la imagen y el detalle del Articulo.
//  Está formateado el precio con 2 decimales tanto en la grilla como en el listbox.
//  Los botones Agregar y Modificar llaman al mismo formulario pero con diferente funcionalidad.
//  El boton de Filtro Avanzado del Panel queda retenido como una llave y no como un pulsador
//  activando el grupo de Filtro Avanzado
//  Al hacer clic en el datagrid se habilita la opcion para Modificar o Eliminar el producto




// -Formulario AltaModificacion
//  Permite hacer modificaciones en los campos del producto
//  Funciona tanto para dar un alta como para modificar
//



// -Formulario NuevoItem
//  Se utiliza para agregar o quilar elementos de las tablas "Categorias" y "Marcas" 
//  Muestra el contenido en un ListBox segun de donde viene desde el formulario principal (Categoria ó Marca).
//  Se puede agregar un Item Nuevo, esta validado que no sea un valor nulo. El alta funciona con el boton "Aceptar" como con enter dentro del Texbox.
//  El boton eliminar solo esta disponible si hay un Item seleccionado en el listbox.
//  Cuando se selecciona un Item se deshabilita el boton Aceptar para que no se pueda hacer un Alta.

// -Formulario AcercaDe
//  Muestra informacion de la App. 
//  La etiquieta www.maxiprograma.com funciona como un link a la web.
//  Las imagenes de Correo, Linkedin y Github contiene link a dichas direcciones del desarrollador.







namespace Presentacion
{
    public partial class frmPrincipal : Form
    {

        private List<Articulo> listaArticulo;
        private bool onOff = false;
        

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
           modificarArticulo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarArticulo();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarArticulo();
        }

        private void agregarArticulo()
        {
            frmAltaModificacion ventana = new frmAltaModificacion();
            ventana.ShowDialog();
            ActualizarGrilla();
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
            ocultarColumnas();
            cargarCombos();
            gbFiltroAvanzado.Visible = false;
            txtMaximo.Visible = false;
            lblMinimo.Text = "Valor:";
            lblMaximo.Visible = false;

        }


        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
        }



        private void ActualizarGrilla()
        {
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                listaArticulo = datos.listarArticulo();
                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N2";
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Conexión con la Base de Datos");
            }

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Enabled = false;
                
            pbImagen.Image = null;
            lbDetalles.Items.Clear();
            ocultarColumnas();

        }

       

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                lbDetalles.Items.Clear();
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
                lbDetalles.Items.Add("Código: " + seleccionado.Codigo);
                lbDetalles.Items.Add("Nombre: " + seleccionado.Nombre);
                lbDetalles.Items.Add("Descripción: " + seleccionado.Descripcion);
                lbDetalles.Items.Add("Marca: " + seleccionado.Marca);
                lbDetalles.Items.Add("Categoria: " + seleccionado.Categoria);
                lbDetalles.Items.Add("Precio: $ " + Math.Round(seleccionado.Precio, 2));
               
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                eliminarToolStripMenuItem.Enabled = true;
                modificarToolStripMenuItem.Enabled = true;
                
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
                pbImagen.Load("https://www.sogarca.com/wp-content/uploads/2015/06/No-disponible.jpg");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarArticulo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarArticulo();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarArticulo();
        }


        private void eliminarArticulo()
        {
            ArticuloDatos datos = new ArticuloDatos();
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                string cadena = seleccionado.Nombre + "  \nMarca: " + seleccionado.Marca + "  \nCategoría: " + seleccionado.Categoria;
                DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere eliminar el Artículo: \n \n" + cadena, "Eliminando Artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    datos.eliminarArticulo(seleccionado.Id);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de comunicación con la Base de Datos");
            }
            ActualizarGrilla();
        }

        


        private void modificarArticulo()
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaModificacion modificar = new frmAltaModificacion(seleccionado);
            modificar.ShowDialog();
            ActualizarGrilla();
        }

        

        private void cargarCombos()
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
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conexión con la Base de Datos");
            }
            limpiarFiltroRapido();

            cboPrecio.Items.Add("Igual a");
            cboPrecio.Items.Add("Mayor a");
            cboPrecio.Items.Add("Menor a");
            cboPrecio.Items.Add("Entre");
            cboCriterio.Items.Add("Comienza con");
            cboCriterio.Items.Add("Termina Con");
            cboCriterio.Items.Add("Contiene");
        }


        private void limpiarFiltroRapido()
        {
            cboCategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            ActualizarGrilla();
        }

       

        private void btnLimpiarFiltroRapido_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = "";
            limpiarFiltroRapido();
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroRapido();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroRapido();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtroRapido();
        }

        private void filtroRapido()
        {

            List<Articulo> listaFiltrada;
            string cadenaFiltro = txtFiltro.Text;

            if (cboMarca.SelectedIndex > -1 && cboCategoria.SelectedIndex > -1)  //Si está seleccionado Marca y Categoria, mas el Filtro de Texto
            {
                listaFiltrada = listaArticulo.FindAll((item => (item.Codigo.ToUpper().Contains(cadenaFiltro.ToUpper()) || item.Nombre.ToUpper().Contains(cadenaFiltro.ToUpper())) && (item.Marca.DescripcionMarca == cboMarca.Text && item.Categoria.DescripcionCategoria == cboCategoria.Text)));
            }
            else if (cboMarca.SelectedIndex > -1 && cboCategoria.SelectedIndex < 0) //Si está seleccionado Marca Pero No Categoria, mas el Texto
            {
                listaFiltrada = listaArticulo.FindAll(item => item.Marca.DescripcionMarca == cboMarca.Text && (item.Codigo.ToUpper().Contains(cadenaFiltro.ToUpper()) || item.Nombre.ToUpper().Contains(cadenaFiltro.ToUpper())));
            }
            else if (cboMarca.SelectedIndex < 0 && cboCategoria.SelectedIndex > -1)//Si esta seleccionado Categoria pero no Marca, el Texto
            {
                listaFiltrada = listaArticulo.FindAll(item => item.Categoria.DescripcionCategoria == cboCategoria.Text && (item.Codigo.ToUpper().Contains(cadenaFiltro.ToUpper()) || item.Nombre.ToUpper().Contains(cadenaFiltro.ToUpper())));
            }
            else if (cadenaFiltro=="" && cboMarca.SelectedIndex < 0 && cboCategoria.SelectedIndex > -1 )//Si esta seleccionado Categoria pero no Marca, SIN Texto
            {
                listaFiltrada = listaArticulo.FindAll(item => item.Categoria.DescripcionCategoria == cboCategoria.Text);
            }
            else if (cadenaFiltro == "" && cboMarca.SelectedIndex > -1 && cboCategoria.SelectedIndex < 0)//Si esta seleccionado Marca pero no Categoria, SIN Texto
            {
                listaFiltrada = listaArticulo.FindAll(item => item.Marca.DescripcionMarca == cboMarca.Text);
            }
            else  // Filtro con solo el texto
            {
                listaFiltrada = listaArticulo.FindAll(item => item.Codigo.ToUpper().Contains(cadenaFiltro.ToUpper()) || item.Nombre.ToUpper().Contains(cadenaFiltro.ToUpper()));
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            if (onOff)
            {
                onOff = false;
                btnFiltroAvanzado.BackColor = Color.Black;
                gbFiltroAvanzado.Visible = false;
            }
            else
            {
                onOff = true;
                btnFiltroAvanzado.BackColor = Color.DimGray;
                gbFiltroAvanzado.Visible = true;
                cboCriterio.SelectedIndex = -1;
                cboPrecio.SelectedIndex = -1;
                txtNombre.Text = "";
                txtMinimo.Text = "";
                txtMaximo.Text = "";

            }

        }

        private void cboPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = true;


            if (cboPrecio.SelectedIndex >= 0)
            {
                if (cboPrecio.SelectedItem.ToString() == "Entre")
                {
                    txtMaximo.Visible = true;
                    lblMinimo.Text = "Mínimo:";
                    lblMaximo.Visible = true;
                }
                else
                {
                    txtMaximo.Visible = false;
                    lblMinimo.Text = "Valor:";
                    lblMaximo.Visible = false;
                }
            }
            
            if ((cboPrecio.SelectedIndex >= 0 && txtMinimo.Text != "")|| (cboCriterio.SelectedIndex >= 0 && txtNombre.Text != ""))
            {
                btnBuscar.Enabled = true;   
            }
            else
            {
                btnBuscar.Enabled = false;

            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterioNombre;
            string nombre;
            string criterioPrecio;
            decimal precioMinimo;
            decimal precioMaximo;



            if (cboCriterio.SelectedIndex >= 0)
            {
                criterioNombre = cboCriterio.SelectedItem.ToString();
                nombre = txtNombre.Text;
            }


            if (cboPrecio.SelectedIndex >= 0)    //Validacion de Solo Numeros
            {
                criterioPrecio = cboPrecio.SelectedItem.ToString();

                if (esNumero(txtMinimo.Text))
                {
                    precioMinimo = decimal.Parse(txtMinimo.Text);
                
                    if (txtMaximo.Text != "")
                    {
                        if (esNumero(txtMaximo.Text))
                        {
                            precioMaximo = decimal.Parse(txtMaximo.Text);
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un Número Máximo");
                            txtMaximo.SelectionStart = 0;
                            txtMaximo.SelectionLength = txtMaximo.Text.Length;
                            txtMaximo.Focus();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un Número Mínimo");
                    txtMinimo.SelectionStart = 0;
                    txtMinimo.SelectionLength = txtMinimo.Text.Length;
                    txtMinimo.Focus();
                }
            }
            
            ArticuloDatos datos = new ArticuloDatos();
            dgvArticulos.DataSource = datos.filtroAvanzado(criterioNombre, nombre, criterioPrecio,precioMinimo, precioMaximo);



            try
            {
                

            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Conexión con la Base de Datos");
            }




        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = true;

            if ((cboPrecio.SelectedIndex >= 0 && txtMinimo.Text != "")|| (cboCriterio.SelectedIndex >= 0 && txtNombre.Text !=""))
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = true;

            if (txtNombre.Text.Length > 0 && cboCriterio.SelectedIndex >= 0)
            {
                btnBuscar.Enabled=true; 
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void txtMinimo_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = true;

            if ((cboPrecio.SelectedIndex >= 0 && txtMinimo.Text != "") || (cboCriterio.SelectedIndex >= 0 && txtNombre.Text != ""))
            {
                btnBuscar.Enabled = true;
                
            }
            else
            {
                btnBuscar.Enabled = false;

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            txtMinimo.Text = "";
            txtMaximo.Text = "";
            txtNombre.Text = "";
            cboPrecio.SelectedIndex = -1;
            cboCriterio.SelectedIndex = -1;
            btnLimpiar.Enabled = false;

        }


        static bool esNumero(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }

            }
            return true;
        }


        static bool esTexto(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsLetter(caracter)))
                {
                    return false;
                }

            }
            return true;
        }


    }

}
