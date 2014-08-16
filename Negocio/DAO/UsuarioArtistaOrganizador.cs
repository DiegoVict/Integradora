using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.DAO
{
    public class UsuarioArtistaOrganizador
    {
        #region Constructores...

        public UsuarioArtistaOrganizador()
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

        public static string usuarioArtistaOrganizadorGetAll = "usuarioArtistaOrganizadorGetAll"; // trae todos los usuarios registrados sin filtro
        public static string usuarioArtistaOrganizadorGet = "usuarioArtistaOrganizadorGet"; // trae todos los usuario registrados por filtro like
        public static string usuarioArtistaOrganizadorGetOne = "usuarioArtistaOrganizadorGetOne"; // trae un usuario especifico por id
        public static string usuarioArtistaOrganizadorADD = "usuarioArtistaOrganizadorADD"; // inserta un usuario
        public static string usuarioArtistaOrganizadorDelete = "usuarioArtistaOrganizadorDelete"; // elimina un usuario
        public static string usuarioArtistaOrganizadorUpdate = "usuarioArtistaOrganizadorUpdate"; // modifica informacion de un usuario
        public static string usuarioArtistaOrganizadorValida = "usuarioArtistaOrganizadorValida"; // valida que el usuario exista (login)

        //usuario Artista
        public static string usuarioArtistaGetAll = "usuarioArtistaGetAll";
        public static string usuarioArtistaGet = "usuarioArtistaGet";
        public static string usuarioArtistaGetOne = "usuarioArtistaGetOne";

        // usuario Organizador
        public static string usuarioOrganizadorGetAll = "usuarioOrganizadorGetAll";
        public static string usuarioOrganizadorGet = "usuarioOrganizadorGet";
        public static string usuarioOrganizadorGetOne = "usuarioOrganizadorGetOne";

        #endregion

        #region Metodos...

        public DataTable GetAll()
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1.Clear();
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaOrganizadorGetAll, conn);
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

        public DataTable artistaGetAll()
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1.Clear();
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaGetAll, conn);
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

        public DataTable organizadorGetAll()
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1.Clear();
                conn.Open();
                cmd = new SqlCommand(usuarioOrganizadorGetAll, conn);
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

        public BO.UsuarioArtistaOrganizador login(BO.UsuarioArtistaOrganizador item)
        {
            try
            {
                BO.UsuarioArtistaOrganizador oUsuario = new BO.UsuarioArtistaOrganizador();
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaOrganizadorValida, conn);
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
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    oUsuario.id_tipo.id = dr.GetInt32(dr.GetOrdinal("id_tipo"));
                    oUsuario.id_tipo.nombre = dr.GetString(dr.GetOrdinal("tipo"));
                    oUsuario.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oUsuario.id_genero.nombre = dr.GetString(dr.GetOrdinal("genero"));
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
                cmd = new SqlCommand(usuarioArtistaOrganizadorGet, conn);
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

        public DataTable artistaGet(int condicion, string valor)
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1.Clear();
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaGet, conn);
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

        public DataTable organizadorGet(int condicion, string valor)
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1.Clear();
                conn.Open();
                cmd = new SqlCommand(usuarioOrganizadorGet, conn);
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

        public BO.UsuarioArtistaOrganizador GetOne(int id)
        {
            try
            {
                BO.UsuarioArtistaOrganizador oUsuario = new BO.UsuarioArtistaOrganizador();
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaOrganizadorGetOne, conn);
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
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    oUsuario.id_tipo.id = dr.GetInt32(dr.GetOrdinal("id_tipo"));
                    oUsuario.id_tipo.nombre = dr.GetString(dr.GetOrdinal("tipo"));
                    oUsuario.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oUsuario.id_genero.nombre = dr.GetString(dr.GetOrdinal("genero"));
                    oUsuario.imagen= dr.GetString(dr.GetOrdinal("imagen"));
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

        public BO.UsuarioArtistaOrganizador artistaGetOne(int id)
        {
            try
            {
                BO.UsuarioArtistaOrganizador oUsuario = new BO.UsuarioArtistaOrganizador();
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaGetOne, conn);
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
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    oUsuario.id_tipo.id = dr.GetInt32(dr.GetOrdinal("id_tipo"));
                    oUsuario.id_tipo.nombre = dr.GetString(dr.GetOrdinal("tipo"));
                    oUsuario.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oUsuario.id_genero.nombre = dr.GetString(dr.GetOrdinal("genero"));
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

        public BO.UsuarioArtistaOrganizador organizadorGetOne(int id)
        {
            try
            {
                BO.UsuarioArtistaOrganizador oUsuario = new BO.UsuarioArtistaOrganizador();
                conn.Open();
                cmd = new SqlCommand(usuarioOrganizadorGetOne, conn);
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
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    oUsuario.id_tipo.id = dr.GetInt32(dr.GetOrdinal("id_tipo"));
                    oUsuario.id_tipo.nombre = dr.GetString(dr.GetOrdinal("tipo"));
                    oUsuario.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oUsuario.id_genero.nombre = dr.GetString(dr.GetOrdinal("genero"));
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

        public List<BO.UsuarioArtistaOrganizador> GetAllObject()
        {
            try
            {
                List<BO.UsuarioArtistaOrganizador> loUsuario = new List<BO.UsuarioArtistaOrganizador>();
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaOrganizadorGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.UsuarioArtistaOrganizador oUsuario = new BO.UsuarioArtistaOrganizador();
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
                    oUsuario.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oUsuario.id_genero.nombre = dr.GetString(dr.GetOrdinal("genero"));
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    loUsuario.Add(oUsuario);
                    oUsuario = null;
                }
                return loUsuario;
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

        public List<BO.UsuarioArtistaOrganizador> artistaGetAllObject()
        {
            try
            {
                List<BO.UsuarioArtistaOrganizador> loUsuario = new List<BO.UsuarioArtistaOrganizador>();
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.UsuarioArtistaOrganizador oUsuario = new BO.UsuarioArtistaOrganizador();
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
                    oUsuario.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oUsuario.id_genero.nombre = dr.GetString(dr.GetOrdinal("genero"));
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    loUsuario.Add(oUsuario);
                    oUsuario = null;
                }
                return loUsuario;
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

        public List<BO.UsuarioArtistaOrganizador> organizadorGetAllObject()
        {
            try
            {
                List<BO.UsuarioArtistaOrganizador> loUsuario = new List<BO.UsuarioArtistaOrganizador>();
                conn.Open();
                cmd = new SqlCommand(usuarioOrganizadorGetAll, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.UsuarioArtistaOrganizador oUsuario = new BO.UsuarioArtistaOrganizador();
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
                    oUsuario.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oUsuario.id_genero.nombre = dr.GetString(dr.GetOrdinal("genero"));
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    loUsuario.Add(oUsuario);
                    oUsuario = null;
                }
                return loUsuario;
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

        // retornamos el id del usuario insertado para insertarlo en nuestro usuarioartistaOrganizador
        public int Add(BO.UsuarioArtistaOrganizador item)
        {
            // falta meterle transaccion
            //int idUsuario = 0;
            int i = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaOrganizadorADD, conn);
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
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                cmd.Parameters["@imagen"].Value = item.imagen;
                cmd.Parameters.Add("@id_tipo", SqlDbType.Int);
                cmd.Parameters["@id_tipo"].Value = item.id_tipo.id;
                cmd.Parameters.Add("@id_genero", SqlDbType.Int);
                cmd.Parameters["@id_genero"].Value = item.id_genero.id;
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

        public int Update(BO.UsuarioArtistaOrganizador item)
        {
            //int idUsuario = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaOrganizadorUpdate, conn);
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
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                cmd.Parameters["@imagen"].Value = item.imagen;
                cmd.Parameters.Add("@id_tipo", SqlDbType.Int);
                cmd.Parameters["@id_tipo"].Value = item.id_tipo.id;
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

        public int Delete(BO.UsuarioArtistaOrganizador item)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaOrganizadorDelete, conn);
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

        public List<BO.UsuarioArtistaOrganizador> GetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.UsuarioArtistaOrganizador> lobjeto = new List<BO.UsuarioArtistaOrganizador>();
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaOrganizadorGet, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@condicion", SqlDbType.Int);
                cmd.Parameters["@condicion"].Value = condicion;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar);
                cmd.Parameters["@valor"].Value = valor;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.UsuarioArtistaOrganizador oUsuario = new BO.UsuarioArtistaOrganizador();
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
                    oUsuario.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oUsuario.id_genero.nombre = dr.GetString(dr.GetOrdinal("genero"));
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    lobjeto.Add(oUsuario);
                    oUsuario = null;
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

        public List<BO.UsuarioArtistaOrganizador> artistaGetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.UsuarioArtistaOrganizador> lobjeto = new List<BO.UsuarioArtistaOrganizador>();
                conn.Open();
                cmd = new SqlCommand(usuarioArtistaGet, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@condicion", SqlDbType.Int);
                cmd.Parameters["@condicion"].Value = condicion;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar);
                cmd.Parameters["@valor"].Value = valor;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.UsuarioArtistaOrganizador oUsuario = new BO.UsuarioArtistaOrganizador();
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
                    oUsuario.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oUsuario.id_genero.nombre = dr.GetString(dr.GetOrdinal("genero"));
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    lobjeto.Add(oUsuario);
                    oUsuario = null;
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

        public List<BO.UsuarioArtistaOrganizador> organizadorGetObjetc(int condicion, string valor)
        {
            try
            {
                List<BO.UsuarioArtistaOrganizador> lobjeto = new List<BO.UsuarioArtistaOrganizador>();
                conn.Open();
                cmd = new SqlCommand(usuarioOrganizadorGet, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@condicion", SqlDbType.Int);
                cmd.Parameters["@condicion"].Value = condicion;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar);
                cmd.Parameters["@valor"].Value = valor;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BO.UsuarioArtistaOrganizador oUsuario = new BO.UsuarioArtistaOrganizador();
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
                    oUsuario.id_genero.id = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    oUsuario.id_genero.nombre = dr.GetString(dr.GetOrdinal("genero"));
                    oUsuario.imagen = dr.GetString(dr.GetOrdinal("imagen"));
                    lobjeto.Add(oUsuario);
                    oUsuario = null;
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
