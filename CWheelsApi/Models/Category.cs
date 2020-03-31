﻿using System;
using System.Collections.Generic;

namespace CWheelsApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
