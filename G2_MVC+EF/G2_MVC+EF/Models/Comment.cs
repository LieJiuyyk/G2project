namespace G2_MVC_EF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        public int Pid { get; set; }

        public int? Uid { get; set; }

        public int? ComId { get; set; }

        [StringLength(500)]
        public string ComIdText { get; set; }

        public virtual Commodity Commodity { get; set; }

        public virtual User User { get; set; }
    }
}
