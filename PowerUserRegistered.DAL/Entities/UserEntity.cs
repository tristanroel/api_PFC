﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerUserRegistered.DAL.Entities
{
    public class UserEntity
    {
        public  int Id { get; set; }
        public string Pseudo { get; set; }
        public string Email { get; set; }
        public int PassWord { get; set; }

    }
}
