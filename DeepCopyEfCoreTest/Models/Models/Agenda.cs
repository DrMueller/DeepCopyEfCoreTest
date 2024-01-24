namespace DeepCopyEfCoreTest.Models.Models;

public class Agenda
{
    public Agenda()
    {
        Points = new HashSet<AgendaPoint>();
    }

    public long Id { get; set; }

    public ICollection<AgendaPoint> Points { get; set; }
}