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
    
    public partial class Tourist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tourist()
        {
            this.TouristTours = new HashSet<TouristTour>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string RegistrationAddress { get; set; }
        public string InternPassportNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Nullable<int> VisaAvailabilityId { get; set; }
    
        public virtual VisaAvailability VisaAvailability { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TouristTour> TouristTours { get; set; }
    }
}
