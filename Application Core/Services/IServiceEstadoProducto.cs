using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Services
{
    public interface IServiceEstadoProducto
    {
        IEnumerable<EstadoProducto> GetEstadoProductos();
        EstadoProducto GetEstadoProductoByID(int id);
    }
}
