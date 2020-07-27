namespace G2_MVC_EF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BuyCar")]
    public partial class BuyCar
    {
        [Key]
        public int Bcid { get; set; }

        public int? Comid { get; set; }

        [StringLength(50)]
        public string BpicUrl1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Bprice { get; set; }

        public int? Uid { get; set; }

        [StringLength(100)]
        public string comName { get; set; }
        public virtual Commodity Commodity { get; set; }

        public virtual User User { get; set; }
    }
}
