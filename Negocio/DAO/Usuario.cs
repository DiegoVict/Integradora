using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    class Usuario
    {
        #region Constructores...
        public Usuario()
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

        public static string usuarioGetAll = "usuarioGetAll"; // trae todos los usuarios registrados sin filtro
        public static string usuarioGet = "usuarioGet"; // trae todos los usuario registrados por filtro like
        public static string usuarioGetOne = "usuarioGetOne"; // trae un usuario especifico por id
        public static string usuarioADD = "usuarioADD"; // inserta un usuario
        public static string usuarioDelete = "usuarioDelete"; // elimina un usuario
        public static string usuarioUpdate = "usuarioUpdate"; // modifica informacion de un usuario
        public static string usuarioValida = "usuarioValida"; // valida que el usuario exista (login)

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador
        public int Add(BO.Usuario item)
        {
            int idUsuario = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(usuarioADD, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@usuario", SqlDbType.VarChar);
                cmd.Parameters["@usuario"].Value = item.usuario;
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar);
                cmd.Parameters["@contrasenia"].Value = item.contrasenia;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar);
                cmd.Parameters["@correo"].Value = item.correo;
                cmd.Parameters.Add("@twitter", SqlDbType.VarChar);
                cmd.Parameters["@twitter"].Value = item.twitter;
                cmd.Parameters.Add("@facebbok", SqlDbType.VarChar);
                cmd.Parameters["@facebook"].Value = item.facebook;
                cmd.Parameters.Add("@youtube", SqlDbType.VarChar);
                cmd.Parameters["@youtube"].Value = item.youtube;
                return idUsuario = Convert.ToInt32(cmd.ExecuteScalar());
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

        public int Update(BO.Usuario item)
        {
            //int idUsuario = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(usuarioADD, conn);
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
                cmd.Parameters.Add("@facebbok", SqlDbType.VarChar);
                cmd.Parameters["@facebook"].Value = item.facebook;
                cmd.Parameters.Add("@youtube", SqlDbType.VarChar);
                cmd.Parameters["@youtube"].Value = item.youtube;
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

        public int Delete(BO.Usuario item)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(usuarioDelete, conn);
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
