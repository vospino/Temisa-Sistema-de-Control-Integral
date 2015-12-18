using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NDepartamento
    {
        //Método Insertar que llama al método Insertar de la clase DDepartamento de la CapaDatos
        public static string Insertar(string nombre, string descripcion)
        {
            DDepartamento Obj = new DDepartamento();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //Método que llama al método Editar de la clase DDepartamento de la CapaDatos
        public static string Editar(int iddepartamento, string nombre, string descripcion)
        {
            DDepartamento Obj = new DDepartamento();
            Obj.IdDepartamento = iddepartamento;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        //Método que llama al método Eliminar de la clase DDepartamento de la CapaDatos
        public static string Eliminar(int iddepartamento)
        {
            DDepartamento Obj = new DDepartamento();
            Obj.IdDepartamento = iddepartamento;
            return Obj.Eliminar(Obj);
        }

        //Método que llama al método Mostrar de la clase DDepartamento de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DDepartamento().Mostrar();
        }

        //Método BuscarNombre que llama al método BuscarNombre de la clase DDepartamento de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DDepartamento Obj = new DDepartamento();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
