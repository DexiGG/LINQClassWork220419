using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_class_work
{
    public class Hero
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nickname { get; set; }
        public int Level { get; set; }
        public virtual Weapon Weapon { get; set; }
    }
}
