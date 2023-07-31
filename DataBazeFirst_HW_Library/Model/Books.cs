namespace DataBazeFirst_HW_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int AmountPages { get; set; }

        public int? Author_Id { get; set; }

        public int? Category_Id { get; set; }

        public int? ProductionHouse_Id { get; set; }

        public virtual Authors Authors { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual ProductionHouses ProductionHouses { get; set; }

        public override string ToString()
        {
            return $"{Name}  {AmountPages} ";
        }
    }
}
