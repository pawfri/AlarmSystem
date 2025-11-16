using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystemLib;

public class SensorPIR : SensorBase
{
    public bool DetectMotion { get; set; }

    public SensorPIR(int id, string placement, SensorStatus status)
        : base(id, placement, status)
    {
    }

    public void Open()
    {
        DetectMotion = true;
        Trigger();
    }
    public void Close()
    {
        DetectMotion = false;
        Restore();
    }
}
