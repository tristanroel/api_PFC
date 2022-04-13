using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerUserRegistered.DAL.Entities
{
    public class CapacitieEntity
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public  int Damage { get; set; }
        public  string Description { get; set; }
    }
}
