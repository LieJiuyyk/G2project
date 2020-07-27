namespace G2_MVC_EF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commodity")]
    public partial class Commodity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commodity()
        {
            BuyCar = new HashSet<BuyCar>();
            Comment = new HashSet<Comment>();
        }

        [Key]
        public int ComId { get; set; }

        [StringLength(100)]
        public string CName { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cprice { get; set; }

        [StringLength(50)]
        public string CpicUrl1 { get; set; }

        [StringLength(50)]
        public string CpicUrl2 { get; set; }

        [StringLength(50)]
        public string CpicUrl3 { get; set; }

        [StringLength(50)]
        public string CpicUrl4 { get; set; }

        [StringLength(50)]
        public string CpicUrl5 { get; set; }

        [StringLength(50)]
        public string CpicUrl6 { get; set; }

        public int? Bid { get; set; }

        public int? CateID { get; set; }

        public virtual Brand Brand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyCar> BuyCar { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
