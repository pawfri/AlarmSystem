using AlarmSystemLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystemLib.Models;

public class SensorSmoke : SensorBase
{
    public bool IsSmokeDetected { get; set; }

    public SensorSmoke(int id, string placement, SensorStatus status)
        : base(id, placement, status)
    {
    }

    public void SmokeDetected()
    {
        IsSmokeDetected = true;
        Trigger();
    }
    public void SmokeClear()
    {
        IsSmokeDetected = false;
        Restore();
    }
}
