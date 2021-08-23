using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test1.Models
{
    public class MovementRecord
    {
        [Key]
        public int ID { get; set; }
        public int UID { get; set; }
        [ForeignKey("UID")]
        public Users User { get; set; }
        public DateTime MoveDate { get; set; }
        public int MoveID { get; set; }
        [ForeignKey("MoveID")]
        public MoveType MoveType { get; set; }
    }
}
