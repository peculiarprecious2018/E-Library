namespace E_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BorrowingTransaction")]
    public partial class BorrowingTransaction
    {
        [Key]
        public int TransactionID { get; set; }

        public int? BookID { get; set; }

        public int? UserID { get; set; }

        public DateTime? BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCreated { get; set; }

        public virtual Book Book { get; set; }

        public virtual User User { get; set; }
    }
}
