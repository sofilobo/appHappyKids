using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infraestructure.Models
{
    internal partial class EstadoProductoMetadata
    {
        public int IdEstado { get; set; }

        [Display(Name = "Estado del producto")]
        public string Descripcion { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }

    }



    internal partial class ProductoMetadata
    {
        public int IdProducto { get; set; }
        [Display(Name = "Nombre del producto")]
        public string Nombre { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> IdEstado { get; set; }

        public Nullable<int> IdVendedor { get; set; }

        [Display(Name = "Detalle del producto")]
        public string Descripcion { get; set; }

        [Display(Name = "Cantidad disponible")]
        public Nullable<int> Cantidad { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }

        [Display(Name = "Estado del producto")]
        public virtual EstadoProducto EstadoProducto { get; set; }
        [Display(Name = "Imágenes del producto")]
        public virtual ICollection<ImagenProducto> ImagenProducto { get; set; }
        public virtual ICollection<Pregunta> Pregunta { get; set; }
        [Display(Name = "Proveedor")]
        public virtual Usuario Usuario { get; set; }
        [Display(Name = "Categorías")]
        public virtual ICollection<Categoria> Categoria { get; set; }

    }
}
