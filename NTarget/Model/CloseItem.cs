//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NTarget.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CloseItem
    {
        public int IdCloseItem { get; set; }
        public System.DateTime CloseDate { get; set; }
        public double PerformanceSum { get; set; }
        public int IdWorker { get; set; }
        public int IdServiceItem { get; set; }
    
        public virtual ServiceItem ServiceItem { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
