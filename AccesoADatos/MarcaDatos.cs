using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoADatos
{
    public class MarcaDatos
    {

        public List<Marca> listarMarca()
        {
            List<Marca> lista = new List<Marca>();
            ConectarDatos datos = new ConectarDatos();

            try
            {
                datos.setearConsulta("select id, descripcion from marcas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["id"];
                    aux.DescripcionMarca = (string)datos.Lector["Descripcion"];

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

        public void agregarMarca(string marca)
        {
            ConectarDatos datos = new ConectarDatos();

            try
            {
                datos.setearConsulta("Insert into Marcas  (Descripcion) values (@Descripcion)");
                datos.setearParametro("@Descripcion", marca);
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


        public void eliminarMarca(string marca)
        {
            ConectarDatos datos = new ConectarDatos();
            
            try
            {
            datos.setearConsulta("delete from Marca WHERE descripcion = @desc");
            datos.setearParametro("@desc", marca);
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
