using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOtomotiv.Entity.Model.Entity
{
    public class Entity 
    {
        public Entity()
        {
        }

        public Entity(string name)
        {
            Name = name;
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [StringLength(100, MinimumLength =5)]
        public string? Description { get; set; } // nullable
        public DateTime CreateDate { get; set; }=DateTime.Now;
    }
}
