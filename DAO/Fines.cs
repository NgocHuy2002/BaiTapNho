namespace BaiTapNho.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FineID { get; set; }

        public int? TransactionID { get; set; }

        public decimal? Amount { get; set; }

        public bool? Paid { get; set; }

        public virtual BookTransactions BookTransactions { get; set; }
    }
}
