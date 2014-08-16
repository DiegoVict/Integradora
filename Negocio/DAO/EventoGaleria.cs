using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    public class EventoGaleria
    {
        #region Constructores...
        public EventoGaleria()
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

        public static string spGetAll = "eventoGaleriaGetAll"; // trae todos  registrados sin filtro
        public static string spGet = "eventoGaleriaGet"; // trae todos los registros por filtro like
        public static string spGetOne = "eventoGaleriaGetOne"; // trae un registro especifico por id
        public static string spADD = "eventoGaleriaADD"; // inserta un registro
        public static string spDelete = "eventoGaleriaDelete"; // elimina un usuario
        public static string spUpdate = "eventoGaleriaUpdate"; // modifica informacion de un usuario

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador

        public int Add(BO.EventoGaleria item)
        {
            //int idAlbum = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(spADD, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@foto", SqlDbType.VarChar);
                cmd.Parameters["@foto"].Value = item.foto;
                cmd.Parameters.Add("@id_evento", SqlDbType.Int);
                cmd.Parameters["@id_evento"].Value = item.id_evento.id;

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

        public int Update(BO.EventoGaleria item)
        {
            //int idUsuario = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(spUpdate, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = item.id;
                cmd.Parameters.Add("@foto", SqlDbType.VarChar);
                cmd.Parameters["@foto"].Value = item.foto;
                cmd.Parameters.Add("@id_evento", SqlDbType.Int);
                cmd.Parameters["@id_evento"].Value = item.id_evento.id;

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

        public int Delete(BO.EventoGaleria item)
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

        public BO.EventoGaleria GetOne(int id)
        {
            try
            {
                BO.EventoGaleria objeto = new BO.EventoGaleria();
                conn.Open();
                cmd = new SqlCommand(spGetOne, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.foto = dr.GetString(dr.GetOrdinal("foto"));
                    objeto.id_evento.id = dr.GetInt32(dr.GetOrdinal("id_evento"));
                    objeto.id_evento.nombre = dr.GetString(dr.GetOrdinal("nombre_evento"));
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

        public List<BO.EventoGaleria> GetAllObjetc()
        {
            try
            {
                List<BO.EventoGaleria> lobjeto = new List<BO.EventoGaleria>();
                conn.Open();
                cmd = new SqlCommand(spGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.EventoGaleria objeto = new BO.EventoGaleria();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.foto = dr.GetString(dr.GetOrdinal("nombre"));
                    objeto.id_evento.id = dr.GetInt32(dr.GetOrdinal("id_evento"));
                    objeto.id_evento.nombre = dr.GetString(dr.GetOrdinal("nombre_evento"));
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

        public List<BO.EventoGaleria> GetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.EventoGaleria> lobjeto = new List<BO.EventoGaleria>();
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
                    BO.EventoGaleria objeto = new BO.EventoGaleria();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.foto = dr.GetString(dr.GetOrdinal("nombre"));
                    objeto.id_evento.id = dr.GetInt32(dr.GetOrdinal("id_evento"));
                    objeto.id_evento.nombre = dr.GetString(dr.GetOrdinal("nombre_evento"));

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
