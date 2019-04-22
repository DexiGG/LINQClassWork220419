using System;
using System.Collections.Generic;

namespace LINQ_class_work
{
    public class Weapon
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Damage { get; set; }
        public virtual ICollection<Hero>Heroes { get; set; }
    }
}