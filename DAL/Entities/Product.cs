namespace DAL.Entities
{
    using MongoDB.Bson.Serialization.Attributes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [BsonIgnoreExtraElements] // bu attribute olmadan id uyusmazlik hatasi aliyoruz. 
    [Table("Product")]
    public partial class Product
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SuplierID { get; set; }

        public int? UnitPrice { get; set; }

        public int? Amount { get; set; }
    }
}
