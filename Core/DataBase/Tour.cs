//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            this.TouristTours = new HashSet<TouristTour>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> HotelId { get; set; }
        public System.DateTime DepartureDate { get; set; }
        public System.DateTime ArrivalDate { get; set; }
        public Nullable<decimal> Price { get; set; }
        public bool IsVisaNeeded { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> CityId { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TouristTour> TouristTours { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
    }
}
