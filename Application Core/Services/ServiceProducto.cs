using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Services
{
    public class ServiceProducto : IServiceProducto
    {
        public Producto GetProductoByID(int id)
        {
            IRepositoryProducto repository = new RepositoryProducto();
            return repository.GetProductoByID(id);
        }

        public IEnumerable<Producto> GetProducts()
        {
            IRepositoryProducto repository = new RepositoryProducto();
            return repository.GetProducts();
        }

        public IEnumerable<Producto> GetByVendedor(int idVendedor)
        {
            IRepositoryProducto repository = new RepositoryProducto();
            return repository.GetByVendedor(idVendedor);
        }
        

        //public IEnumerable<Producto> GetProductoByEstado(int idEstado)
        //{
        //    IRepositoryProducto repository = new RepositoryProducto();
        //    return repository.GetProductoByEstado(idEstado);
        //}
    }
}


