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


        public frmNuevoItem()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNuevoItem_Load(object sender, EventArgs e)
        {

            CategoriaDatos item = new CategoriaDatos();
            
            try
            {
                listaCategoria = item.listar();
                dgvLista.DataSource = listaCategoria;   
                

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
