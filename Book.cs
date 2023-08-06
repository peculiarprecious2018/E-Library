namespace E_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            BorrowingTransactions = new HashSet<BorrowingTransaction>();
        }

        public int BookID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Author { get; set; }

        public int? AvailableCopies { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateCreated { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowingTransaction> BorrowingTransactions { get; set; }
    }
}
