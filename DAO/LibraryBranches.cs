namespace BaiTapNho.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LibraryBranches
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LibraryBranches()
        {
            BookCopies = new HashSet<BookCopies>();
            Books = new HashSet<Books>();
        }

        [Key]
        public int BranchID { get; set; }

        public string BranchName { get; set; }

        [StringLength(255)]
        public string Location { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookCopies> BookCopies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Books> Books { get; set; }
    }
}
