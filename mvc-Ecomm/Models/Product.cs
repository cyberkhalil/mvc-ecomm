namespace mvc_Ecomm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Picture { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        public virtual Category Category1 { get; set; }
    }
}
