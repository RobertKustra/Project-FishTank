﻿using FishTank.Domain.Common;
using FishTank.Domain.ValueObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Domain.Entities
{
    public class Fish  : AuditableEntity
    {
       
        public FishName FishName { get; set; }
        public ICollection<EatingsHabits> EatingsHabits { get; private set; } 
        public LivingEnvironments LivingEnvironment { get; set; }
    }
}
