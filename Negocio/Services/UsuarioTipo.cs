using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio.Services
{
    public class UsuarioTipo
    {
        public DataTable GetAll()
        {
            DAO.UsuarioTipo oUsuTipo = new DAO.UsuarioTipo();
            try
            {
                return oUsuTipo.GetAll();
            }
            catch
            {
                throw;
            }
        }
    }
}
