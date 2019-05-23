using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Service_Station_Manager
{
    class Part
    {
        [Key]
        public int ID_Part { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}
