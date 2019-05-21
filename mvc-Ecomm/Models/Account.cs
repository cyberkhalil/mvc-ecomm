namespace mvc_Ecomm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Picture { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Column("Full Name")]
        [Required]
        [StringLength(150)]
        public string Full_Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public bool isAdmin { get; set; }
    }
}
