using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NDetalleRequisicion
    {
        //Método Insertar que llama al método Insertar de la clase DDetalleRequisicion de la CapaDatos
        public static string Insertar(int requisionNum, decimal cantidad, string stock, string descripcion, string unidad, string statusalmacen, string statuscompra, string statusdireccion, DateTime fechaalmacen, DateTime fechacompra, DateTime fechadireccion, int idalmacenero, int idcompra, int iddireccion, string justificacion)
        {
            DDetalleRequisicion Obj = new DDetalleRequisicion();
            Obj.RequisicionNum = requisionNum;
            Obj.Cantidad = cantidad;
            Obj.Stock = stock;
            Obj.Descripcion = descripcion;
            Obj.Unidad = unidad;
            Obj.StatusAlmacen = statusalmacen;
            Obj.StatusCompra = statuscompra;
            Obj.StatusDireccion = statusdireccion;
            Obj.FechaAlmacen = fechaalmacen;
            Obj.FechaCompra = fechacompra;
            Obj.FechaDireccion = fechadireccion;
            Obj.IdAlmacenero = idalmacenero;
            Obj.IdCompra = idcompra;
            Obj.IdDireccion = iddireccion;
            Obj.Justificacion = justificacion;
            return Obj.Insertar(Obj);
        }

        //Método que llama al método Editar de la clase DDetalleRequisicion de la CapaDatos
        public static string Editar(int idDetalleRequisicion, int requisionNum, decimal cantidad, string stock, string descripcion, string unidad, string statusalmacen, string statuscompra, string statusdireccion, DateTime fechaalmacen, DateTime fechacompra, DateTime fechadireccion, int idalmacenero, int idcompra, int iddireccion, string justificacion)
        {
            DDetalleRequisicion Obj = new DDetalleRequisicion();
            Obj.IdDetalleRequisicion = idDetalleRequisicion;
            Obj.RequisicionNum = requisionNum;
            Obj.Cantidad = cantidad;
            Obj.Stock = stock;
            Obj.Descripcion = descripcion;
            Obj.Unidad = unidad;
            Obj.StatusAlmacen = statusalmacen;
            Obj.StatusCompra = statuscompra;
            Obj.StatusDireccion = statusdireccion;
            Obj.FechaAlmacen = fechaalmacen;
            Obj.FechaCompra = fechacompra;
            Obj.FechaDireccion = fechadireccion;
            Obj.IdAlmacenero = idalmacenero;
            Obj.IdCompra = idcompra;
            Obj.IdDireccion = iddireccion;
            Obj.Justificacion = justificacion;
            return Obj.Editar(Obj);
        }

        //Método que llama al método EditarStatusAlmacen de la clase DDetalleRequisicion de la CapaDatos
        public static string EditarStatusAlmacen(int idDetalleRequisicion, string statusalmacen, DateTime fechaalmacen, int idalmacenero)
        {
            DDetalleRequisicion Obj = new DDetalleRequisicion();
            Obj.IdDetalleRequisicion = idDetalleRequisicion;
            Obj.StatusAlmacen = statusalmacen;
            Obj.FechaAlmacen = fechaalmacen;
            Obj.IdAlmacenero = idalmacenero;
            return Obj.EditarStatusAlmacen(Obj);
        }

        //Método que llama al método EditarStatusCompra de la clase DDetalleRequisicion de la CapaDatos
        public static string EditarStatusCompra(int idDetalleRequisicion, string statuscompra, DateTime fechacompra, int idcompra)
        {
            DDetalleRequisicion Obj = new DDetalleRequisicion();
            Obj.IdDetalleRequisicion = idDetalleRequisicion;
            Obj.StatusCompra = statuscompra;
            Obj.FechaCompra = fechacompra;
            Obj.IdCompra = idcompra;
            return Obj.EditarStatusCompra(Obj);
        }

        //Método que llama al método EditarStatusDireccion de la clase DDetalleRequisicion de la CapaDatos
        public static string EditarStatusDireccion(int idDetalleRequisicion, string statusdireccion, DateTime fechadireccion, int iddireccion)
        {
            DDetalleRequisicion Obj = new DDetalleRequisicion();
            Obj.IdDetalleRequisicion = idDetalleRequisicion;
            Obj.StatusDireccion = statusdireccion;
            Obj.FechaDireccion = fechadireccion;
            Obj.IdDireccion = iddireccion;
            return Obj.EditarStatusDireccion(Obj);
        }

        //Método que llama al método Eliminar de la clase DDetalleRequisicion de la CapaDatos
        public static string Eliminar(int idDetalleRequisicion)
        {
            DDetalleRequisicion Obj = new DDetalleRequisicion();
            Obj.IdDetalleRequisicion = idDetalleRequisicion;
            return Obj.Eliminar(Obj);
        }

        //Método que llama al método Mostrar de la clase DDetalleRequisicion de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DDetalleRequisicion().Mostrar();
        }

        //Método BuscarRazon_Social que llama al método BuscarRequisicion de la clase DDetalleRequisicion de la CapaDatos
        public static DataTable BuscarNumRequisicion(string textobuscar)
        {
            DDetalleRequisicion Obj = new DDetalleRequisicion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNumRequisicion(Obj);
        }
    }
}
