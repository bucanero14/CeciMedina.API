using AutoMapper;
using CeciMedina.API.Extensions;
using CeciMedina.API.Helpers;
using CeciMedina.API.Models;
using CeciMedina.Core.Models;
using CeciMedina.Core.Services;
using CeciMedina.Core.Tools;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CeciMedina.API.Controllers
{
    public class CategoriaController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Categoria> _categoriaSvc;

        public CategoriaController(IMapper mapper, IService<Categoria> categoriaSvc)
        {
            _mapper = mapper;
            _categoriaSvc = categoriaSvc;
        }

        [HttpGet]
        public async Task<ActionResult<PaginatedList<CategoriaModel>>> Get([FromQuery] PaginationParams pagination)
        {
            var list = await _categoriaSvc.GetAllAsync(pagination.PageNumber, pagination.PageSize);

            Response.AddPaginationHeader(list.PageIndex, list.PageSize, list.TotalCount, list.TotalPageCount);

            return _mapper.Map<PaginatedList<Categoria>, PaginatedList<CategoriaModel>>(list);
        }

        [HttpGet("{id}", Name = "GetCategoria")]
        public async Task<ActionResult<CategoriaModel>> Get(int id)
        {
            return _mapper.Map<Categoria, CategoriaModel>(await _categoriaSvc.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaModel>> Post([FromBody] CategoriaModel model)
        {
            var objectToInsert = _mapper.Map<CategoriaModel, Categoria>(model);

            await _categoriaSvc.AddAsync(objectToInsert);

            if (objectToInsert.Id != 0)
            {
                return CreatedAtRoute("GetCategoria", new {id = objectToInsert.Id}, model);
            }

            return BadRequest("Ocurrió un error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CategoriaModel model)
        {
            var objectFromDb = await _categoriaSvc.GetByIdAsync(id);
            if (objectFromDb is null)
            {
                return NotFound();
            }
            
            var objectToUpdate = _mapper.Map(model, objectFromDb);

            await _categoriaSvc.UpdateAsync(objectToUpdate);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var objectToDelete = await _categoriaSvc.GetByIdAsync(id);
            
            await _categoriaSvc.DeleteAsync(objectToDelete);

            return NoContent();
        }

    }
}
