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
        //private readonly ICandyShopRepository context;

        //public CandyShopsController(ICandyShopRepository _context)
        //{
        //    context = _context;
        //}

        //// GET: api/CandyShops
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<CandyShop>>> GetcandyShops()
        //{
        //    return await _context.candyShops.ToListAsync();
        //}

        //// GET: api/CandyShops/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<CandyShop>> GetCandyShop(int id)
        //{
        //    var candyShop = await _context.candyShops.FindAsync(id);

        //    if (candyShop == null)
        //    {
        //        return NotFound();
        //    }

        //    return candyShop;
        //}

        //// PUT: api/CandyShops/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCandyShop(int id, CandyShop candyShop)
        //{
        //    if (id != candyShop.CandyID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(candyShop).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CandyShopExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/CandyShops
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<CandyShop>> PostCandyShop(CandyShop candyShop)
        //{
        //    _context.candyShops.Add(candyShop);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCandyShop", new { id = candyShop.CandyID }, candyShop);
        //}

        //// DELETE: api/CandyShops/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCandyShop(int id)
        //{
        //    var candyShop = await _context.candyShops.FindAsync(id);
        //    if (candyShop == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.candyShops.Remove(candyShop);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool CandyShopExists(int id)
        //{
        //    return _context.candyShops.Any(e => e.CandyID == id);
        //}
    }
}
