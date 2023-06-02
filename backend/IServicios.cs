using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    public interface IServicios
    {
        List<Cliente> GetClientes(string nombre);
        bool IniciarSesion(string userName, string password);
    }
}
