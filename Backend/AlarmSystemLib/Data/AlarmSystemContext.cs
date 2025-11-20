using AlarmSystemLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystemLib.Data;

public class AlarmSystemContext : DbContext
{
    public AlarmSystemContext(DbContextOptions<AlarmSystemContext> options) 
        : base(options)
    {
    }

    public DbSet<SensorBase> Sensors { get; set; }
    public DbSet<SensorMagnet> MangetSensors { get; set; }
    public DbSet<SensorMotion> MotionSensors { get; set; }
    public DbSet<SensorSmoke> SmokeSensors { get; set; }
}