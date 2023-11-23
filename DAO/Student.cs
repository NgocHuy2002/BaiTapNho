namespace BaiTapNho.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int StudentID { get; set; }

        public string Name { get; set; }

        [StringLength(100)]
        public string MSV { get; set; }

        public int? numberOfBook { get; set; }
    }
}
