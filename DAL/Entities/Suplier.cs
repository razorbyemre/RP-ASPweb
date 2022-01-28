namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Suplier")]
    public partial class Suplier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }
    }
}
