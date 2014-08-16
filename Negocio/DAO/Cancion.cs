using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Negocio.BO;
using Datos.Conexion;

namespace Negocio.DAO
{
    public class Cancion
    {
               
        #region Constructores...
        public Cancion()
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

        public static string cancionGetAll = "cancionGetAll"; // trae todos  registrados sin filtro
        public static string cancionGet = "cancionGet"; // trae todos los registros por filtro like
        public static string cancionGetOne = "cancionGetOne"; // trae un registro especifico por id
        public static string cancionADD = "cancionADD"; // inserta un registro
        public static string cancionDelete = "cancionDelete"; // elimina un usuario
        public static string cancionUpdate = "cancionUpdate"; // modifica informacion de un usuario

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador
        public int Add(BO.Cancion item)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(cancionADD, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = item.nombre;
                cmd.Parameters.Add("@duracion", SqlDbType.VarChar);
                cmd.Parameters["@duracion"].Value = item.duracion;
                cmd.Parameters.Add("@numero", SqlDbType.Int);
                cmd.Parameters["@numero"].Value = item.numero;
                cmd.Parameters.Add("@reproducciones", SqlDbType.Int);
                cmd.Parameters["@reproducciones"].Value = item.reproducciones;
                cmd.Parameters.Add("@id_album", SqlDbType.Int);
                cmd.Parameters["@id_album"].Value = item.id_album.id;
                cmd.Parameters.Add("@id_genero", SqlDbType.Int);
                cmd.Parameters["@id_genero"].Value = item.id_genero.id;
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

        public int Update(BO.Cancion item)
        {
            //int idUsuario = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(cancionUpdate, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = item.id;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = item.nombre;
                cmd.Parameters.Add("@duracion", SqlDbType.VarChar);
                cmd.Parameters["@duracion"].Value = item.duracion;
                cmd.Parameters.Add("@numero", SqlDbType.Int);
                cmd.Parameters["@numero"].Value = item.numero;
                cmd.Parameters.Add("@reproducciones", SqlDbType.Int);
                cmd.Parameters["@reproducciones"].Value = item.reproducciones;
                cmd.Parameters.Add("@id_album", SqlDbType.Int);
                cmd.Parameters["@id_album"].Value = item.id_album.id;
                cmd.Parameters.Add("@id_genero", SqlDbType.Int);
                cmd.Parameters["@id_genero"].Value = item.id_genero.id;

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

        public int Delete(BO.Cancion item)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(cancionDelete, conn);
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
        //verificar el procedimiento.
        public DataTable GetAll()
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1.Clear();
                conn.Open();
                cmd = new SqlCommand(cancionGetAll, conn);
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
                cmd = new SqlCommand(cancionGet, conn);
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

        public BO.Cancion GetOne(int id)
        {
            try
            {
                BO.Cancion oCancion = new BO.Cancion();
                conn.Open();
                cmd = new SqlCommand(cancionGetOne, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oCancion.id = dr.GetInt32(dr.GetOrdinal("id"));
                    oCancion.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    oCancion.duracion = dr.GetString(dr.GetOrdinal("duracion"));
                    oCancion.numero = dr.GetInt32(dr.GetOrdinal("pistas"));
                    oCancion.reproducciones = dr.GetInt32(dr.GetOrdinal("reproducciones"));
                    oCancion.id_album.id = dr.GetInt32(dr.GetOrdinal("id_album"));
                    oCancion.id_album.nombre = dr.GetString(dr.GetOrdinal("nombre_album"));
                    oCancion.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oCancion.id_genero.nombre = dr.GetString(dr.GetOrdinal("nombre_genero"));
                }
                return oCancion;
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

        public List<BO.Cancion> GetAllObjetc()
        {
            try
            {
                List<BO.Cancion> loCancion = new List<BO.Cancion>();
                conn.Open();
                cmd = new SqlCommand(cancionGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.Cancion oCancion = new BO.Cancion();

                    oCancion.id = dr.GetInt32(dr.GetOrdinal("id"));
                    oCancion.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    oCancion.duracion = dr.GetString(dr.GetOrdinal("duracion"));
                    oCancion.numero = dr.GetInt32(dr.GetOrdinal("pistas"));
                    oCancion.reproducciones = dr.GetInt32(dr.GetOrdinal("reproducciones"));
                    oCancion.id_album.id = dr.GetInt32(dr.GetOrdinal("id_album"));
                    oCancion.id_album.nombre = dr.GetString(dr.GetOrdinal("nombre_album"));
                    oCancion.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oCancion.id_genero.nombre = dr.GetString(dr.GetOrdinal("nombre_genero"));
                    loCancion.Add(oCancion);
                    oCancion = null;
                }
                return loCancion;
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

        public List<BO.Cancion> GetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.Cancion> loCancion = new List<BO.Cancion>();
                conn.Open();
                cmd = new SqlCommand(cancionGet, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@condicion", SqlDbType.Int);
                cmd.Parameters["@condicion"].Value = condicion;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar);
                cmd.Parameters["@valor"].Value = valor;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.Cancion oCancion = new BO.Cancion();

                    oCancion.id = dr.GetInt32(dr.GetOrdinal("id"));
                    oCancion.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    oCancion.duracion = dr.GetString(dr.GetOrdinal("duracion"));
                    oCancion.numero = dr.GetInt32(dr.GetOrdinal("pistas"));
                    oCancion.reproducciones = dr.GetInt32(dr.GetOrdinal("reproducciones"));
                    oCancion.id_album.id = dr.GetInt32(dr.GetOrdinal("id_album"));
                    oCancion.id_album.nombre = dr.GetString(dr.GetOrdinal("nombre_album"));
                    oCancion.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oCancion.id_genero.nombre = dr.GetString(dr.GetOrdinal("nombre_genero"));

                    loCancion.Add(oCancion);
                    oCancion= null;
                }
                return loCancion;
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
