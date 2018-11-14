﻿using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlowOut.DAL
{
    public class InstrumentContext : DbContext
    {
        public InstrumentContext()
            : base("InstrumentContext")
        {

        }

        public DbSet<Client> Client { get; set; }
    }

}
