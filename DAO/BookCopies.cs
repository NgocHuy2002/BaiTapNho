namespace BaiTapNho.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookCopies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CopyID { get; set; }

        public int? BookID { get; set; }

        public int? BranchID { get; set; }

        public int? NumberOfCopies { get; set; }

        public virtual Books Books { get; set; }

        public virtual LibraryBranches LibraryBranches { get; set; }
    }
}
