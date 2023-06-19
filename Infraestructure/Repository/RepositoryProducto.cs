using Infraestructure.Models;
using Infraestructure.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class RepositoryProducto : IRepositoryProducto
    {
        public IEnumerable<Producto> GetProducts()
        {
            IEnumerable<Producto> lista = null;
            try
            { 
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    lista = ctx.Producto.Include(x => x.EstadoProducto).ToList();
                }
                return lista;
            }
            catch (DbUpdateException dbEx)
            {
                string mensaje = "";
                Log.Error(dbEx, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw new Exception(mensaje);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw;
            }
        }


        public IEnumerable<Producto> GetByVendedor(int idVendedor)
        {
            IEnumerable<Producto> lista = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //Obtener libros por Autor e incluyendo la información del autor
                    lista = ctx.Producto.
                        Where(l => l.IdVendedor == 2)
                        .Include(l => l.Usuario).
                        Include(l => l.EstadoProducto).ToList();
                }
                return lista;
            }

            catch (DbUpdateException dbEx)
            {
                string mensaje = "";
                Log.Error(dbEx, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw new Exception(mensaje);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw;
            }
        }

        //public IEnumerable<Producto> GetProductoByEstado(int idEstado)
        //{
        //    IEnumerable<Producto> oProducto = null;
        //    try
        //    {
        //        using (MyContext ctx = new MyContext())
        //        {
        //            ctx.Configuration.LazyLoadingEnabled = false;
        //            //Obtener Productos por Autor e incluyendo la información del autor
        //            oProducto = ctx.Producto.
        //                Where(l => l.IdEstado == idEstado)
        //                .Include("EstadoProducto").
        //                ToList();

        //        }
        //        return oProducto;
        //    }

        //    catch (DbUpdateException dbEx)
        //    {
        //        string mensaje = "";
        //        Log.Error(dbEx, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
        //        throw new Exception(mensaje);
        //    }
        //    catch (Exception ex)
        //    {
        //        string mensaje = "";
        //        Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
        //        throw;
        //    }
        //}



        public Producto GetProductoByID(int id)
        {
            Producto oProducto = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //Obtener Producto por ID incluyendo el autor y todas sus categorías
                    oProducto = ctx.Producto.Find(id);
                    //oProducto = ctx.Producto.
                    //       Where(l => l.IdProducto == id)
                    //       .Include("EstadoProducto")
                    //       .Include("Categoria")
                    //       .FirstOrDefault();

                }
                return oProducto;
            }
            catch (DbUpdateException dbEx)
            {
                string mensaje = "";
                Log.Error(dbEx, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw new Exception(mensaje);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw;
            }
        }

        
    
    }
}