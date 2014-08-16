using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    public class UsuarioEstandar
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

        public UsuarioEstandar()
        {
            conn = con.getConexion();
        }

        #endregion

        #region Procedimientos Almacenados...

        public static string usuarioEstandarGetAll = "usuarioEstandarGetAll"; // trae todos los usuarios registrados sin filtro
        public static string usuarioEstandarGet = "usuarioEstandarGet"; // trae todos los usuario registrados por filtro like
        public static string usuarioEstandarGetOne = "usuarioEstandarGetOne"; // trae un usuario especifico por id
        public static string usuarioEstandarADD = "usuarioEstandarADD"; // inserta un usuario
        public static string usuarioEstandarDelete = "usuarioEstandarDelete"; // elimina un usuario
        public static string usuarioEstandarUpdate = "usuarioEstandarUpdate"; // modifica informacion de un usuario
        public static string usuarioEstandarValida = "usuarioEstandarValida"; // valida que el usuario exista (login)

        #endregion

        #region metodos

        public DataTable GetAll()
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1.Clear();
                conn.Open();
                cmd = new SqlCommand(usuarioEstandarGetAll, conn);
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

        public BO.UsuarioEstandar login(BO.UsuarioEstandar item)
        {
            try
            {
                BO.UsuarioEstandar oUsuario = new BO.UsuarioEstandar();
                conn.Open();
                cmd = new SqlCommand(usuarioEstandarValida, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar);
                cmd.Parameters["@usuario"].Value = item.usuario;
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar);
                cmd.Parameters["@contrasenia"].Value = item.contrasenia;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oUsuario.id = dr.GetInt32(dr.GetOrdinal("id"));
                    oUsuario.usuario = dr.GetString(dr.GetOrdinal("usuario"));
                    oUsuario.contrasenia = dr.GetString(dr.GetOrdinal("contrasenia"));
                    oUsuario.correo = dr.GetString(dr.GetOrdinal("correo"));
                    oUsuario.twitter = dr.GetString(dr.GetOrdinal("twitter"));
                    oUsuario.facebook = dr.GetString(dr.GetOrdinal("facebook"));
                    oUsuario.youtube = dr.GetString(dr.GetOrdinal("youtube"));
                    oUsuario.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    oUsuario.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
                    oUsuario.id_tipo.id = dr.GetInt32(dr.GetOrdinal("id_tipo"));
                    oUsuario.id_tipo.nombre = dr.GetString(dr.GetOrdinal("tipo"));
                    DateTime nac = dr.GetDateTime(dr.GetOrdinal("nacimeito"));
                    oUsuario.nacimiento = Convert.ToString(nac.ToString());
                    oUsuario.sexo = dr.GetString(dr.GetOrdinal("sexo"));
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                }
                return oUsuario;
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
                cmd = new SqlCommand(usuarioEstandarGet, conn);
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

        public BO.UsuarioEstandar GetOne(int id)
        {
            try{
            Negocio.BO.UsuarioEstandar oUsuario = new Negocio.BO.UsuarioEstandar();
            conn.Open();
            cmd = new SqlCommand(usuarioEstandarGetOne, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = id;
            SqlDataReader dr = cmd.ExecuteReader();

             while (dr.Read())
                {
                    oUsuario.id = dr.GetInt32(dr.GetOrdinal("id"));
                    oUsuario.usuario = dr.GetString(dr.GetOrdinal("usuario"));
                    oUsuario.contrasenia = dr.GetString(dr.GetOrdinal("contrasenia"));
                    oUsuario.correo = dr.GetString(dr.GetOrdinal("correo"));
                    oUsuario.twitter = dr.GetString(dr.GetOrdinal("twitter"));
                    oUsuario.facebook = dr.GetString(dr.GetOrdinal("facebook"));
                    oUsuario.youtube = dr.GetString(dr.GetOrdinal("youtube"));
                    oUsuario.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    oUsuario.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
                    oUsuario.id_tipo.id = dr.GetInt32(dr.GetOrdinal("id_tipo"));
                    oUsuario.id_tipo.nombre = dr.GetString(dr.GetOrdinal("tipo"));
                    DateTime nac = dr.GetDateTime(dr.GetOrdinal("nacimeito"));
                    oUsuario.nacimiento = Convert.ToString(nac.ToString());
                    oUsuario.sexo = dr.GetString(dr.GetOrdinal("sexo"));
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                }
                return oUsuario;
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

        public int Add(BO.UsuarioEstandar item)
        {
            // falta meterle transaccion
            //int idUsuario = 0;
            int i = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(usuarioEstandarADD, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@usuario", SqlDbType.VarChar);
                cmd.Parameters["@usuario"].Value = item.usuario;
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar);
                cmd.Parameters["@contrasenia"].Value = item.contrasenia;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar);
                cmd.Parameters["@correo"].Value = item.correo;
                cmd.Parameters.Add("@twitter", SqlDbType.VarChar);
                cmd.Parameters["@twitter"].Value = item.twitter;
                cmd.Parameters.Add("@facebook", SqlDbType.VarChar);
                cmd.Parameters["@facebook"].Value = item.facebook;
                cmd.Parameters.Add("@youtube", SqlDbType.VarChar);
                cmd.Parameters["@youtube"].Value = item.youtube;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = item.nombre;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd.Parameters["@descripcion"].Value = item.descripcion;
                cmd.Parameters.Add("@nacimiento", SqlDbType.DateTime);
                cmd.Parameters["@nacimiento"].Value = item.nacimiento;
                cmd.Parameters.Add("@sexo", SqlDbType.VarChar);
                cmd.Parameters["@sexo"].Value = item.sexo;
                cmd.Parameters.Add("@id_tipo", SqlDbType.Int);
                cmd.Parameters["@id_tipo"].Value = item.id_tipo.id;
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                cmd.Parameters["@imagen"].Value = item.imagen;
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

        public int Update(BO.UsuarioEstandar item)
        {
            //int idUsuario = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(usuarioEstandarUpdate, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = item.id;
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar);
                cmd.Parameters["@usuario"].Value = item.usuario;
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar);
                cmd.Parameters["@contrasenia"].Value = item.contrasenia;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar);
                cmd.Parameters["@correo"].Value = item.correo;
                cmd.Parameters.Add("@twitter", SqlDbType.VarChar);
                cmd.Parameters["@twitter"].Value = item.twitter;
                cmd.Parameters.Add("@facebook", SqlDbType.VarChar);
                cmd.Parameters["@facebook"].Value = item.facebook;
                cmd.Parameters.Add("@youtube", SqlDbType.VarChar);
                cmd.Parameters["@youtube"].Value = item.youtube;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = item.nombre;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd.Parameters["@descripcion"].Value = item.descripcion;
                cmd.Parameters.Add("@nacimiento", SqlDbType.VarChar);
                cmd.Parameters["@nacimiento"].Value = item.nacimiento;
                cmd.Parameters.Add("@sexo", SqlDbType.VarChar);
                cmd.Parameters["@sexo"].Value = item.sexo;
                cmd.Parameters.Add("@id_tipo", SqlDbType.Int);
                cmd.Parameters["@id_tipo"].Value = item.id_tipo.id;
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                cmd.Parameters["@imagen"].Value = item.imagen;
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

        public int Delete(BO.UsuarioEstandar item)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(usuarioEstandarDelete, conn);
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

        #endregion
    }
}
