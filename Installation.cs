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
    class Installation
    {
        [Key]
        public int ID_Installation { get; set; }
        public int ID_Client { get; set; }
        public int ID_Car { get; set; }
        public int ID_Work { get; set; }
        public int ID_Part { get; set; }
        public int ID_Employee { get; set; }
        public int ID_Garage { get; set; }
    }
}
