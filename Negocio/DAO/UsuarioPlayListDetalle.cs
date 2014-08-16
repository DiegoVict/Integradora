using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    public class UsuarioPlayListDetalle
    {
        #region Constructores...
        public UsuarioPlayListDetalle()
        {
            conn = con.getConexion();
        }
        #endregion

        #region Declaracion variables...

        SqlDataReader reader;
        SqlCommand cmd;
        SqlConnection conn;

        #endregion

        #region Instancia de Clases...

        Datos.Conexion.Conexion con = new Datos.Conexion.Conexion();

        #endregion

        #region Procedimientos Almacenados...

        public static string spGetAll = "usuarioPlayListDetalleGetAll"; // trae todos  registrados sin filtro
        public static string spGet = "usuarioPlayListDetalleGet"; // trae todos los registros por filtro like
        public static string spGetOne = "usuarioPlayListDetalleGetOne"; // trae un registro especifico por id
        public static string spADD = "usuarioPlayListDetalleADD"; // inserta un registro
        public static string spDelete = "usuarioPlayListDetalleDelete"; // elimina un usuario
        public static string spUpdate = "usuarioPlayListDetalleUpdate"; // modifica informacion de un usuario

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador

        public int Add(BO.UsuarioPlayListDetalle item)
        {
            //int idAlbum = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(spADD, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_cancion", SqlDbType.Int);
                cmd.Parameters["@id_cancion"].Value = item.id_cancion.id;
                cmd.Parameters.Add("@id_playList", SqlDbType.Int);
                cmd.Parameters["@id_PlayList"].Value = item.id_playList.id;

                return Convert.ToInt32(cmd.ExecuteNonQuery());
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

        public int Update(BO.UsuarioPlayListDetalle item)
        {
            //int idUsuario = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(spUpdate, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = item.id;
                cmd.Parameters.Add("@id_cancion", SqlDbType.Int);
                cmd.Parameters["@id_cancion"].Value = item.id_cancion.id;
                cmd.Parameters.Add("@id_playList", SqlDbType.Int);
                cmd.Parameters["@id_PlayList"].Value = item.id_playList.id;

                return Convert.ToInt32(cmd.ExecuteNonQuery());
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

        public int Delete(BO.UsuarioPlayListDetalle item)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(spDelete, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = item.id;
                return Convert.ToInt32(cmd.ExecuteNonQuery());
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

        public DataTable GetAll()
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1.Clear();
                conn.Open();
                cmd = new SqlCommand(spGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                dt1.Load(reader);
                return dt1;
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

        public DataTable Get(int condicion, string valor)
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1.Clear();
                conn.Open();
                cmd = new SqlCommand(spGet, conn);
                cmd.Parameters.Add("@condicion", SqlDbType.Int);
                cmd.Parameters["@condicion"].Value = condicion;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar);
                cmd.Parameters["@valor"].Value = valor;
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                dt1.Load(reader);
                return dt1;
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

        public BO.UsuarioPlayListDetalle GetOne(int id)
        {
            try
            {
                BO.UsuarioPlayListDetalle objeto = new BO.UsuarioPlayListDetalle();
                conn.Open();
                cmd = new SqlCommand(spGetOne, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.id_cancion.id = dr.GetInt32(dr.GetOrdinal("id_cancion"));
                    objeto.id_cancion.nombre = dr.GetString(dr.GetOrdinal("nombre_cancion"));
                    objeto.id_playList.id = dr.GetInt32(dr.GetOrdinal("id_playList"));
                    objeto.id_playList.nombre = dr.GetString(dr.GetOrdinal("nombre_playList"));

                }
                return objeto;
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

        public List<BO.UsuarioPlayListDetalle> GetAllObjetc()
        {
            try
            {
                List<BO.UsuarioPlayListDetalle> lobjeto = new List<BO.UsuarioPlayListDetalle>();
                conn.Open();
                cmd = new SqlCommand(spGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.UsuarioPlayListDetalle objeto = new BO.UsuarioPlayListDetalle();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.id_cancion.id = dr.GetInt32(dr.GetOrdinal("id_cancion"));
                    objeto.id_cancion.nombre = dr.GetString(dr.GetOrdinal("nombre_cancion"));
                    objeto.id_playList.id = dr.GetInt32(dr.GetOrdinal("id_playList"));
                    objeto.id_playList.nombre = dr.GetString(dr.GetOrdinal("nombre_playList"));
                    
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

        public List<BO.UsuarioPlayListDetalle> GetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.UsuarioPlayListDetalle> lobjeto = new List<BO.UsuarioPlayListDetalle>();
                conn.Open();
                cmd = new SqlCommand(spGet, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@condicion", SqlDbType.Int);
                cmd.Parameters["@condicion"].Value = condicion;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar);
                cmd.Parameters["@valor"].Value = valor;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.UsuarioPlayListDetalle objeto = new BO.UsuarioPlayListDetalle();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.id_cancion.id = dr.GetInt32(dr.GetOrdinal("id_cancion"));
                    objeto.id_cancion.nombre = dr.GetString(dr.GetOrdinal("nombre_cancion"));
                    objeto.id_playList.id = dr.GetInt32(dr.GetOrdinal("id_playList"));
                    objeto.id_playList.nombre = dr.GetString(dr.GetOrdinal("nombre_playList"));

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

        #endregion
    }
}
