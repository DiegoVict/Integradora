using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    public class Evento
    {
       #region Constructores...
        public Evento()
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

        public static string spGetAll = "eventoGetAll"; // trae todos  registrados sin filtro
        public static string spGet = "eventoGet"; // trae todos los registros por filtro like
        public static string spGetOne = "eventoGetOne"; // trae un registro especifico por id
        public static string spADD = "EventoADD"; // inserta un registro
        public static string spDelete = "eventoDelete"; // elimina un usuario
        public static string spUpdate = "eventoUpdate"; // modifica informacion de un usuario

        #endregion

        #region Metodos...

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador

        public int Add(BO.Evento item)
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
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar);
                cmd.Parameters["@direccion"].Value = item.direccion;
                // habria que usar 2 fechas una del evento y otra de creacion.
                // tambien la fecha de modificacion
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime);
                cmd.Parameters["@fecha"].Value = item.fecha;
                cmd.Parameters.Add("@enlace", SqlDbType.VarChar);
                cmd.Parameters["@enlace"].Value = item.enlace;
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                cmd.Parameters["@imagen"].Value = item.imagen;
                cmd.Parameters.Add("@id_organizador", SqlDbType.Int);
                cmd.Parameters["@id_organizador"].Value = item.id_organizador.id;
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

        public int Update(BO.Evento item)
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
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar);
                cmd.Parameters["@direccion"].Value = item.direccion;
                // habria que usar 2 fechas una del evento y otra de creacion.
                // tambien la fecha de modificacion
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime);
                cmd.Parameters["@fecha"].Value = item.fecha;
                cmd.Parameters.Add("@enlace", SqlDbType.VarChar);
                cmd.Parameters["@enlace"].Value = item.enlace;
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                cmd.Parameters["@imagen"].Value = item.imagen;
                cmd.Parameters.Add("@id_organizador", SqlDbType.Int);
                cmd.Parameters["@id_organizador"].Value = item.id_organizador.id;

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

        public int Delete(BO.Evento item)
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
                
                cmd = new SqlCommand(spGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
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

        public BO.Evento GetOne(int id)
        {
            try
            {
                BO.Evento objeto = new BO.Evento();
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
                    objeto.direccion = dr.GetString(dr.GetOrdinal("direccion"));
                    objeto.fecha = dr.GetDateTime(dr.GetOrdinal("fecha"));
                    objeto.enlace = dr.GetString(dr.GetOrdinal("enlace"));
                    objeto.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    objeto.id_organizador.id = dr.GetInt32(dr.GetOrdinal("id_organizador"));
                    objeto.id_organizador.nombre = dr.GetString(dr.GetOrdinal("nombre_organizador"));
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

        public List<BO.Evento> GetAllObjetc()
        {
            try
            {
                List<BO.Evento> lobjeto = new List<BO.Evento>();
                conn.Open();
                cmd = new SqlCommand(spGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.Evento objeto = new BO.Evento();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    objeto.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
                    objeto.direccion = dr.GetString(dr.GetOrdinal("direccion"));
                    objeto.fecha = dr.GetDateTime(dr.GetOrdinal("fecha"));
                    objeto.enlace = dr.GetString(dr.GetOrdinal("enlace"));
                    objeto.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    objeto.id_organizador.id = dr.GetInt32(dr.GetOrdinal("id_organizador"));
                    objeto.id_organizador.nombre = dr.GetString(dr.GetOrdinal("nombre_organizador"));
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

        public List<BO.Evento> GetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.Evento> lobjeto = new List<BO.Evento>();
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
                    BO.Evento objeto = new BO.Evento();

                    objeto.id = dr.GetInt32(dr.GetOrdinal("id"));
                    objeto.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    objeto.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
                    objeto.fecha = dr.GetDateTime(dr.GetOrdinal("fecha"));
                    objeto.enlace = dr.GetString(dr.GetOrdinal("enlace"));
                    objeto.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    objeto.id_organizador.id = dr.GetInt32(dr.GetOrdinal("id_organizador"));
                    objeto.id_organizador.nombre = dr.GetString(dr.GetOrdinal("nombre_organizador"));
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
