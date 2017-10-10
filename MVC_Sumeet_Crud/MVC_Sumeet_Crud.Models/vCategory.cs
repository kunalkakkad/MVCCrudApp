namespace MVC_Sumeet_Crud.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vCategory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string CategoryName { get; set; }

        [StringLength(500)]
        public string CategoryDescription { get; set; }

        [StringLength(30)]
        public string CreatedDate { get; set; }

        public int? StatusId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
