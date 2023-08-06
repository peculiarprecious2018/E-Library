namespace E_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Librarian")]
    public partial class Librarian
    {
        public int LibrarianID { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(20)]
        public string PhoneNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateCreated { get; set; }
    }
}
