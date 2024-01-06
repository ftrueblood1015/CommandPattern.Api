using Azure;
using CommandPattern.Domain.Entities;
using CommandPattern.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class ControllerBase<TEntity, TService> : ControllerBase
        where TEntity : class, IEntityBase
        where TService : class, IEntityServiceBase<TEntity>
    {
        protected TService Service { get; private set; }

        public ControllerBase(TService service)
        {
            Service = service;
        }

        [HttpPost]
        public virtual ActionResult<TEntity> Add([FromBody] TEntity entity)
        {
            var response = Service.Add(entity);
            return CreatedAtAction(nameof(Add), response);
        }

        [HttpDelete("{id}")]
        public virtual ActionResult Delete(long id)
        {
            var result = Service.DeleteById(id);
            return result ? Ok() : BadRequest();
        }

        [HttpGet]
        public virtual ActionResult<IEnumerable<TEntity>> GetAll()
        {
            var result = Service.GetAll();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public virtual ActionResult<TEntity> GetEntity(long id)
        {
            var result = Service.GetById(id);
            if (result == null)
            {
                return NotFound(id);
            }
            return Ok(result);
        }

        [HttpPut]
        public virtual ActionResult<TEntity> Update([FromBody] TEntity entity)
        {
            var result = Service.Update(entity);
            return CreatedAtAction(nameof(Update), result);
        }

    }
}
