//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GisDes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articulo()
        {
            this.IntegranteArticulo = new HashSet<IntegranteArticulo>();
            this.ArticuloAsociadoGrupoInv = new HashSet<ArticuloAsociadoGrupoInv>();
            this.ArticuloAsociadoSemilleroInv = new HashSet<ArticuloAsociadoSemilleroInv>();
        }
    
        public decimal Id { get; set; }
        public string Nombre { get; set; }
        public decimal Categoria { get; set; }
        public string Resumen { get; set; }
        public string Enlace { get; set; }
        public System.DateTime FechaPublicacion { get; set; }
        public string Tags { get; set; }
        public System.DateTime FechaUpdate { get; set; }
        public Nullable<decimal> Estado { get; set; }
    
        public virtual Categoria Categoria1 { get; set; }
        public virtual Estado Estado1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IntegranteArticulo> IntegranteArticulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticuloAsociadoGrupoInv> ArticuloAsociadoGrupoInv { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticuloAsociadoSemilleroInv> ArticuloAsociadoSemilleroInv { get; set; }
    }
}
