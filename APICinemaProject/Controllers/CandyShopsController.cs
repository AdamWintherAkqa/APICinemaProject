using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APICinemaProject.DAL.Database;
using APICinemaProject.DAL.Models;
using APICinemaProject.DAL.Repositories;

namespace APICinemaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandyShopsController : ControllerBase
    {
        private readonly ICandyShopRepository context;

        public CandyShopsController(ICandyShopRepository _context)
        {
            context = _context;
        }

        // GET: api/Actors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandyShop>>> GetActors()
        {
            try
            {
                List<CandyShop> result = await context.GetAllCandyShops(); // Ok kan typecast 99% af alt kode whoo!
                if (result == null)
                {
                    return StatusCode(500);
                }

                if (result.Count == 0)
                {
                    return NoContent();
                }

                else
                {
                    return Ok(result);
                }

            }
            catch (Exception ex)
            {
                return (ActionResult)StatusCode(500, ex);
            }
        }

        // GET: api/Actors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CandyShop>> GetActor(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            try
            {
                var candyShop = context.GetCandyShopById(id);

                if (candyShop == null)
                {
                    return NotFound();
                }

                return await candyShop;
            }
            catch (Exception ex)
            {
                return (ActionResult)BadRequest(ex.Message);
            }
        }

        // PUT: api/Actors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActor(int id, CandyShop candyShop)
        {
            try
            {
                if (id != candyShop.CandyShopID)
                    return BadRequest("ID Mismatch");

                var actorToUpdate = await context.GetCandyShopById(id);

                if (actorToUpdate == null)
                {
                    return NotFound($"Actor with ID = {id} not found");
                }

                var result = await context.UpdateCandyShop(candyShop);

                if (result != null)
                {
                    return Ok(candyShop);
                }
                else
                {
                    return BadRequest("Null i Repo");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST: api/Actors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CandyShop>> PostActor(Actor actor)
        {
            if (actor == null)
            {
                return BadRequest();
            }
            try
            {
                await context.CreateActor(actor);

                return actor;
            }
            catch (Exception ex)
            {
                return (ActionResult)BadRequest(ex.Message);
            }
        }

        // DELETE: api/Actors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActor(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            try
            {
                var response = await context.DeleteActorByID(id);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return NotFound(response);
                }

            }
            catch (Exception ex)
            {
                return (ActionResult)BadRequest(ex.Message);
            }
        }
    }
}
