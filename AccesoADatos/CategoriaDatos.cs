using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public  class CategoriaDatos
    {
        public List<Categoria> listarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            ConectarDatos datos = new ConectarDatos();

            try
            {
                datos.setearConsulta("select id, descripcion from categorias");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["id"];
                    aux.DescripcionCategoria = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregarCategoria(Categoria categoria)   //Hacer Agregar Categoria y Agregar marca (sacarlo del formulario)
        {
            ConectarDatos datos = new ConectarDatos();

            try
            {
                datos.setearConsulta("Insert into Articulos (Codigo, Nombre, Descripcion, idCategoria, idMarca, ImagenUrl,Precio) values (@Codigo, @Nombre, @Descripcion, @idCategoria, @idMarca, @ImagenUrl,@Precio)  ");


                datos.setearParametro("@Codigo", Articulo.Codigo);
                datos.setearParametro("@Nombre", Articulo.Nombre);
                datos.setearParametro("@Descripcion", Articulo.Descripcion);
                datos.setearParametro("@idCategoria", Articulo.Categoria.Id);
                datos.setearParametro("@idMarca", Articulo.Marca.Id);
                datos.setearParametro("@ImagenUrl", Articulo.ImagenUrl);
                datos.setearParametro("@Precio", Articulo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
    }
}
