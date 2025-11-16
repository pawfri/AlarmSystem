using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystemLib;

public class SensorMagnet : SensorBase
{
    public bool IsOpen { get; set; }

    public int Id { get; set; }
    public string Placement { get; set; }
    public SensorStatus Status { get; set; }

    public SensorMagnet(int id, string placement, SensorStatus status)
        : base(id, placement, status)
    {
    }

    public void Open()
    {
        IsOpen = true;
        Trigger();
    }
    public void Close()
    {
        IsOpen = false;
        Restore();
    }
}
