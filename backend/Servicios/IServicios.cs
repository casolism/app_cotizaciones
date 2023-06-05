using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Dominio;

namespace backend.Servicios
{
    public interface IServicios
    {
        List<Cliente> GetClientes(string nombre);
        bool IniciarSesion(string userName, string password);
    }
}
