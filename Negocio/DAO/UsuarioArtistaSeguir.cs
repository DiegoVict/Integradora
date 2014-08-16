using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    public class UsuarioArtistaSeguir
    {
        #region Instancia de Clases...

        Datos.Conexion.Conexion con = new Datos.Conexion.Conexion();

        #endregion

        #region Declaracion variables...

        SqlDataReader reader;
        SqlCommand cmd;
        SqlConnection conn;

        #endregion

        #region Constructores...

        public UsuarioArtistaSeguir()
        {
            conn = con.getConexion();
        }

        #endregion

        #region Procedimientos Almacenados...

        public static string usuarioEstandarGetAll = ""; // trae todos los usuarios registrados sin filtro
        public static string usuarioArtistaSeguirGet = "usuarioArtistaSeguirGet"; // trae todos los usuario registrados por filtro like
        public static string usuarioEstandarGetOne = ""; // trae un usuario especifico por id
        public static string usuaarioArtistaSeguirAdd = "usuaarioArtistaSeguirAdd"; // inserta un usuario
        public static string usuarioArtistaSeguirDelete = "usuarioArtistaSeguirDelete"; // elimina un usuario
        public static string usuarioEstandarUpdate = ""; // modifica informacion de un usuario
        public static string usuarioEstandarValida = ""; // valida que el usuario exista (login)

        #endregion

        public int Add(BO.UsuarioArtistaSeguir item)
        {
            // falta meterle transaccion
            //int idUsuario = 0;
            int i = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(usuaarioArtistaSeguirAdd, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_usuario_estandar", SqlDbType.Int);
                cmd.Parameters["@id_usuario_estandar"].Value = item.id_usuario_estandar.id;
                cmd.Parameters.Add("@id_usuario_artista", SqlDbType.Int);
                cmd.Parameters["@id_usuario_artista"].Value = item.id_usuario_artista.id;
                return i = Convert.ToInt32(cmd.ExecuteNonQuery());
                //conn.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public int Delete(BO.UsuarioArtistaSeguir item)
        {
            // falta meterle transaccion
            //int idUsuario = 0;
            int i = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaSeguirDelete, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = item.id;
                return i = Convert.ToInt32(cmd.ExecuteNonQuery());
                //conn.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<BO.UsuarioArtistaSeguir> GetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.UsuarioArtistaSeguir> lobjeto = new List<BO.UsuarioArtistaSeguir>();
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaSeguirGet, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@condicion", SqlDbType.Int);
                cmd.Parameters["@condicion"].Value = condicion;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar);
                cmd.Parameters["@valor"].Value = valor;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.UsuarioArtistaSeguir objeto = new BO.UsuarioArtistaSeguir();

                    objeto.id_usuario_estandar.id = dr.GetInt32(dr.GetOrdinal("idUsuarioEstandar"));
                    objeto.id_usuario_estandar.usuario = dr.GetString(dr.GetOrdinal("usuarioEstandar"));
                    objeto.id_usuario_estandar.facebook = dr.GetString(dr.GetOrdinal("facebookUsuarioEstandar"));
                    objeto.id_usuario_estandar.imagen = dr.GetString(dr.GetOrdinal("imagenUsuarioEstandar"));

                    lobjeto.Add(objeto);
                    objeto = null;
                }
                return lobjeto;
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
