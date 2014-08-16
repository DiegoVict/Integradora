using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.Services
{
    class Usuario
    {
        public int Add(BO.Usuario item)
        {
            DAO.Usuario oUsuarioDAO = new DAO.Usuario();
            try
            {
                return oUsuarioDAO.Add(item);
            }
            catch
            {
                throw;
            }
            finally
            {
                oUsuarioDAO = null;
            }
        }
    }
}
