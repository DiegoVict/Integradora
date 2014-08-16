using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    public class Album
    {


        #region Constructores...
        public Album()
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

        public static string albumGetAll = "albumGetAll"; // trae todos  registrados sin filtro
        public static string albumGet = "albumGet"; // trae todos los registros por filtro like
        public static string albumGetOne = "albumGetOne"; // trae un registro especifico por id
        public static string albumADD = "albumAdd"; // inserta un registro
        public static string albumDelete = "albumDelete"; // elimina un usuario
        public static string albumUpdate = "albumUpdate"; // modifica informacion de un usuario

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador
        public int Add(BO.Album item)
        {
            //int idAlbum = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(albumADD, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = item.nombre;
                cmd.Parameters.Add("@anio", SqlDbType.DateTime);
                cmd.Parameters["@anio"].Value = item.anio;
                cmd.Parameters.Add("@pistas", SqlDbType.Int);
                cmd.Parameters["@pistas"].Value = item.pistas;
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                cmd.Parameters["@imagen"].Value = item.imagen;
                cmd.Parameters.Add("@id_artista", SqlDbType.Int);
                cmd.Parameters["@id_artista"].Value = item.id_artista.id;
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

        public int Update(BO.Album item)
        {
            //int idUsuario = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(albumUpdate, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = item.id;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = item.nombre;
                cmd.Parameters.Add("@anio", SqlDbType.DateTime);
                cmd.Parameters["@anio"].Value = item.anio;
                cmd.Parameters.Add("@pistas", SqlDbType.Int);
                cmd.Parameters["@pistas"].Value = item.pistas;
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                cmd.Parameters["@imagen"].Value = item.imagen;
                cmd.Parameters.Add("@id_artista", SqlDbType.Int);
                cmd.Parameters["@id_artista"].Value = item.id_artista.id;
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

        public int Delete(BO.Album item)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(albumDelete, conn);
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
                cmd = new SqlCommand(albumGetAll, conn);
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
                cmd = new SqlCommand(albumGet, conn);
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

        public BO.Album GetOne(int id)
        {
            try
            {
                BO.Album oAlbum = new BO.Album();
                conn.Open();
                cmd = new SqlCommand(albumGetOne, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oAlbum.id = dr.GetInt32(dr.GetOrdinal("id"));
                    oAlbum.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    oAlbum.anio = dr.GetDateTime(dr.GetOrdinal("anio"));
                    oAlbum.pistas = dr.GetInt32(dr.GetOrdinal("pistas"));
                    oAlbum.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    oAlbum.id_artista.id = dr.GetInt32(dr.GetOrdinal("id_artista"));
                    oAlbum.id_artista.nombre = dr.GetString(dr.GetOrdinal("nombre_artista"));
                }
                return oAlbum;
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

        public List<BO.Album> GetAllObjetc()
        {
            try
            {
                List<BO.Album> loAlbum = new List<BO.Album>();
                conn.Open();
                cmd = new SqlCommand(albumGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.Album oAlbum = new BO.Album();

                    oAlbum.id = dr.GetInt32(dr.GetOrdinal("id"));
                    oAlbum.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    oAlbum.anio = dr.GetDateTime(dr.GetOrdinal("anio"));
                    oAlbum.pistas = dr.GetInt32(dr.GetOrdinal("pistas"));
                    oAlbum.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                   // oAlbum.id_artista.id = dr.GetInt32(dr.GetOrdinal("id_artista"));
                   // oAlbum.id_artista.nombre = dr.GetString(dr.GetOrdinal("nombre_artista"));
                    loAlbum.Add(oAlbum);
                    oAlbum = null;
                }
                return loAlbum;
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

        public List<BO.Album> GetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.Album> loAlbum = new List<BO.Album>();
                conn.Open();
                cmd = new SqlCommand(albumGet, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@condicion", SqlDbType.Int);
                cmd.Parameters["@condicion"].Value = condicion;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar);
                cmd.Parameters["@valor"].Value = valor;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.Album oAlbum = new BO.Album();

                    oAlbum.id = dr.GetInt32(dr.GetOrdinal("id"));
                    oAlbum.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    oAlbum.anio = dr.GetDateTime(dr.GetOrdinal("anio"));
                    oAlbum.pistas = dr.GetInt32(dr.GetOrdinal("pistas"));
                    oAlbum.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    oAlbum.id_artista.id = dr.GetInt32(dr.GetOrdinal("id_artista"));
                    oAlbum.id_artista.nombre = dr.GetString(dr.GetOrdinal("nombre_artista"));
                    loAlbum.Add(oAlbum);
                    oAlbum = null;
                }
                return loAlbum;
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
