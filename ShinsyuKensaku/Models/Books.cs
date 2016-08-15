namespace ShinsyuKensaku.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id { get; set; }

        public int? seq { get; set; }

        [StringLength(100)]
        public string title { get; set; }

        [StringLength(200)]
        public string heading { get; set; }

        public string body { get; set; }

        [StringLength(100)]
        public string link { get; set; }

        public int? division { get; set; }
    }
}
