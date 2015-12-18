using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DRequisicion
    {
        private int _IdRequisicion;
        private int _IdProduccion;
        private string _Caracter;
        private DateTime _FechaProduccion;
        private string _OrdenTrabajo;
        private string _TextoBuscar;
        private string _TextoBuscar1;

        public int IdRequisicion
        {
            get { return _IdRequisicion; }
            set { _IdRequisicion = value; }
        }

        public int IdProduccion
        {
            get { return _IdProduccion; }
            set { _IdProduccion = value; }
        }       

        public string Caracter
        {
            get { return _Caracter; }
            set { _Caracter = value; }
        }

        public DateTime FechaProduccion
        {
            get { return _FechaProduccion; }
            set { _FechaProduccion = value; }
        }

        public string OrdenTrabajo
        {
            get { return _OrdenTrabajo; }
            set { _OrdenTrabajo = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public string TextoBuscar1
        {
            get { return _TextoBuscar1; }
            set { _TextoBuscar1 = value; }
        }

        //Constructor Vacío
        public DRequisicion()
        {

        }

        //Costructor con parámetros
        public DRequisicion(int idrequisicion, int idproduccion, string caracter, DateTime fechaproduccion, string ordentrabajo, string textobuscar, string textobuscar1)
        {
            this.IdRequisicion = idrequisicion;
            this.IdProduccion = idproduccion;
            this.Caracter = caracter;
            this.FechaProduccion = fechaproduccion;
            this.OrdenTrabajo = ordentrabajo;
            this.TextoBuscar = textobuscar;
            this.TextoBuscar1 = textobuscar1;
        }

        //Método Insertar
        public string Insertar(DRequisicion Requisicion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRequisicion = new SqlParameter();
                ParIdRequisicion.ParameterName = "@idrequisicion";
                ParIdRequisicion.SqlDbType = SqlDbType.Int;
                ParIdRequisicion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdRequisicion);

                SqlParameter ParIdProduccion = new SqlParameter();
                ParIdProduccion.ParameterName = "@idproduccion";
                ParIdProduccion.SqlDbType = SqlDbType.Int;
                ParIdProduccion.Value = Requisicion.IdProduccion;
                SqlCmd.Parameters.Add(ParIdProduccion);

                SqlParameter ParCaracter = new SqlParameter();
                ParCaracter.ParameterName = "@caracter";
                ParCaracter.SqlDbType = SqlDbType.VarChar;
                ParCaracter.Size = 12;
                ParCaracter.Value = Requisicion.Caracter;
                SqlCmd.Parameters.Add(ParCaracter);

                SqlParameter ParFechaProduccion = new SqlParameter();
                ParFechaProduccion.ParameterName = "@fecha_produccion";
                ParFechaProduccion.SqlDbType = SqlDbType.DateTime;
                ParFechaProduccion.Value = Requisicion.FechaProduccion;
                SqlCmd.Parameters.Add(ParFechaProduccion);

                SqlParameter ParOrdenTrabajo = new SqlParameter();
                ParOrdenTrabajo.ParameterName = "@orden_trabajo";
                ParOrdenTrabajo.SqlDbType = SqlDbType.VarChar;
                ParOrdenTrabajo.Size = 10;
                ParOrdenTrabajo.Value = Requisicion.OrdenTrabajo;
                SqlCmd.Parameters.Add(ParOrdenTrabajo);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro";

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

        // Método Editar
        public string Editar(DRequisicion Requisicion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter ParIdRequisicion = new SqlParameter();
                ParIdRequisicion.ParameterName = "@idrequisicion";
                ParIdRequisicion.SqlDbType = SqlDbType.Int;
                ParIdRequisicion.Value = Requisicion.IdRequisicion;
                SqlCmd.Parameters.Add(ParIdRequisicion);

                SqlParameter ParIdProduccion = new SqlParameter();
                ParIdProduccion.ParameterName = "@idproduccion";
                ParIdProduccion.SqlDbType = SqlDbType.Int;
                ParIdProduccion.Value = Requisicion.IdProduccion;
                SqlCmd.Parameters.Add(ParIdProduccion);

                SqlParameter ParCaracter = new SqlParameter();
                ParCaracter.ParameterName = "@caracter";
                ParCaracter.SqlDbType = SqlDbType.VarChar;
                ParCaracter.Size = 12;
                ParCaracter.Value = Requisicion.Caracter;
                SqlCmd.Parameters.Add(ParCaracter);

                SqlParameter ParFechaProduccion = new SqlParameter();
                ParFechaProduccion.ParameterName = "@fecha_produccion";
                ParFechaProduccion.SqlDbType = SqlDbType.DateTime;
                ParFechaProduccion.Value = Requisicion.FechaProduccion;
                SqlCmd.Parameters.Add(ParFechaProduccion);

                SqlParameter ParOrdenTrabajo = new SqlParameter();
                ParOrdenTrabajo.ParameterName = "@orden_trabajo";
                ParOrdenTrabajo.SqlDbType = SqlDbType.VarChar;
                ParOrdenTrabajo.Size = 10;
                ParOrdenTrabajo.Value = Requisicion.OrdenTrabajo;
                SqlCmd.Parameters.Add(ParOrdenTrabajo);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizó el Registro";

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
        public string Eliminar(DRequisicion Requisicion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRequisicion = new SqlParameter();
                ParIdRequisicion.ParameterName = "@idrequisicion";
                ParIdRequisicion.SqlDbType = SqlDbType.Int;
                ParIdRequisicion.Value = Requisicion.IdRequisicion;
                SqlCmd.Parameters.Add(ParIdRequisicion);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Eliminó el Registro";

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
            DataTable DtResultado = new DataTable("requisicion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_requisicion";
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

        //Método BuscarRequisicion
        public DataTable BuscarRequisicion(DRequisicion Requisicion)
        {
            DataTable DtResultado = new DataTable("requisicion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Requisicion.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }
        
        //Método BuscarIdSolicitante
        public DataTable BuscarIdSolicitante(DRequisicion Requisicion)
        {
            DataTable DtResultado = new DataTable("requisicion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_idsolicitante_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Requisicion.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        //Método BuscarOrdenTrabajo
        public DataTable BuscarOrdenTrabajo(DRequisicion Requisicion)
        {
            DataTable DtResultado = new DataTable("requisicion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_orden_trabajo_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Requisicion.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        //Método BuscarFechaSolicitud
        public DataTable BuscarFechaSolicitud(DRequisicion Requisicion)
        {
            DataTable DtResultado = new DataTable("requisicion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_fecha_solicitud_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Requisicion.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar1 = new SqlParameter();
                ParTextoBuscar1.ParameterName = "@textobuscar1";
                ParTextoBuscar1.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar1.Size = 50;
                ParTextoBuscar1.Value = Requisicion.TextoBuscar1;
                SqlCmd.Parameters.Add(ParTextoBuscar1);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        //Método ObtenerId
        public DataTable ObtenerId()
        {
            DataTable DtResultado = new DataTable("requisicion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spcurrent_identity_requisicion";
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
    }
}
