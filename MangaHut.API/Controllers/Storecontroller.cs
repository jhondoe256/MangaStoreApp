using MangaHut.Models.ViewModels.Stores;
using MangaHut.Services.MangaServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace MangaHut.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Storecontroller : ControllerBase
    {
        private readonly IStoreService _storeService;

        public Storecontroller(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStores()
        {
            return Ok(await _storeService.GetStores());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetStores(int id)
        {
            var store = await _storeService.GetStore(id);
            if (store is null) return NotFound();
            return Ok(store);
        }

        [HttpPost]
        [Route("/store_location")]
        public async Task<IActionResult> PostStoreLocation(Store_location_Create model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _storeService.AddStore_Location(model))
            {
                return Ok("Store Created!");
            }
            return BadRequest("Store could not be created");
        }


        [HttpPut]
        public async Task<IActionResult> Put(StoreEdit model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _storeService.EditStore(model))
            {
                return Ok("Store Edited!");
            }
            return BadRequest("Store could not be edited");
        }

    }
}