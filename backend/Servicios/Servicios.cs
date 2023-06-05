using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Dominio;

namespace backend.Servicios
{
    public class Servicios : IServicios
    {
        public List<Cliente> GetClientes(string nombre)
        {
            var list = new List<Cliente>();
            list.Add(new Cliente()
            {
                Empresa = "Plasess",
                Contacto = new Contacto()
                {
                    Nombre = "Jose",
                    Correo = "jose.re@plasess.com"
                }
            });
            list.Add(new Cliente()
            {
                Empresa = "Oxxo",
                Contacto = new Contacto()
                {
                    Nombre = "Jose",
                    Correo = "jose.re@plasess.com"
                }
            });
            list.Add(new Cliente()
            {
                Empresa = "Oxigenoytr",
                Contacto = new Contacto()
                {
                    Nombre = "Juan",
                    Correo = "juan.re@plasess.com"
                }
            });
            return list.FindAll(x => x.Empresa.ToUpper().Contains(nombre.ToUpper()));
        }

        public bool IniciarSesion(string userName, string password)
        {
            if (userName == "Admin" || password == "1234")
            {
                return true;
            }
            else
                return false;
        }
    }
}
