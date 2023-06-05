using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace backend.Datos
{
    public class Criteria

    {

        public string propiedad { get; set; }
        public QueryOperator Operator { get; set; }
        public Object valor { get; set; }
        public bool IsDate { get; set; }
        public Criteria(string propiedad, QueryOperator Operator, Object valor, bool IsDate = false)
        {
            this.propiedad = propiedad;
            this.Operator = Operator;
            this.valor = valor;
            this.IsDate = IsDate;
        }


    }
}