using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio.Services
{
    public class UsuarioArtistaSeguir
    {
        public void Add(BO.UsuarioArtistaSeguir item)
        {
            DAO.UsuarioArtistaSeguir usuario = new DAO.UsuarioArtistaSeguir();
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

        public void Delete(BO.UsuarioArtistaSeguir item)
        {
            DAO.UsuarioArtistaSeguir usuario = new DAO.UsuarioArtistaSeguir();
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

        public List<BO.UsuarioArtistaSeguir> GetObjetc(int condicion, string valor)
        {
            DAO.UsuarioArtistaSeguir usuario = new DAO.UsuarioArtistaSeguir();
            try
            {
                return usuario.GetObjetc(condicion, valor);
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
    }
}
