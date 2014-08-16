using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio.Services
{
    public class UsuarioEstandar
    {
        public int Add(BO.UsuarioEstandar item)
        {
            DAO.UsuarioEstandar oUsuarioE = new DAO.UsuarioEstandar();
            try
            {
                return oUsuarioE.Add(item);

            }
            catch
            {
                throw;
            }
            finally
            {
                oUsuarioE = null;
            }
        }

        public void Delete(BO.UsuarioEstandar item)
        {
            DAO.UsuarioEstandar oUsuarioE = new DAO.UsuarioEstandar();
            try
            {
                oUsuarioE.Delete(item);
            }
            catch
            {
                throw;
            }
            finally
            {
                oUsuarioE = null;
            }
        }

        public void Update(BO.UsuarioEstandar item)
        {
            DAO.UsuarioEstandar oUsuarioE = new DAO.UsuarioEstandar();
            try
            {
                oUsuarioE.Update(item);
            }
            catch
            {
                throw;
            }
            finally
            {
                oUsuarioE = null;
            }
        }

        public DataTable GetAll()
        {
            DAO.UsuarioEstandar oUsuarioEstandar = new DAO.UsuarioEstandar();
            try
            {
                return oUsuarioEstandar.GetAll();
            }
            catch
            {
                throw;
            }
        }

        public BO.UsuarioEstandar GetOne(int id)
        {
            DAO.UsuarioEstandar oUsuarioE = new DAO.UsuarioEstandar();
            try
            {
                return oUsuarioE.GetOne(id);
            }
            catch
            {
                throw;
            }
        }

        public BO.UsuarioEstandar login(BO.UsuarioEstandar item)
        {
            DAO.UsuarioEstandar usuario = new DAO.UsuarioEstandar();
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
