using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio.Services
{
    public class UsuarioArtistaOrganizador
    {

        public void Add(BO.UsuarioArtistaOrganizador item)
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                usuario.Add(item);
            }
            catch
            {
                throw;
            }
            finally
            {
                usuario = null;
            }
        }

        public void Delete(BO.UsuarioArtistaOrganizador item)
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                usuario.Delete(item);
            }
            catch
            {
                throw;
            }
            finally
            {
                usuario = null;
            }
        }

        public void Update(BO.UsuarioArtistaOrganizador item)
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                usuario.Update(item);
            }
            catch
            {
                throw;
            }
            finally
            {
                usuario = null;
            }
        }

        public DataTable GetAll()
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.GetAll();
            }
            catch
            {
                throw;
            }
        }

        public DataTable artistaGetAll()
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.artistaGetAll();
            }
            catch
            {
                throw;
            }
        }

        public DataTable organizadorGetAll()
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.organizadorGetAll();
            }
            catch
            {
                throw;
            }
        }

        public DataTable Get(int condicion, string valor)
        {
            DAO.UsuarioArtistaOrganizador ousuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return ousuario.Get(condicion, valor);
            }
            catch
            {
                throw;
            }
        }

        public DataTable artistaGet(int condicion, string valor)
        {
            DAO.UsuarioArtistaOrganizador ousuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return ousuario.artistaGet(condicion, valor);
            }
            catch
            {
                throw;
            }
        }

        public DataTable organizadorGet(int condicion, string valor)
        {
            DAO.UsuarioArtistaOrganizador ousuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return ousuario.organizadorGet(condicion, valor);
            }
            catch
            {
                throw;
            }
        }

        public BO.UsuarioArtistaOrganizador GetOne(int id)
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.GetOne(id);
            }
            catch
            {
                throw;
            }
        }

        public BO.UsuarioArtistaOrganizador artistaGetOne(int id)
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.artistaGetOne(id);
            }
            catch
            {
                throw;
            }
        }

        public BO.UsuarioArtistaOrganizador organizadorGetOne(int id)
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.organizadorGetOne(id);
            }
            catch
            {
                throw;
            }
        }

        public List<BO.UsuarioArtistaOrganizador> GetAllObject()
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.GetAllObject();
            }
            catch
            {
                throw;
            }
        }

        public List<BO.UsuarioArtistaOrganizador> artistaGetAllObject()
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.artistaGetAllObject();
            }
            catch
            {
                throw;
            }
        }

        public List<BO.UsuarioArtistaOrganizador> organizadorGetAllObject()
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.organizadorGetAllObject();
            }
            catch
            {
                throw;
            }
        }

        public List<BO.UsuarioArtistaOrganizador> GetObject(int condicion,string valor)
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.GetObjetc(condicion, valor);
            }
            catch
            {
                throw;
            }
        }

        public List<BO.UsuarioArtistaOrganizador> artistaGetObject(int condicion, string valor)
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.artistaGetObjetc(condicion, valor);
            }
            catch
            {
                throw;
            }
        }

        public List<BO.UsuarioArtistaOrganizador> organizadorGetObject(int condicion, string valor)
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.organizadorGetObjetc(condicion, valor);
            }
            catch
            {
                throw;
            }
        }

        public BO.UsuarioArtistaOrganizador login(BO.UsuarioArtistaOrganizador item)
        {
            DAO.UsuarioArtistaOrganizador usuario = new DAO.UsuarioArtistaOrganizador();
            try
            {
                return usuario.login(item);
            }
            catch
            {
                throw;
            }
        }
    }
}
