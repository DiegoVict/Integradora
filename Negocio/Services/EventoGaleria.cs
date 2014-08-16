using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Services
{
    public class EventoGaleria
    {

        #region Instancia de Clases...

        Negocio.DAO.EventoGaleria objeto = new DAO.EventoGaleria();

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador

        public int Add(BO.EventoGaleria item)
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

        public int Update(BO.EventoGaleria item)
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

        public int Delete(BO.EventoGaleria item)
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

        public BO.EventoGaleria GetOne(int id)
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

        public List<BO.EventoGaleria> GetAllObjetc()
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

        public List<BO.EventoGaleria> GetObjetc(int condicion, string valor)
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
