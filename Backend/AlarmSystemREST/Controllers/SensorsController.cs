using Microsoft.AspNetCore.Mvc;
using AlarmSystemLib;
using AlarmSystemLib.Services.Repositories;
using AlarmSystemLib.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlarmSystemREST.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SensorsController : ControllerBase
{
    private SensorRepository _repo;

    public SensorsController(SensorRepository repo)
    {
        _repo = repo;
    }
    
    // GET: api/<SensorsController>
    [HttpGet]
    public IEnumerable<SensorBase> Get()
    {
        return _repo.GetAll();
    }

    // GET api/<SensorsController>/5
    [HttpGet("{id}")]
    public SensorBase? Get(int id)
    {
        return _repo.GetById(id);
    }

    // POST api/<SensorsController>
    [HttpPost]
    public SensorBase Post([FromBody] SensorBase value)
    {
        return _repo.Add(value);
    }

    // PUT api/<SensorsController>/5
    [HttpPut("{id}")]
    public SensorBase? Put(int id, [FromBody] SensorBase value)
    {
        return _repo.Update(id, value);
    }


    // DELETE api/<SensorsController>/5
    [HttpDelete("{id}")]
    public SensorBase? Delete(int id)
    {
        return _repo.Delete(id);
    }

}
