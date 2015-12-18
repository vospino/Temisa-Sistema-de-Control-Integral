using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDetalleRequisicion
    {
        private int _IdDetalleRequisicion;
        private int _RequisicionNum;
        private decimal _Cantidad;
        private string _Stock;
        private string _Descripcion;
        private string _Unidad;
        private string _StatusAlmacen;
        private string _StatusCompra;
        private string _StatusDireccion;
        private DateTime _FechaAlmacen;
        private DateTime _FechaCompra;
        private DateTime _FechaDireccion;
        private int _IdAlmacenero;
        private int _IdCompra;
        private int _IdDireccion;
        private string _Justificacion;
        private string _TextoBuscar;                 

        public int IdDetalleRequisicion
        {
            get { return _IdDetalleRequisicion; }
            set { _IdDetalleRequisicion = value; }
        }

        public int RequisicionNum
        {
            get { return _RequisicionNum; }
            set { _RequisicionNum = value; }
        }

        public decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public string Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public string Unidad
        {
            get { return _Unidad; }
            set { _Unidad = value; }
        }

        public string StatusAlmacen
        {
            get { return _StatusAlmacen; }
            set { _StatusAlmacen = value; }
        }

        public string StatusCompra
        {
            get { return _StatusCompra; }
            set { _StatusCompra = value; }
        }

        public string StatusDireccion
        {
            get { return _StatusDireccion; }
            set { _StatusDireccion = value; }
        }

        public DateTime FechaAlmacen
        {
            get { return _FechaAlmacen; }
            set { _FechaAlmacen = value; }
        }

        public DateTime FechaCompra
        {
            get { return _FechaCompra; }
            set { _FechaCompra = value; }
        }

        public DateTime FechaDireccion
        {
            get { return _FechaDireccion; }
            set { _FechaDireccion = value; }
        }

        public int IdAlmacenero
        {
            get { return _IdAlmacenero; }
            set { _IdAlmacenero = value; }
        }

        public int IdCompra
        {
            get { return _IdCompra; }
            set { _IdCompra = value; }
        }

        public int IdDireccion
        {
            get { return _IdDireccion; }
            set { _IdDireccion = value; }
        }

        public string Justificacion
        {
            get { return _Justificacion; }
            set { _Justificacion = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructor Vacío
        public DDetalleRequisicion()
        {

        }

        //Costructor con parámetros
        public DDetalleRequisicion(int idDetalleRequisicion, int requisionNum, decimal cantidad, string stock, string descripcion, string unidad, string statusalmacen, string statuscompra, string statusdireccion, DateTime fechaalmacen, DateTime fechacompra, DateTime fechadireccion, int idalmacenero, int idcompra, int iddireccion, string justificacion, string textobuscar)
        {
            this.IdDetalleRequisicion = idDetalleRequisicion;
            this.RequisicionNum = requisionNum;
            this.Cantidad = cantidad;
            this.Stock = stock;
            this.Descripcion = descripcion;
            this.Unidad = unidad;
            this.StatusAlmacen = statusalmacen;
            this.StatusCompra = statuscompra;
            this.StatusDireccion = statusdireccion;
            this.FechaAlmacen = fechaalmacen;
            this.FechaCompra = fechacompra;
            this.FechaDireccion = fechadireccion;
            this.IdAlmacenero = idalmacenero;
            this.IdCompra = idcompra;
            this.IdDireccion = iddireccion;
            this.Justificacion = justificacion;
            this.TextoBuscar = textobuscar;
            
        }

        //Método Insertar
        public string Insertar(DDetalleRequisicion DetalleRequisicion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_detalle_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDetalleRequisicion = new SqlParameter();
                ParIdDetalleRequisicion.ParameterName = "@id_detalle_requisicion";
                ParIdDetalleRequisicion.SqlDbType = SqlDbType.Int;
                ParIdDetalleRequisicion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDetalleRequisicion);

                SqlParameter ParRequisicionNum = new SqlParameter();
                ParRequisicionNum.ParameterName = "@requisicion_num";
                ParRequisicionNum.SqlDbType = SqlDbType.Int;
                ParRequisicionNum.Value = DetalleRequisicion.RequisicionNum;
                SqlCmd.Parameters.Add(ParRequisicionNum);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Decimal;
                ParCantidad.Value = DetalleRequisicion.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParStock = new SqlParameter();
                ParStock.ParameterName = "@stock";
                ParStock.SqlDbType = SqlDbType.VarChar;
                ParStock.Size = 20;
                ParStock.Value = DetalleRequisicion.Stock;
                SqlCmd.Parameters.Add(ParStock);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Value = DetalleRequisicion.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParUnidad = new SqlParameter();
                ParUnidad.ParameterName = "@unidad";
                ParUnidad.SqlDbType = SqlDbType.VarChar;
                ParUnidad.Size = 20;
                ParUnidad.Value = DetalleRequisicion.Unidad;
                SqlCmd.Parameters.Add(ParUnidad);                

                SqlParameter ParStatusAlmacen = new SqlParameter();
                ParStatusAlmacen.ParameterName = "@status_almacen";
                ParStatusAlmacen.SqlDbType = SqlDbType.VarChar;
                ParStatusAlmacen.Size = 20;
                ParStatusAlmacen.Value = DetalleRequisicion.StatusAlmacen;
                SqlCmd.Parameters.Add(ParStatusAlmacen);

                SqlParameter ParStatusCompra = new SqlParameter();
                ParStatusCompra.ParameterName = "@status_compra";
                ParStatusCompra.SqlDbType = SqlDbType.VarChar;
                ParStatusCompra.Size = 20;
                ParStatusCompra.Value = DetalleRequisicion.StatusCompra;
                SqlCmd.Parameters.Add(ParStatusCompra);

                SqlParameter ParStatusDireccion = new SqlParameter();
                ParStatusDireccion.ParameterName = "@status_direccion";
                ParStatusDireccion.SqlDbType = SqlDbType.VarChar;
                ParStatusDireccion.Size = 20;
                ParStatusDireccion.Value = DetalleRequisicion.StatusDireccion;
                SqlCmd.Parameters.Add(ParStatusDireccion);

                SqlParameter ParFechaAlmacen = new SqlParameter();
                ParFechaAlmacen.ParameterName = "@fecha_almacen";
                ParFechaAlmacen.SqlDbType = SqlDbType.DateTime;
                ParFechaAlmacen.Value = DetalleRequisicion.FechaAlmacen;
                SqlCmd.Parameters.Add(ParFechaAlmacen);

                SqlParameter ParFechaCompra = new SqlParameter();
                ParFechaCompra.ParameterName = "@fecha_compra";
                ParFechaCompra.SqlDbType = SqlDbType.DateTime;
                ParFechaCompra.Value = DetalleRequisicion.FechaCompra;
                SqlCmd.Parameters.Add(ParFechaCompra);

                SqlParameter ParFechaDireccion = new SqlParameter();
                ParFechaDireccion.ParameterName = "@fecha_direccion";
                ParFechaDireccion.SqlDbType = SqlDbType.DateTime;
                ParFechaDireccion.Value = DetalleRequisicion.FechaDireccion;
                SqlCmd.Parameters.Add(ParFechaDireccion);

                SqlParameter ParIdAlmacenero = new SqlParameter();
                ParIdAlmacenero.ParameterName = "@idalmacenero";
                ParIdAlmacenero.SqlDbType = SqlDbType.Int;
                ParIdAlmacenero.Value = DetalleRequisicion.IdAlmacenero;
                SqlCmd.Parameters.Add(ParIdAlmacenero);

                SqlParameter ParIdCompra = new SqlParameter();
                ParIdCompra.ParameterName = "@idcompra";
                ParIdCompra.SqlDbType = SqlDbType.Int;
                ParIdCompra.Value = DetalleRequisicion.IdCompra;
                SqlCmd.Parameters.Add(ParIdCompra);

                SqlParameter ParIdDireccion = new SqlParameter();
                ParIdDireccion.ParameterName = "@iddireccion";
                ParIdDireccion.SqlDbType = SqlDbType.Int;
                ParIdDireccion.Value = DetalleRequisicion.IdDireccion;
                SqlCmd.Parameters.Add(ParIdDireccion);

                SqlParameter ParJustificacion = new SqlParameter();
                ParJustificacion.ParameterName = "@justificacion";
                ParJustificacion.SqlDbType = SqlDbType.VarChar;
                ParJustificacion.Value = DetalleRequisicion.Justificacion;
                SqlCmd.Parameters.Add(ParJustificacion);

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
        public string Editar(DDetalleRequisicion DetalleRequisicion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_detalle_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDetalleRequisicion = new SqlParameter();
                ParIdDetalleRequisicion.ParameterName = "@id_detalle_requisicion";
                ParIdDetalleRequisicion.SqlDbType = SqlDbType.Int;
                ParIdDetalleRequisicion.Value = DetalleRequisicion.IdDetalleRequisicion;
                SqlCmd.Parameters.Add(ParIdDetalleRequisicion);

                SqlParameter ParRequisicionNum = new SqlParameter();
                ParRequisicionNum.ParameterName = "@requisicion_num";
                ParRequisicionNum.SqlDbType = SqlDbType.Int;
                ParRequisicionNum.Value = DetalleRequisicion.RequisicionNum;
                SqlCmd.Parameters.Add(ParRequisicionNum);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Decimal;
                ParCantidad.Value = DetalleRequisicion.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParStock = new SqlParameter();
                ParStock.ParameterName = "@stock";
                ParStock.SqlDbType = SqlDbType.VarChar;
                ParStock.Size = 20;
                ParStock.Value = DetalleRequisicion.Stock;
                SqlCmd.Parameters.Add(ParStock);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Value = DetalleRequisicion.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParUnidad = new SqlParameter();
                ParUnidad.ParameterName = "@unidad";
                ParUnidad.SqlDbType = SqlDbType.VarChar;
                ParUnidad.Size = 20;
                ParUnidad.Value = DetalleRequisicion.Unidad;
                SqlCmd.Parameters.Add(ParUnidad);

                SqlParameter ParStatusAlmacen = new SqlParameter();
                ParStatusAlmacen.ParameterName = "@status_almacen";
                ParStatusAlmacen.SqlDbType = SqlDbType.VarChar;
                ParStatusAlmacen.Size = 20;
                ParStatusAlmacen.Value = DetalleRequisicion.StatusAlmacen;
                SqlCmd.Parameters.Add(ParStatusAlmacen);

                SqlParameter ParStatusCompra = new SqlParameter();
                ParStatusCompra.ParameterName = "@status_compra";
                ParStatusCompra.SqlDbType = SqlDbType.VarChar;
                ParStatusCompra.Size = 20;
                ParStatusCompra.Value = DetalleRequisicion.StatusCompra;
                SqlCmd.Parameters.Add(ParStatusCompra);

                SqlParameter ParStatusDireccion = new SqlParameter();
                ParStatusDireccion.ParameterName = "@status_direccion";
                ParStatusDireccion.SqlDbType = SqlDbType.VarChar;
                ParStatusDireccion.Size = 20;
                ParStatusDireccion.Value = DetalleRequisicion.StatusDireccion;
                SqlCmd.Parameters.Add(ParStatusDireccion);

                SqlParameter ParFechaAlmacen = new SqlParameter();
                ParFechaAlmacen.ParameterName = "@fecha_almacen";
                ParFechaAlmacen.SqlDbType = SqlDbType.DateTime;
                ParFechaAlmacen.Value = DetalleRequisicion.FechaAlmacen;
                SqlCmd.Parameters.Add(ParFechaAlmacen);

                SqlParameter ParFechaCompra = new SqlParameter();
                ParFechaCompra.ParameterName = "@fecha_compra";
                ParFechaCompra.SqlDbType = SqlDbType.DateTime;
                ParFechaCompra.Value = DetalleRequisicion.FechaCompra;
                SqlCmd.Parameters.Add(ParFechaCompra);

                SqlParameter ParFechaDireccion = new SqlParameter();
                ParFechaDireccion.ParameterName = "@fecha_direccion";
                ParFechaDireccion.SqlDbType = SqlDbType.DateTime;
                ParFechaDireccion.Value = DetalleRequisicion.FechaDireccion;
                SqlCmd.Parameters.Add(ParFechaDireccion);

                SqlParameter ParIdAlmacenero = new SqlParameter();
                ParIdAlmacenero.ParameterName = "@idalmacenero";
                ParIdAlmacenero.SqlDbType = SqlDbType.Int;
                ParIdAlmacenero.Value = DetalleRequisicion.IdAlmacenero;
                SqlCmd.Parameters.Add(ParIdAlmacenero);

                SqlParameter ParIdCompra = new SqlParameter();
                ParIdCompra.ParameterName = "@idcompra";
                ParIdCompra.SqlDbType = SqlDbType.Int;
                ParIdCompra.Value = DetalleRequisicion.IdCompra;
                SqlCmd.Parameters.Add(ParIdCompra);

                SqlParameter ParIdDireccion = new SqlParameter();
                ParIdDireccion.ParameterName = "@iddireccion";
                ParIdDireccion.SqlDbType = SqlDbType.Int;
                ParIdDireccion.Value = DetalleRequisicion.IdDireccion;
                SqlCmd.Parameters.Add(ParIdDireccion);

                SqlParameter ParJustificacion = new SqlParameter();
                ParJustificacion.ParameterName = "@justificacion";
                ParJustificacion.SqlDbType = SqlDbType.VarChar;
                ParJustificacion.Value = DetalleRequisicion.Justificacion;
                SqlCmd.Parameters.Add(ParJustificacion);

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

        // Método EditarStatusAlmacen
        public string EditarStatusAlmacen(DDetalleRequisicion DetalleRequisicion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_statusAlmacen_detalle_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDetalleRequisicion = new SqlParameter();
                ParIdDetalleRequisicion.ParameterName = "@id_detalle_requisicion";
                ParIdDetalleRequisicion.SqlDbType = SqlDbType.Int;
                ParIdDetalleRequisicion.Value = DetalleRequisicion.IdDetalleRequisicion;
                SqlCmd.Parameters.Add(ParIdDetalleRequisicion);

                SqlParameter ParStatusAlmacen = new SqlParameter();
                ParStatusAlmacen.ParameterName = "@status_almacen";
                ParStatusAlmacen.SqlDbType = SqlDbType.VarChar;
                ParStatusAlmacen.Size = 20;
                ParStatusAlmacen.Value = DetalleRequisicion.StatusAlmacen;
                SqlCmd.Parameters.Add(ParStatusAlmacen);

                SqlParameter ParFechaAlmacen = new SqlParameter();
                ParFechaAlmacen.ParameterName = "@fecha_almacen";
                ParFechaAlmacen.SqlDbType = SqlDbType.DateTime;
                ParFechaAlmacen.Value = DetalleRequisicion.FechaAlmacen;
                SqlCmd.Parameters.Add(ParFechaAlmacen);

                SqlParameter ParIdAlmacenero = new SqlParameter();
                ParIdAlmacenero.ParameterName = "@idalmacenero";
                ParIdAlmacenero.SqlDbType = SqlDbType.Int;
                ParIdAlmacenero.Value = DetalleRequisicion.IdAlmacenero;
                SqlCmd.Parameters.Add(ParIdAlmacenero);

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

        // Método EditarStatusCompra
        public string EditarStatusCompra(DDetalleRequisicion DetalleRequisicion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_statusCompra_detalle_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDetalleRequisicion = new SqlParameter();
                ParIdDetalleRequisicion.ParameterName = "@id_detalle_requisicion";
                ParIdDetalleRequisicion.SqlDbType = SqlDbType.Int;
                ParIdDetalleRequisicion.Value = DetalleRequisicion.IdDetalleRequisicion;
                SqlCmd.Parameters.Add(ParIdDetalleRequisicion);

                SqlParameter ParStatusCompra = new SqlParameter();
                ParStatusCompra.ParameterName = "@status_compra";
                ParStatusCompra.SqlDbType = SqlDbType.VarChar;
                ParStatusCompra.Size = 20;
                ParStatusCompra.Value = DetalleRequisicion.StatusCompra;
                SqlCmd.Parameters.Add(ParStatusCompra);

                SqlParameter ParFechaCompra = new SqlParameter();
                ParFechaCompra.ParameterName = "@fecha_compra";
                ParFechaCompra.SqlDbType = SqlDbType.DateTime;
                ParFechaCompra.Value = DetalleRequisicion.FechaCompra;
                SqlCmd.Parameters.Add(ParFechaCompra);

                SqlParameter ParIdCompra = new SqlParameter();
                ParIdCompra.ParameterName = "@idcompra";
                ParIdCompra.SqlDbType = SqlDbType.Int;
                ParIdCompra.Value = DetalleRequisicion.IdCompra;
                SqlCmd.Parameters.Add(ParIdCompra);

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

        // Método EditarStatusDireccion
        public string EditarStatusDireccion(DDetalleRequisicion DetalleRequisicion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_statusDireccion_detalle_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDetalleRequisicion = new SqlParameter();
                ParIdDetalleRequisicion.ParameterName = "@id_detalle_requisicion";
                ParIdDetalleRequisicion.SqlDbType = SqlDbType.Int;
                ParIdDetalleRequisicion.Value = DetalleRequisicion.IdDetalleRequisicion;
                SqlCmd.Parameters.Add(ParIdDetalleRequisicion);

                SqlParameter ParStatusDireccion = new SqlParameter();
                ParStatusDireccion.ParameterName = "@status_direccion";
                ParStatusDireccion.SqlDbType = SqlDbType.VarChar;
                ParStatusDireccion.Size = 20;
                ParStatusDireccion.Value = DetalleRequisicion.StatusDireccion;
                SqlCmd.Parameters.Add(ParStatusDireccion);

                SqlParameter ParFechaDireccion = new SqlParameter();
                ParFechaDireccion.ParameterName = "@fecha_direccion";
                ParFechaDireccion.SqlDbType = SqlDbType.DateTime;
                ParFechaDireccion.Value = DetalleRequisicion.FechaDireccion;
                SqlCmd.Parameters.Add(ParFechaDireccion);

                SqlParameter ParIdDireccion = new SqlParameter();
                ParIdDireccion.ParameterName = "@iddireccion";
                ParIdDireccion.SqlDbType = SqlDbType.Int;
                ParIdDireccion.Value = DetalleRequisicion.IdDireccion;
                SqlCmd.Parameters.Add(ParIdDireccion);

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
        public string Eliminar(DDetalleRequisicion DetalleRequisicion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_detalle_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDetalleRequisicion = new SqlParameter();
                ParIdDetalleRequisicion.ParameterName = "@id_detalle_requisicion";
                ParIdDetalleRequisicion.SqlDbType = SqlDbType.Int;
                ParIdDetalleRequisicion.Value = DetalleRequisicion.IdDetalleRequisicion;
                SqlCmd.Parameters.Add(ParIdDetalleRequisicion);

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
            DataTable DtResultado = new DataTable("detallerequisicion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalle_requisicion";
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

        //Método BuscarNumRequisicion
        public DataTable BuscarNumRequisicion(DDetalleRequisicion DetalleRequisicion)
        {
            DataTable DtResultado = new DataTable("detallerequisicion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_detalle_requisicion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = DetalleRequisicion.TextoBuscar;
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
    }
}
