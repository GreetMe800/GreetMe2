﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetMe_DataAccess.Model
{
    public partial class Component
    {
        public Component()
        {
            ComponentPositions = new HashSet<ComponentPosition>();
        }

        public int Id { get; set; }
        public string ComponentName { get; set; } = null!;

        public virtual ICollection<ComponentPosition> ComponentPositions { get; set; }
    }
}
