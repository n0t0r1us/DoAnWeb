namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        public int Quantity { get; set; }

        public int Price { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string BookID { get; set; }

        public virtual Book Book { get; set; }

        public virtual Order Order { get; set; }
    }
}
