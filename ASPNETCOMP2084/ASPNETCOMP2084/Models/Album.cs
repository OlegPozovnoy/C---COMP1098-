namespace ASPNETCOMP2084.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Album
    {
        public int Id { get; set; }

        public int GenreId { get; set; }

        public int ArtistId { get; set; }
         
        [StringLength(64)]
        public string AlbumName { get; set; }

        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString ="{0:c}")]
        public decimal? price { get; set; }

        [StringLength(1024)]
        [Display(Name = "Album Cover")]
        public string AlbumArtistUrl { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
