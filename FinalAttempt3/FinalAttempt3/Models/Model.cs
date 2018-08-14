namespace FinalAttempt3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Model")]
    public partial class Model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Model()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        [Column(TypeName = "numeric")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Model")]
        [DisplayFormat(DataFormatString = "{0:F0}")]
        public decimal ModelId { get; set; }

        [Required]
        [Range(0, 10000, ErrorMessage = "EngineSize must be between 0 and 10000")]
        public double EngineSize { get; set; }

        [Required]
        [Range(0, 8, ErrorMessage = "NumberOfDoors must be between 0 and 8")]
        public int NumberOfDoors { get; set; }

        [Required]
        [StringLength(36)]
        public string Colour { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "Vehicle Type")]
        public decimal VehicleTypeId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime EditDate { get; set; }

        public virtual VehicleType VehicleType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
