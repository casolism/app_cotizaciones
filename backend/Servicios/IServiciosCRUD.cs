using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace backend.Servicios
{
    public interface IServiciosCRUD
    {
        IList<D> obtener<D>() where D : class, new();
        D guardar<D>(D elemento) where D : class, new();
        D actualizar<D>(D elemento) where D : class, new();
        IList<D> obtener<D>(Expression<Func<D, bool>> query) where D : class, new();
    }
}
