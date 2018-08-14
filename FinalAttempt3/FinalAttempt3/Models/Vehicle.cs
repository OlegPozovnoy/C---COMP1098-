namespace FinalAttempt3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehicle")]
    public partial class Vehicle
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal VehicleId { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "Make")]
        public decimal MakeId { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "Model")]
        public decimal ModelId { get; set; }


        [Required]
        [Range(1800, 2018, ErrorMessage = "Year must be between 1800 and 2018")]
        public int Year { get; set; }

        [Required]
        [Range(100, 10000000, ErrorMessage = "Price must be between 100 and 10000000")]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [Range(100, 10000000, ErrorMessage = "Cost must be between 100 and 10000000")]
        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        public DateTime? SoldDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int isSold { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime EditDate { get; set; }

        public virtual Make Make { get; set; }

        public virtual Model Model { get; set; }
    }
}
