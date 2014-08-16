using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    public class UsuarioPlayList
    {
        #region Constructores...
        public UsuarioPlayList()
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

        public static string spGetAll = "usuarioPlayListGetAll"; // trae todos  registrados sin filtro
        public static string spGet = "usuarioPlayListGet"; // trae todos los registros por filtro like
        public static string spGetOne = "usuarioPlayListGetOne"; // trae un registro especifico por id
        public static string spADD = "usuarioPlayListADD"; // inserta un registro
        public static string spDelete = "usuarioPlayListDelete"; // elimina un usuario
        public static string spUpdate = "usuarioPlayListUpdate"; // modifica informacion de un usuario

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador

        public int Add(BO.UsuarioplayList item)
        {
            //int idAlbum = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(spADD, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = item.nombre;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd.Parameters["@descripcion"].Value = item.descripcion;
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                cmd.Parameters["@imagen"].Value = item.imagen;
                cmd.Parameters.Add("@id_usuario", SqlDbType.VarChar);
                cmd.Parameters["@id_usuario"].Value = item.id_usuario.id;

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

        public int Update(BO.UsuarioplayList item)
        {
            //int idUsuario = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(spUpdate, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = item.id;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = item.nombre;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd.Parameters["@descripcion"].Value = item.descripcion;
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                cmd.Parameters["@imagen"].Value = item.imagen;
                cmd.Parameters.Add("@id_usuario", SqlDbType.VarChar);
                cmd.Parameters["@id_usuario"].Value = item.id_usuario.id;

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

        public int Delete(BO.UsuarioplayList item)
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

        public BO.UsuarioplayList GetOne(int id)
        {
            try
            {
                BO.UsuarioplayList objeto = new BO.UsuarioplayList();
                conn.Open();
                cmd = new SqlCommand(spGetOne, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    objeto.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
                    objeto.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    objeto.id_usuario.id = dr.GetInt32(dr.GetOrdinal("id_usuario"));
                    objeto.id_usuario.nombre = dr.GetString(dr.GetOrdinal("nombre_usuario"));
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

        public List<BO.UsuarioplayList> GetAllObjetc()
        {
            try
            {
                List<BO.UsuarioplayList> lobjeto = new List<BO.UsuarioplayList>();
                conn.Open();
                cmd = new SqlCommand(spGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.UsuarioplayList objeto = new BO.UsuarioplayList();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    objeto.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
                    objeto.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    objeto.id_usuario.id = dr.GetInt32(dr.GetOrdinal("id_usuario"));
                    objeto.id_usuario.nombre = dr.GetString(dr.GetOrdinal("nombre_usuario"));
                    
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

        public List<BO.UsuarioplayList> GetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.UsuarioplayList> lobjeto = new List<BO.UsuarioplayList>();
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
                    BO.UsuarioplayList objeto = new BO.UsuarioplayList();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    objeto.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
                    objeto.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    objeto.id_usuario.id = dr.GetInt32(dr.GetOrdinal("id_usuario"));
                    objeto.id_usuario.nombre = dr.GetString(dr.GetOrdinal("nombre_usuario"));

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
