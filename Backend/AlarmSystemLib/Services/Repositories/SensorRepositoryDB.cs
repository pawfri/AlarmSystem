using AlarmSystemLib.Data;
using AlarmSystemLib.Models;
using AlarmSystemLib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystemLib.Services.Repositories;

public class SensorRepositoryDB : ISensorRepository
{
    private readonly AlarmSystemContext _context;

    public SensorRepositoryDB(AlarmSystemContext context)
    {
        _context = context;
    }

    public List<SensorBase> GetAll()
    {
        return _context.Sensors.ToList();
    }

    public SensorBase? GetById(int id)
    {
        return _context.Sensors.Find(id);
    }
    public SensorBase Add(SensorBase sensor)
    {
        _context.Sensors.Add(sensor);
        _context.SaveChanges();
        return sensor;
    }

    public SensorBase? Update(SensorBase sensor)
    {
        var existing = _context.Sensors.Find(sensor.Id);
        if (existing == null)
        {
            return null;
        }

        _context.Sensors.Update(sensor);
        _context.SaveChanges();
        return sensor;
    }

    public SensorBase? Delete(int id)
    {
        var sensor = GetById(id);
        if (sensor != null)
        {
            _context.Sensors.Remove(sensor);
            _context.SaveChanges();
        }
        return sensor;
    }
}
