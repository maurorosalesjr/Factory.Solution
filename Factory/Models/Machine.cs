using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
    {
        public Machine()
        {
            this.JoinEntities = new HashSet<EngMach>();
        }

        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string Certification { get; set; }
        public virtual ICollection<EngMach> JoinEntities { get; set; }
    }
}