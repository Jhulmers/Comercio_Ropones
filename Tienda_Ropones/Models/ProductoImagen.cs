//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tienda_Ropones.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductoImagen
    {
        public int ProductoImagenId { get; set; }
        public int ProductoId { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
