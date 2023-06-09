﻿using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositoryProducto
    {
        IEnumerable<Producto> GetProducts();
        IEnumerable<Producto> GetByVendedor(int idVendedor);
        Producto GetProductoByID(int id);
        //IEnumerable<Producto> GetProductoByEstado(int idEstado);
    }
}