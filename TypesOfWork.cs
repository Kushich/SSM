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
    class TypesOfWork
    {
        [Key]
        public int ID_Work { get; set; }
        public string Type { get; set; }
        public decimal Cost { get; set; }

    }
}
