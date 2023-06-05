using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Dominio
{
    public class Cliente
    {
        public string Empresa { get; set; }
        public Contacto Contacto { get; set; }
        public override string ToString()
        {
            return $"{Empresa}";
        }
    }
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
    }
}
