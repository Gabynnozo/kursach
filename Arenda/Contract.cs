//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Arenda
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public int IdContract { get; set; }
        public int IdAgent { get; set; }
        public string TypeContract { get; set; }
        public System.DateTime DateOfContract { get; set; }
        public int IdObject { get; set; }
        public Nullable<double> Comision { get; set; }
        public int IdOrder { get; set; }
        public string IdContr { get; set; }
    
        public virtual Agent Agent { get; set; }
        public virtual Object Object { get; set; }
        public virtual Order Order { get; set; }
        public virtual TContract TContract { get; set; }
    }
}
