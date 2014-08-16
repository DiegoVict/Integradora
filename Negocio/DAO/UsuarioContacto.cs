using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    public class UsuarioContacto
    {
        #region Constructores...
        public UsuarioContacto()
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

        public static string spGetAll = "usuarioContactoGetAll"; // trae todos  registrados sin filtro
        public static string spGet = "usuarioContactoGet"; // trae todos los registros por filtro like
        public static string spGetOne = "usuarioContactoGetOne"; // trae un registro especifico por id
        public static string spADD = "usuarioContactoADD"; // inserta un registro
        public static string spDelete = "usuarioContactoDelete"; // elimina un usuario
        public static string spUpdate = "usuarioContactoUpdate"; // modifica informacion de un usuario

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador

        public int Add(BO.UsuarioContacto item)
        {
            //int idAlbum = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(spADD, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = item.nombre;
                cmd.Parameters.Add("@apellido_pat", SqlDbType.VarChar);
                cmd.Parameters["@apellido_pat"].Value = item.apellido_pat;
                cmd.Parameters.Add("@apellido_mat", SqlDbType.VarChar);
                cmd.Parameters["@apellido_mat"].Value = item.apellido_mat;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar);
                cmd.Parameters["@telefono"].Value = item.telefono;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar);
                cmd.Parameters["@correo"].Value = item.correo;
                cmd.Parameters.Add("@rfc", SqlDbType.VarChar);
                cmd.Parameters["@rfc"].Value = item.rfc;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd.Parameters["@descripcion"].Value = item.descripcion;
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
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

        public int Update(BO.UsuarioContacto item)
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
                cmd.Parameters.Add("@apellido_pat", SqlDbType.VarChar);
                cmd.Parameters["@apellido_pat"].Value = item.apellido_pat;
                cmd.Parameters.Add("@apellido_mat", SqlDbType.VarChar);
                cmd.Parameters["@apellido_mat"].Value = item.apellido_mat;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar);
                cmd.Parameters["@telefono"].Value = item.telefono;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar);
                cmd.Parameters["@correo"].Value = item.correo;
                cmd.Parameters.Add("@rfc", SqlDbType.VarChar);
                cmd.Parameters["@rfc"].Value = item.rfc;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd.Parameters["@descripcion"].Value = item.descripcion;
                cmd.Parameters.Add("@id_usuarioAO", SqlDbType.Int);
                cmd.Parameters["@id_usuarioAO"].Value = item.id_usuario.id;

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

        public int Delete(BO.UsuarioContacto item)
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

        public BO.UsuarioContacto GetOne(int id)
        {
            try
            {
                BO.UsuarioContacto objeto = new BO.UsuarioContacto();
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
                    objeto.apellido_pat = dr.GetString(dr.GetOrdinal("apellido_pat"));
                    objeto.apellido_mat = dr.GetString(dr.GetOrdinal("apellido_mat"));
                    objeto.telefono = dr.GetString(dr.GetOrdinal("telefono"));
                    objeto.correo = dr.GetString(dr.GetOrdinal("correo"));
                    objeto.rfc = dr.GetString(dr.GetOrdinal("rfc"));
                    objeto.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
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

        public List<BO.UsuarioContacto> GetAllObjetc()
        {
            try
            {
                List<BO.UsuarioContacto> lobjeto = new List<BO.UsuarioContacto>();
                conn.Open();
                cmd = new SqlCommand(spGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.UsuarioContacto objeto = new BO.UsuarioContacto();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    objeto.apellido_pat = dr.GetString(dr.GetOrdinal("apellido_pat"));
                    objeto.apellido_mat = dr.GetString(dr.GetOrdinal("apellido_mat"));
                    objeto.telefono = dr.GetString(dr.GetOrdinal("telefono"));
                    objeto.correo = dr.GetString(dr.GetOrdinal("correo"));
                    objeto.rfc = dr.GetString(dr.GetOrdinal("rfc"));
                    objeto.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
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

        public List<BO.UsuarioContacto> GetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.UsuarioContacto> lobjeto = new List<BO.UsuarioContacto>();
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
                    BO.UsuarioContacto objeto = new BO.UsuarioContacto();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.nombre = dr.GetString(dr.GetOrdinal("NombreCompleto"));
                   // objeto.apellido_pat = dr.GetString(dr.GetOrdinal("apellido_pat"));
                    //objeto.apellido_mat = dr.GetString(dr.GetOrdinal("apellido_mat"));
                    objeto.telefono = dr.GetString(dr.GetOrdinal("telefono"));
                    objeto.correo = dr.GetString(dr.GetOrdinal("correo"));
                    objeto.rfc = dr.GetString(dr.GetOrdinal("rfc"));
                    objeto.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
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
