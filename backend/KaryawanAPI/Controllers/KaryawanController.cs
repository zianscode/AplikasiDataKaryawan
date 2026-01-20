using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KaryawanAPI.Data;
using KaryawanAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaryawanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KaryawanController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public KaryawanController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Karyawan>>> GetKaryawans()
        {
            return await _context.Karyawans.ToListAsync();
        }

        [HttpGet("{nik}")]
        public async Task<ActionResult<Karyawan>> GetKaryawan(string nik)
        {
            var karyawan = await _context.Karyawans.FindAsync(nik);

            if (karyawan == null)
            {
                return NotFound();
            }

            return karyawan;
        }

        [HttpPost]
        public async Task<ActionResult<Karyawan>> PostKaryawan(Karyawan karyawan)
        {
            if (KaryawanExists(karyawan.NIK))
            {
                return Conflict(new { message = "NIK sudah terdaftar" });
            }

            _context.Karyawans.Add(karyawan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKaryawan", new { nik = karyawan.NIK }, karyawan);
        }

        [HttpPut("{nik}")]
        public async Task<IActionResult> PutKaryawan(string nik, Karyawan karyawan)
        {
            if (nik != karyawan.NIK)
            {
                return BadRequest();
            }

            _context.Entry(karyawan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KaryawanExists(nik))
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

        [HttpDelete("{nik}")]
        public async Task<IActionResult> DeleteKaryawan(string nik)
        {
            var karyawan = await _context.Karyawans.FindAsync(nik);
            if (karyawan == null)
            {
                return NotFound();
            }

            _context.Karyawans.Remove(karyawan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KaryawanExists(string nik)
        {
            return _context.Karyawans.Any(e => e.NIK == nik);
        }
    }
}