using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WealthForgePro.Models;

namespace WealthForgePro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly WealthForgeContext _context;

        public AssetController(WealthForgeContext context)
        {
            _context = context;
        }

        // GET: api/Asset
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssetClass>>> GetAssetClass()
        {
            return await _context.AssetClass.ToListAsync();
        }

        // GET: api/Asset/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssetClass>> GetAssetClass(int id)
        {
            var assetClass = await _context.AssetClass.FindAsync(id);

            if (assetClass == null)
            {
                return NotFound();
            }

            return assetClass;
        }

        // PUT: api/Asset/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssetClass(int id, AssetClass assetClass)
        {
            if (id != assetClass.AssetClassID)
            {
                return BadRequest();
            }

            _context.Entry(assetClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetClassExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Asset
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AssetClass>> PostAssetClass(AssetClass assetClass)
        {
            _context.AssetClass.Add(assetClass);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssetClass", new { id = assetClass.AssetClassID }, assetClass);
        }

        // DELETE: api/Asset/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssetClass(int id)
        {
            var assetClass = await _context.AssetClass.FindAsync(id);
            if (assetClass == null)
            {
                return NotFound();
            }

            _context.AssetClass.Remove(assetClass);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssetClassExists(int id)
        {
            return _context.AssetClass.Any(e => e.AssetClassID == id);
        }
    }
}
