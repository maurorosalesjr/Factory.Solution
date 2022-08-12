namespace Factory.Models
{
  public class EngMach
    {       
        public int EngMachId { get; set; }
        public int EngineerId { get; set; }
        public int MachineId { get; set; }
        public virtual Engineer Engineer { get; set; }
        public virtual Machine Machine { get; set; }
    }
}