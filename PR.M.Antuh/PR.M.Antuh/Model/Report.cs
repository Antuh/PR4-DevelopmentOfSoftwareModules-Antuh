//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR.M.Antuh.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report
    {
        public int ID_Report { get; set; }
        public int ID_Minerals { get; set; }
        public string Quantity { get; set; }
        public string Revenue { get; set; }
        public string Month { get; set; }
        public Nullable<int> ID_Staff { get; set; }
        public int Year { get; set; }
    
        public virtual Minerals Minerals { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
