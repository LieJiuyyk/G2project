namespace G2_MVC_EF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            BuyCar = new HashSet<BuyCar>();
            Comment = new HashSet<Comment>();
        }

        [Key]
        public int Uid { get; set; }

        [StringLength(12)]
        public string UserAccount { get; set; }

        [StringLength(18)]
        public string UserPwd { get; set; }

        [StringLength(12)]
        public string Userphone { get; set; }

        [StringLength(10)]
        public string UserNickname { get; set; }

        [StringLength(50)]
        public string UserPicUrl { get; set; }

        [StringLength(10)]
        public string UserType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyCar> BuyCar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
