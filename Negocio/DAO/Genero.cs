using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    public class Genero
    {
        #region Constructores...
        public Genero()
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

        public static string spGetAll = "generoGetAll"; // trae todos  registrados sin filtro
        public static string spGet = "generoGet"; // trae todos los registros por filtro like
        public static string spGetOne = "generoGetOne"; // trae un registro especifico por id
        public static string spADD = "generoADD"; // inserta un registro
        public static string spDelete = "generoDelete"; // elimina un usuario
        public static string spUpdate = "generoUpate"; // modifica informacion de un usuario

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador

        public int Add(BO.Genero item)
        {
            //int idAlbum = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(spADD, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = item.nombre;
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

        public int Update(BO.Genero item)
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

        public int Delete(BO.Genero item)
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

        public BO.Genero GetOne(int id)
        {
            try
            {
                BO.Genero objeto = new BO.Genero();
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
                    objeto.imagen = dr.GetString(dr.GetOrdinal("imagen"));
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

        public List<BO.Genero> GetAllObjetc()
        {
            try
            {
                List<BO.Genero> lobjeto = new List<BO.Genero>();
                conn.Open();
                cmd = new SqlCommand(spGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.Genero objeto = new BO.Genero();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    objeto.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    
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

        public List<BO.Genero> GetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.Genero> lobjeto = new List<BO.Genero>();
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
                    BO.Genero objeto = new BO.Genero();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    objeto.imagen = dr.GetString(dr.GetOrdinal("imagen"));

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
