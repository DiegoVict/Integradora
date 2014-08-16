using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    public class Etiqueta
    {
        #region Constructores...
        public Etiqueta()
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

        public static string etiquetaGetAll = "etiquetaGetAll"; // trae todos  registrados sin filtro
        public static string etiquetaGet = "etiquetaGet"; // trae todos los registros por filtro like
        public static string etiquetaGetOne = "etiquetaGetOne"; // trae un registro especifico por id
        public static string etiquetaADD = "etiquetaADD"; // inserta un registro
        public static string etiquetaDelete = "etiquetaDelete"; // elimina un usuario
        public static string etiquetaUpdate = "etiquetaUpdate"; // modifica informacion de un usuario

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador
        public int Add(BO.Etiqueta item)
        {
            //int idAlbum = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(etiquetaADD, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@etiqueta", SqlDbType.VarChar);
                cmd.Parameters["@etiqueta"].Value = item.etiqueta;

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

        public int Update(BO.Etiqueta item)
        {
            //int idUsuario = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(etiquetaUpdate, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = item.id;
                cmd.Parameters.Add("@etiqueta", SqlDbType.VarChar);
                cmd.Parameters["@etiqueta"].Value = item.etiqueta;

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

        public int Delete(BO.Etiqueta item)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(etiquetaDelete, conn);
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
                cmd = new SqlCommand(etiquetaGetAll, conn);
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
                cmd = new SqlCommand(etiquetaGet, conn);
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

        public BO.Etiqueta GetOne(int id)
        {
            try
            {
                BO.Etiqueta oEtiqueta = new BO.Etiqueta();
                conn.Open();
                cmd = new SqlCommand(etiquetaGetOne, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oEtiqueta.id = dr.GetInt32(dr.GetOrdinal("id"));
                    oEtiqueta.etiqueta = dr.GetString(dr.GetOrdinal("etiqueta"));
                }
                return oEtiqueta;
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

        public List<BO.Etiqueta> GetAllObjetc()
        {
            try
            {
                List<BO.Etiqueta> loEtiqueta = new List<BO.Etiqueta>();
                conn.Open();
                cmd = new SqlCommand(etiquetaGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.Etiqueta oEtiqueta = new BO.Etiqueta();

                    oEtiqueta.id = dr.GetInt32(dr.GetOrdinal("id"));
                    oEtiqueta.etiqueta = dr.GetString(dr.GetOrdinal("etiqueta"));

                    loEtiqueta.Add(oEtiqueta);
                    oEtiqueta = null;
                }
                return loEtiqueta;
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

        public List<BO.Etiqueta> GetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.Etiqueta> loEtiqueta = new List<BO.Etiqueta>();
                conn.Open();
                cmd = new SqlCommand(etiquetaGet, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@condicion", SqlDbType.Int);
                cmd.Parameters["@condicion"].Value = condicion;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar);
                cmd.Parameters["@valor"].Value = valor;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.Etiqueta oEtiqueta = new BO.Etiqueta();

                    oEtiqueta.id = dr.GetInt32(dr.GetOrdinal("id"));
                    oEtiqueta.etiqueta = dr.GetString(dr.GetOrdinal("etiqueta"));

                    loEtiqueta.Add(oEtiqueta);
                    oEtiqueta= null;
                }
                return loEtiqueta;
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
