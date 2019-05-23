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
    class Car
    {
        [Key]
        public int ID_Car { get; set; }
        public string Model { get; set; }
        public string RegisterSign { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
