using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CeciMedina.API.Extensions;
using CeciMedina.API.Helpers;
using CeciMedina.API.Models;
using CeciMedina.Core.Extensions;
using CeciMedina.Core.Models;
using CeciMedina.Core.Services;
using CeciMedina.Core.Tools;
using Microsoft.AspNetCore.Mvc;

namespace CeciMedina.API.Controllers
{
    public class SucursalController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Sucursal> _sucursalSvc;
        
        public SucursalController(IMapper mapper, IService<Sucursal> sucursalSvc)
        {
            _mapper = mapper;
            _sucursalSvc = sucursalSvc;
        }

        [HttpGet]
        public async Task<ActionResult<PaginatedList<SucursalModel>>> Get([FromQuery] PaginationParams pagination)
        {
            var list = await _sucursalSvc.GetAllAsync(pagination.PageNumber, pagination.PageSize);
            
            Response.AddPaginationHeader(list.PageIndex, list.PageSize, list.TotalCount, list.TotalPageCount);

            return _mapper.Map<PaginatedList<Sucursal>, PaginatedList<SucursalModel>>(list);
        }

        [HttpGet("{id}", Name="GetSucursal")]
        public async Task<ActionResult<SucursalModel>> Get(int id)
        {
            return _mapper.Map<Sucursal, SucursalModel>(await _sucursalSvc.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<SucursalModel>> Post([FromBody] SucursalModel model)
        {
            var objectToInsert = _mapper.Map<SucursalModel, Sucursal>(model);

            await _sucursalSvc.AddAsync(objectToInsert);

            if (objectToInsert.Id != 0)
            {
                return CreatedAtRoute("GetSucursal", new {id = objectToInsert.Id}, model);
            }

            return BadRequest("Ocurrió un error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] SucursalModel model)
        {
            var objectFromDb = await _sucursalSvc.GetByIdAsync(id);
            if (objectFromDb is null)
            {
                return NotFound();
            }
            
            var objectToUpdate = _mapper.Map(model, objectFromDb);

            await _sucursalSvc.UpdateAsync(objectToUpdate);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var objectToDelete = await _sucursalSvc.GetByIdAsync(id);
            
            await _sucursalSvc.DeleteAsync(objectToDelete);

            return NoContent();
        }
    }
}