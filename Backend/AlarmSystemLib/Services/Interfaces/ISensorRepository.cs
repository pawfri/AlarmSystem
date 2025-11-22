using AlarmSystemLib.Models;

namespace AlarmSystemLib.Services.Interfaces;

public interface ISensorRepository
{
    List<SensorBase> GetAll();
    SensorBase? GetById(int id);
    SensorBase Add(SensorBase sensor);
    SensorBase? Update(int id, SensorBase sensor);
    SensorBase? Delete(int id);
}