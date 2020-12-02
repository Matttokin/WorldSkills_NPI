﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldSkills.DataBase.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}