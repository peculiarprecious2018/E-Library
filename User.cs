namespace E_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            BorrowingTransactions = new HashSet<BorrowingTransaction>();
        }

        public int UserID { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowingTransaction> BorrowingTransactions { get; set; }
    }
}
