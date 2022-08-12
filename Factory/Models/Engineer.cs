using System.Collections.Generic;
using System;

namespace Factory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.JoinEntities = new HashSet<EngMach>();
        }

        public int EngineerId { get; set; }
        public string EngineerName { get; set; }
        public DateTime HireDate { get; set; }

        public virtual ICollection<EngMach> JoinEntities { get;}
    }
}