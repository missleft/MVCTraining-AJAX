﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AJAXTask.Models;

namespace AJAXTask.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {}
        public DbSet<Province> Provinces { get; set; }
    }
}