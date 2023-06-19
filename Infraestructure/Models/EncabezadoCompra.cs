//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestructure.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EncabezadoCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EncabezadoCompra()
        {
            this.DetalleCompra = new HashSet<DetalleCompra>();
            this.Evaluacion = new HashSet<Evaluacion>();
        }
    
        public int IdCompra { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdDireccion { get; set; }
        public Nullable<int> IdMetodo { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> IdEstado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }
        public virtual Direccion Direccion { get; set; }
        public virtual EstadoCompra EstadoCompra { get; set; }
        public virtual MetodoPago MetodoPago { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluacion> Evaluacion { get; set; }
    }
}
