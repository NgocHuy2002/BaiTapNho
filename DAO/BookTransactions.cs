namespace BaiTapNho.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookTransactions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookTransactions()
        {
            Fines = new HashSet<Fines>();
        }

        [Key]
        public int TransactionID { get; set; }

        public int? BookID { get; set; }

        public int? BorrowerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TransactionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReturnDate { get; set; }

        public virtual Books Books { get; set; }

        public virtual Borrowers Borrowers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fines> Fines { get; set; }
    }
}
