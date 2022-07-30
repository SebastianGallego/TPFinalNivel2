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
        public List<Categoria> listar()
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








    }
}
