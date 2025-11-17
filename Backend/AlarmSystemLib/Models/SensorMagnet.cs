using AlarmSystemLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystemLib.Models;

public class SensorMagnet : SensorBase
{
    public bool IsOpen { get; set; }

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
