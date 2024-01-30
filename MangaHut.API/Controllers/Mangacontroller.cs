using MangaHut.Models.ViewModels.Mangas;
using MangaHut.Services.MangaServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace MangaHut.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mangacontroller : ControllerBase
    {
        private readonly IMangaService _mangaService;

        public Mangacontroller(IMangaService mangaService)
        {
            _mangaService = mangaService;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var selectedManga = await _mangaService.GetManga(id);
            if (selectedManga is null) return NotFound();
            return Ok(selectedManga);
        }

        [HttpPost]
        public async Task<IActionResult> Post(MangaCreate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return (await _mangaService.AddManga(model)) ? Ok("Success") : BadRequest("Fail.");
        }

    }
}