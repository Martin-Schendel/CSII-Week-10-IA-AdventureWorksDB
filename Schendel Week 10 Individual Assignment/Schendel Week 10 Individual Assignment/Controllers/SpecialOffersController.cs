﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schendel_Week_10_Individual_Assignment.Data;
using Schendel_Week_10_Individual_Assignment.Models;

namespace Schendel_Week_10_Individual_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialOffersController : ControllerBase
    {
        private readonly Adventureworks2019Context _context;

        public SpecialOffersController(Adventureworks2019Context context)
        {
            _context = context;
        }

        // GET: api/SpecialOffers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpecialOffer>>> GetSpecialOffers()
        {
            return await _context.SpecialOffers.ToListAsync();
        }

        // GET: api/SpecialOffers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SpecialOffer>> GetSpecialOffer(int id)
        {
            var specialOffer = await _context.SpecialOffers.FindAsync(id);

            if (specialOffer == null)
            {
                return NotFound();
            }

            return specialOffer;
        }

        // PUT: api/SpecialOffers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpecialOffer(int id, SpecialOffer specialOffer)
        {
            if (id != specialOffer.SpecialOfferId)
            {
                return BadRequest();
            }

            _context.Entry(specialOffer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecialOfferExists(id))
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

        // POST: api/SpecialOffers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SpecialOffer>> PostSpecialOffer(SpecialOffer specialOffer)
        {
            _context.SpecialOffers.Add(specialOffer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpecialOffer", new { id = specialOffer.SpecialOfferId }, specialOffer);
        }

        // DELETE: api/SpecialOffers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpecialOffer(int id)
        {
            var specialOffer = await _context.SpecialOffers.FindAsync(id);
            if (specialOffer == null)
            {
                return NotFound();
            }

            _context.SpecialOffers.Remove(specialOffer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SpecialOfferExists(int id)
        {
            return _context.SpecialOffers.Any(e => e.SpecialOfferId == id);
        }
    }
}
