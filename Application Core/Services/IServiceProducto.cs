using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Services
{
    public interface IServiceProducto
    {
        IEnumerable<Producto> GetProducts();
        Producto GetProductoByID(int id);
        IEnumerable<Producto> GetByVendedor(int idVendedor);

        //IEnumerable<Producto> GetProductoByEstado(int id);
    }
}
