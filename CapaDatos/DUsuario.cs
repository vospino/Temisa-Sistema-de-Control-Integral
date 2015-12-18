using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DUsuario
    {
        private int _IdUsuario;
        private string _Usuario;
        private string _Password;
        private string _Nombre;
        private string _Apellido;
        private int _Departamento;
        private bool _activo;
        private string _TextoBuscar;

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public int Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructor vacio
        public DUsuario()
        {

        }

        //Constructor con parámetros
        public DUsuario(int idusuario, string usuario, string password, string nombre, string apellido, int departamento, bool activo, string textoBuscar)
        {
            this.IdUsuario = idusuario;
            this.Usuario = usuario;
            this.Password = password;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Departamento = departamento;
            this.Activo = activo;
            this.TextoBuscar = textoBuscar;
        }

        //Método Insertar
        public string Insertar(DUsuario Usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdUsuario = new SqlParameter();
                ParIdUsuario.ParameterName = "@id";
                ParIdUsuario.SqlDbType = SqlDbType.Int;
                ParIdUsuario.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdUsuario);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Usuario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 100;
                ParPassword.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Usuario.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Usuario.Apellido;
                SqlCmd.Parameters.Add(ParApellido);
                
                SqlParameter ParDepartamento = new SqlParameter();
                ParDepartamento.ParameterName = "@departamento";
                ParDepartamento.SqlDbType = SqlDbType.Int;
                ParDepartamento.Value = Usuario.Departamento;
                SqlCmd.Parameters.Add(ParDepartamento);

                SqlParameter ParActivo = new SqlParameter();
                ParActivo.ParameterName = "@activo";
                ParActivo.SqlDbType = SqlDbType.Bit;
                ParActivo.Value = Usuario.Activo;
                SqlCmd.Parameters.Add(ParActivo);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingresó el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Editar
        public string Editar(DUsuario Usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmodificar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdUsuario = new SqlParameter();
                ParIdUsuario.ParameterName = "@id";
                ParIdUsuario.SqlDbType = SqlDbType.Int;
                ParIdUsuario.Value = Usuario.IdUsuario;
                SqlCmd.Parameters.Add(ParIdUsuario);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Usuario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 100;
                ParPassword.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Usuario.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Usuario.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParDepartamento = new SqlParameter();
                ParDepartamento.ParameterName = "@departamento";
                ParDepartamento.SqlDbType = SqlDbType.Int;
                ParDepartamento.Value = Usuario.Departamento;
                SqlCmd.Parameters.Add(ParDepartamento);

                SqlParameter ParActivo = new SqlParameter();
                ParActivo.ParameterName = "@activo";
                ParActivo.SqlDbType = SqlDbType.Bit;
                ParActivo.Value = Usuario.Activo;
                SqlCmd.Parameters.Add(ParActivo);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizó el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Eliminar
        public string Eliminar(DUsuario Usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdUsuario = new SqlParameter();
                ParIdUsuario.ParameterName = "@id";
                ParIdUsuario.SqlDbType = SqlDbType.Int;
                ParIdUsuario.Value = Usuario.IdUsuario;
                SqlCmd.Parameters.Add(ParIdUsuario);                

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Eliminó el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("usuario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        //Método BuscarNombre
        public DataTable BuscarNombre(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("usuario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nombre_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTectoBuscar = new SqlParameter();
                ParTectoBuscar.ParameterName = "@textobuscar";
                ParTectoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTectoBuscar.Size = 50;
                ParTectoBuscar.Value = Usuario.TextoBuscar;
                SqlCmd.Parameters.Add(ParTectoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        //Método BUscarApellido
        public DataTable BuscarApellido(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("usuario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_apellido_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTectoBuscar = new SqlParameter();
                ParTectoBuscar.ParameterName = "@textobuscar";
                ParTectoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTectoBuscar.Size = 50;
                ParTectoBuscar.Value = Usuario.TextoBuscar;
                SqlCmd.Parameters.Add(ParTectoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        //Método BuscarId
        public DataTable BuscarId(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("usuario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_id_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTectoBuscar = new SqlParameter();
                ParTectoBuscar.ParameterName = "@textobuscar";
                ParTectoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTectoBuscar.Size = 50;
                ParTectoBuscar.Value = Usuario.TextoBuscar;
                SqlCmd.Parameters.Add(ParTectoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        //Método splogin
        public DataTable Login(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("trabajador");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "splogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Usuario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 100;
                ParPassword.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

    }
}
