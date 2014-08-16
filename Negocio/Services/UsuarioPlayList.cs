using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Services
{
    public class UsuarioPlayList
    {

        #region Instancia de Clases...

        Negocio.DAO.UsuarioPlayList objeto = new Negocio.DAO.UsuarioPlayList();

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador

        public int Add(BO.UsuarioplayList item)
        {
            //int idAlbum = 0;
            try
            {
                return objeto.Add(item);
            }
            catch
            {
                throw;
            }
            finally
            {
                objeto = null;
            }
        }

        public int Update(BO.UsuarioplayList item)
        {
            //int idUsuario = 0;
            try
            {
                return objeto.Update(item);
            }
            catch
            {
                throw;
            }
            finally
            {
                objeto = null;
            }
        }

        public int Delete(BO.UsuarioplayList item)
        {
            try
            {
                return objeto.Delete(item);
            }
            catch
            {
                throw;
            }
            finally
            {
                objeto = null;
            }
        }

        public DataTable GetAll()
        {
            try
            {
                return objeto.GetAll();
            }
            catch
            {
                throw;
            }
            finally
            {
                objeto = null;
            }
        }

        public DataTable Get(int condicion, string valor)
        {
            try
            {
                return objeto.Get(condicion, valor);
            }
            catch
            {
                throw;
            }
            finally
            {
                objeto = null;
            }
        }

        public BO.UsuarioplayList GetOne(int id)
        {
            try
            {
                return objeto.GetOne(id);
            }
            catch
            {
                throw;
            }
            finally
            {
                objeto = null;
            }
        }

        public List<BO.UsuarioplayList> GetAllObjetc()
        {
            try
            {
                return objeto.GetAllObjetc();
            }
            catch
            {
                throw;
            }
            finally
            {
                objeto = null;
            }
        }

        public List<BO.UsuarioplayList> GetObjetc(int condicion, string valor)
        {
            try
            {
                return objeto.GetObjetc(condicion, valor);
            }
            catch
            {
                throw;
            }
            finally
            {
                objeto = null;
            }
        }

        #endregion
    }
}
