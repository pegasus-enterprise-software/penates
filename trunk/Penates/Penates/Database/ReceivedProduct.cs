//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Penates.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReceivedProduct
    {
        public long IDOrder { get; set; }
        public long IDBox { get; set; }
        public int Quantity { get; set; }
    
        public virtual Box Box { get; set; }
        public virtual Reception Reception1 { get; set; }
    }
}