using System.Collections.Generic;
using System;

namespace Factory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.JoinEntities = new HashSet<Attendance>();
        }

        public int EngineerId { get; set; }
        public string EngineerName { get; set; }
        public Date HireDate { get; set; }

        public virtual ICollection<EngMach> JoinEntities { get;}
    }
}