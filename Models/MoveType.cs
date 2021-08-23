using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test1.Models
{
    public class MoveType
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
    }
}
