namespace AlarmSystemLib;

public abstract class AlarmBase
{
    public int Id { get; set; }
    public string Placement { get; set; }
    public AlarmStatus Status { get; set; }

    public AlarmBase(int id, string placement, AlarmStatus status)
    {
        Id = id;
        Placement = placement;
        Status = status;
    }

    public virtual void Disarm()
    {
        Status = AlarmStatus.Disarm;
    }

    public virtual void Arm()
    {
        Status = AlarmStatus.Arm;
    }

    public virtual void Trigger()
    {
        Status = AlarmStatus.Trigger;
    }
}
