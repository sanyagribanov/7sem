//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfGlazkiSave
{
    using System;
    using System.Collections.Generic;
    
    public partial class agents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public agents()
        {
            this.productsale = new HashSet<productsale>();
            this.product_agent = new HashSet<product_agent>();
        }
    
        public int Id { get; set; }
        public string type_agent { get; set; }
        public string email_agent { get; set; }
        public string phone_agent { get; set; }
        public string logo_agent { get; set; }
        public string uradress_agent { get; set; }
        public string priority { get; set; }
        public string director { get; set; }
        public long INN { get; set; }
        public int KPP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productsale> productsale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product_agent> product_agent { get; set; }
    }
}