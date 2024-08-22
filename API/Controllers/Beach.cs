using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BeachController(MyWorldDbContext context) : ControllerBase
    {
        // private readonly MyWorldDbCotext _myWorldDbContext;
        // public Beach(MyWorldDbCotext myWorldDbContext)

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var users = context.Users.ToList();
            var beaches = await context.Beach.ToListAsync();

            return Ok(beaches);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Beach newBeach)
        {
            context.Beach.Add(newBeach);
            await context.SaveChangesAsync();
            return Ok(newBeach);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            //var users = context.Users.ToList();
            // var beachById = await context.Beach.FindAsync(id);
            var beachById = await context.Beach.Where(_ => _.Id == id).FirstOrDefaultAsync();
            return Ok(beachById);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Beach beachUpdate)
        {
            context.Beach.Update(beachUpdate);
            await context.SaveChangesAsync();
            return Ok(beachUpdate);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id){
            var beachToDelete = await context.Beach.FindAsync(id);
            if(beachToDelete == null)
            {
                return NotFound();
            }
            context.Beach.Remove(beachToDelete);
            await context.SaveChangesAsync();
            return Ok();
        }



    }
}