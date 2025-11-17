using AlarmSystemLib.Models;

namespace AlarmSystemLib.Services.Interfaces;

public interface ISensorRepository
{
    SensorBase Add(SensorBase sensor);
    SensorBase? Delete(int id);
    List<SensorBase> GetAll();
    SensorBase? GetById(int id);
    SensorBase? Update(SensorBase sensor);
}