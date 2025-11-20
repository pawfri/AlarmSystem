using AlarmSystemLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystemLib.Models;

public class SensorMotion : SensorBase
{
    public bool IsMotionDetected { get; set; }

    public SensorMotion(int id, string placement, SensorStatus status)
        : base(id, placement, status)
    {
    }

    public void MotionDetected()
    {
        IsMotionDetected = true;
        Trigger();
    }
    public void MotionClear()
    {
        IsMotionDetected = false;
        Restore();
    }
}
