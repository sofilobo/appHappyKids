using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Services
{
    public class ServiceEstadoProducto : IServiceEstadoProducto
    {
        public EstadoProducto GetEstadoProductoByID(int id)
        {
            IRepositoryEstadoProducto repository = new RepositoryEstadoProducto();
            return repository.GetEstadoProductoByID(id);
        }

        public IEnumerable<EstadoProducto> GetEstadoProductos()
        {
            IRepositoryEstadoProducto repository = new RepositoryEstadoProducto();
            return repository.GetEstadoProductos();
        }

       
    }
}

