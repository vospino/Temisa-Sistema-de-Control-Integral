using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NRequisicion
    {
        //Método Insertar que llama al método Insertar de la clase DRequisicion de la CapaDatos
        public static string Insertar(int idproduccion, string caracter, DateTime fechaproduccion, string ordentrabajo)
        {
            DRequisicion Obj = new DRequisicion();
            Obj.IdProduccion = idproduccion;
            Obj.Caracter = caracter;
            Obj.FechaProduccion = fechaproduccion;
            Obj.OrdenTrabajo = ordentrabajo;
            return Obj.Insertar(Obj);
        }

        //Método que llama al método Editar de la clase DRequisicion de la CapaDatos
        public static string Editar(int idrequisicion, int idproduccion, string caracter, DateTime fechaproduccion, string ordentrabajo)
        {
            DRequisicion Obj = new DRequisicion();
            Obj.IdRequisicion = idrequisicion;
            Obj.IdProduccion = idproduccion;
            Obj.Caracter = caracter;
            Obj.FechaProduccion = fechaproduccion;
            Obj.OrdenTrabajo = ordentrabajo;
            return Obj.Insertar(Obj);
        }

        //Método que llama al método Eliminar de la clase DRequisicion de la CapaDatos
        public static string Eliminar(int idrequisicion)
        {
            DRequisicion Obj = new DRequisicion();
            Obj.IdRequisicion = idrequisicion;
            return Obj.Eliminar(Obj);
        }

        //Método que llama al método Mostrar de la clase DRequisicion de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DRequisicion().Mostrar();
        }

        //Método BuscarRequisicion que llama al método BuscarRequisicion de la clase DRequisicion de la CapaDatos
        public static DataTable BuscarRequisicion(string textobuscar)
        {
            DRequisicion Obj = new DRequisicion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarRequisicion(Obj);
        }

        //Método BuscarIdSolicitante que llama al método BuscarIdSolicitante de la clase DRequisicion de la CapaDatos
        public static DataTable BuscarIdSolicitante(string textobuscar)
        {
            DRequisicion Obj = new DRequisicion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarIdSolicitante(Obj);
        }

        //Método BuscarOrdenTrabajo que llama al método BuscarOrdenTrabajo de la clase DRequisicion de la CapaDatos
        public static DataTable BuscarOrdenTrabajo(string textobuscar)
        {
            DRequisicion Obj = new DRequisicion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarOrdenTrabajo(Obj);
        }

        //Método BuscarFechaSolicitud que llama al método BuscarFechaSolicitud de la clase DRequisicion de la CapaDatos
        public static DataTable BuscarFechaSolicitud(string textobuscar, string textobuscar1)
        {
            DRequisicion Obj = new DRequisicion();
            Obj.TextoBuscar = textobuscar;
            Obj.TextoBuscar1 = textobuscar1;
            return Obj.BuscarFechaSolicitud(Obj);
        }

        //Método que llama al método Mostrar de la clase DRequisicion de la CapaDatos
        public static DataTable ObtenerId()
        {
            return new DRequisicion().ObtenerId();
        }
    }
}
