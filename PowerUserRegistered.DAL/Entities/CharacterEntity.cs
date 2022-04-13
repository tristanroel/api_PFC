using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerUserRegistered.DAL.Entities
{
    public class CharacterEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Pv { get; set; }
        public int Xp { get; set; }
        public int Level { get; set; }

        public int Attack1 { get; set; }
        public int Attack2 { get; set; }
        public int Attack3 { get; set; }
        public int Attack4 { get; set; }

        public string Face { get; set; }
        public string BackSprite { get; set; }
        public string FrontSprite { get; set; }
        public string FrontAttackSprite { get; set; }
        public string BackAttackSprite { get; set; }
        public string BackKnockBackSprite { get; set; }
        public string FrontKnockBackSprite { get; set; }
    }
}
