using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace backend.Servicios
{
    public class ServiciosCRUD : CRUD, IServiciosCRUD
    {
        public ServiciosCRUD(IConfiguration config) : base(config)
        {
        }

        public D guardar<D>(D elemento) where D : class, new()
        {
            try
            {
                DataContext.Save<D>(elemento);
                return elemento;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }
        public D actualizar<D>(D elemento) where D : class, new()
        {
            try
            {
                DataContext.Update<D>(elemento);
                return elemento;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        public IList<D> obtener<D>() where D : class, new()
        {
            try
            {
                return DataContext.GetAll<D>();
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        public IList<D> obtener<D>(Expression<Func<D, bool>> query) where D : class, new()
        {
            try
            {
                return DataContext.Get<D>(query);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }
    }
}
