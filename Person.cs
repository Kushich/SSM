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
    class Person
    {
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Passport { get; set; }
        public int Telephone { get; set; }

    }
    class Client : Person
    {
        [Key]
        public int ID_Client { get; set; }
    }
    class Employee : Person
    {
        [Key]
        public int ID_Employee { get; set; }
    }
}
