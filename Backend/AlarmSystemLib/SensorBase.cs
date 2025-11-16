namespace AlarmSystemLib;

public abstract class SensorBase
{
    public int Id { get; set; }
    public string Placement { get; set; }
    public SensorStatus Status { get; set; }

    public SensorBase(int id, string placement, SensorStatus status)
    {
        Id = id;
        Placement = placement;
        Status = status;
    }

    public virtual void Restore()
    {
        Status = SensorStatus.Restore;
    }

    public virtual void Trigger()
    {
        Status = SensorStatus.Trigger;
    }
}
