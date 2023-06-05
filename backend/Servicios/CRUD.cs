using backend.Datos;
using log4net;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace backend.Servicios
{
    public class CRUD {
        protected static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected IDataContext DataContext;
        public IConfiguration config;
        public CRUD(IConfiguration config)
        {
            this.config = config;
            string stringConexion = config["BD:stringConexion"];
            string bd = config["BD:dbName"];
            DataContext = new MongoDbDataContext(stringConexion, bd);
            Log.Info("Se crea instancia del servicio de catálogo");
        }

        }
}
