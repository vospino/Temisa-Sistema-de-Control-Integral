using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NUsuario
    {
        //Método Insertar que llama al método Insertar de la clase DUsuario de la CapaDatos
        public static string Insertar(string usuario, string password, string nombre, string apellido, int departamento, bool activo)
        {
            DUsuario Obj = new DUsuario();
            Obj.Usuario= usuario;
            Obj.Password = password;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Departamento = departamento;
            Obj.Activo = activo;
            return Obj.Insertar(Obj);
        }

        //Método que llama al método Editar de la clase DUsuario de la CapaDatos
        public static string Editar(int idusuario, string usuario, string password, string nombre, string apellido, int departamento, bool activo)
        {
            DUsuario Obj = new DUsuario();
            Obj.IdUsuario = idusuario;
            Obj.Usuario = usuario;
            Obj.Password = password;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Departamento = departamento;
            Obj.Activo = activo;
            return Obj.Editar(Obj);
        }

        //Método que llama al método Eliminar de la clase DUsuario de la CapaDatos
        public static string Eliminar(int idusuario)
        {
            DUsuario Obj = new DUsuario();
            Obj.IdUsuario = idusuario;
            return Obj.Eliminar(Obj);
        }

        //Método que llama al método Mostrar de la clase DUsuario de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DUsuario().Mostrar();
        }

        //Método BuscarNombre que llama al método BuscarNombre de la clase DUsuario de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DUsuario Obj = new DUsuario();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        //Método BuscarApellido que llama al método BuscarApellido de la clase DUsuario de la CapaDatos
        public static DataTable BuscarApellido(string textobuscar)
        {
            DUsuario Obj = new DUsuario();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellido(Obj);
        }

        //Método BuscarId que llama al método BuscarApellido de la clase DUsuario de la CapaDatos
        public static DataTable BuscarId(string textobuscar)
        {
            DUsuario Obj = new DUsuario();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarId(Obj);
        }

        //Método Login
        public static DataTable Login(string usuario, string password)
        {
            DUsuario Obj = new DUsuario();
            Obj.Usuario = usuario;
            Obj.Password = password;
            return Obj.Login(Obj);
        }
    }
}
