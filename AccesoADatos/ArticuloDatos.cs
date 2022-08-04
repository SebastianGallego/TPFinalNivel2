using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades; 

namespace AccesoADatos
{
    public class ArticuloDatos
    {

        public List<Articulo> listarArticulo()
        {
            List<Articulo> lista = new List<Articulo>();
            ConectarDatos datos = new ConectarDatos();

            try
            {
                datos.setearConsulta("Select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria,  Precio,ImagenUrl, C.Id IdCategoria, M.Id IdMarca From Articulos A, Categorias C, Marcas M where M.Id = A.IdMarca And C.Id = A.IdCategoria");


                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.DescripcionMarca = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.DescripcionCategoria = (string)datos.Lector["Categoria"];


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


        public void agregarArticulo(Articulo Articulo)
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


        public void modificarArticulo(Articulo Articulo)
        {
            ConectarDatos datos = new ConectarDatos();

            try
            {
                datos.setearConsulta("update Articulos set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, ImagenUrl = @ImagenUrl, IdCategoria = @IdCategoria, IdMarca = @idMarca , Precio = @Precio Where Id = @Id");
                datos.setearParametro("@Codigo", Articulo.Codigo);
                datos.setearParametro("@Nombre", Articulo.Nombre);
                datos.setearParametro("@Descripcion", Articulo.Descripcion);
                datos.setearParametro("@ImagenUrl", Articulo.ImagenUrl);
                datos.setearParametro("@IdCategoria", Articulo.Categoria.Id);
                datos.setearParametro("@IdMarca", Articulo.Marca.Id);
                datos.setearParametro("@Id", Articulo.Id);
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


        public void eliminarArticulo(int id)
        {
            ConectarDatos datos = new ConectarDatos();

            try
            {
                datos.setearConsulta("delete from Articulos where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }





    }


}

