using Entidades;
using System;
using System.Collections.Generic;


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

        public void agregarCategoria(string categoria)   
        {
            ConectarDatos datos = new ConectarDatos();
            try
            {
                datos.setearConsulta("Insert into Categorias  (Descripcion) values (@Descripcion)");
                datos.setearParametro("@Descripcion", categoria);
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


        public void eliminarCategoria(string categoria) 
        {

            ConectarDatos datos = new ConectarDatos();
            datos.setearConsulta("delete from categorias WHERE descripcion = @desc");
            datos.setearParametro("@desc", categoria);
            datos.ejecutarAccion();

        }




    }
}
