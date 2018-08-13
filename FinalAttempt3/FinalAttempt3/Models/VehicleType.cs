namespace FinalAttempt3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleType")]
    public partial class VehicleType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleType()
        {
            Models = new HashSet<Model>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal VehicleTypeId { get; set; }

        [Required]
        [StringLength(256)]
        [Display(Name ="Vehicle Type")]
        public string VehicleTypeName { get; set; }


        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy hh:mm:ss}")]
        public DateTime CreateDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy hh:mm:ss}")]
        public DateTime EditDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Model> Models { get; set; }
    }
}
