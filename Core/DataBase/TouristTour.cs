//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class TouristTour
    {
        public int Id { get; set; }
        public Nullable<int> TouristId { get; set; }
        public Nullable<int> TourId { get; set; }
    
        public virtual Tour Tour { get; set; }
        public virtual Tourist Tourist { get; set; }
    }
}