//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public Producto()
        {
            this.VentaDetalles = new HashSet<VentaDetalle>();
        }
    
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public System.DateTime FechaAlta { get; set; }
    
        public virtual ICollection<VentaDetalle> VentaDetalles { get; set; }
    }
}
