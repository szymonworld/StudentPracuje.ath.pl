﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracuj.Models
{
    public class JobCategories : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
