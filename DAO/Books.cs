namespace BaiTapNho.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            BookCopies = new HashSet<BookCopies>();
            BookTransactions = new HashSet<BookTransactions>();
        }

        [Key]
        public int BookID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(50)]
        public string ISBN { get; set; }

        public int? PublicationYear { get; set; }

        public int? AuthorID { get; set; }

        [StringLength(50)]
        public string Genre { get; set; }

        public int? NumberOfCopy { get; set; }

        public int BranchID { get; set; }

        public virtual Authors Authors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookCopies> BookCopies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookTransactions> BookTransactions { get; set; }

        public virtual LibraryBranches LibraryBranches { get; set; }
    }
}
