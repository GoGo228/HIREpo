//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISharpConvertor.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbOperationDetails
    {
        public int cId { get; set; }
        public int cType { get; set; }
        public string cParams { get; set; }
        public int cIdOperation { get; set; }
    
        public virtual tbOperation tbOperation { get; set; }
    }
}
