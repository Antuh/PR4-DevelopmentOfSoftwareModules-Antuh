//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAuthorizations.Module
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            this.Export = new HashSet<Export>();
            this.ExportMinerals = new HashSet<ExportMinerals>();
        }
    
        public int ID_Contract { get; set; }
        public Nullable<int> ID_TypesOfContracts { get; set; }
        public Nullable<int> ID_Company { get; set; }
        public string Name { get; set; }
        public System.DateTime SignatureDate { get; set; }
        public string GeneralQuantity { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual TypesOfContracts TypesOfContracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Export> Export { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportMinerals> ExportMinerals { get; set; }
    }
}
