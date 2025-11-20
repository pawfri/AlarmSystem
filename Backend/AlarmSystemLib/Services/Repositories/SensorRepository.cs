using AlarmSystemLib.Models;
using AlarmSystemLib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystemLib.Services.Repositories;

public class SensorRepository : ISensorRepository
{
    private readonly List<SensorBase> _sensors = new();
    private int _nextId = 1;

    public List<SensorBase> GetAll()
    {
        return _sensors;
    }

    public SensorBase? GetById(int id)
    {
        return _sensors.FirstOrDefault(s => s.Id == id);
    }

    public SensorBase Add(SensorBase sensor)
    {
        sensor.Id = _nextId++;
        _sensors.Add(sensor);
        return sensor;
    }

    public SensorBase? Update(SensorBase sensor)
    {
        var existing = GetById(sensor.Id);
        if (existing == null)
        {
            return null;
        }

        var index = _sensors.IndexOf(existing);
        _sensors[index] = sensor;
        return sensor;
    }

    public SensorBase? Delete(int id)
    {
        SensorBase? sensor = GetById(id);
        if (sensor != null)
        {
            _sensors.Remove(sensor);
        }
        return sensor;
    }

}
