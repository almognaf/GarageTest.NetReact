using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class GarageController : BaseApiController
    {
        private readonly GarageDataContext context;
        public GarageController(GarageDataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<GarageUser>>> GetGarageUsers(){
            return await this.context.GarageUsers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GarageUser>> GetGarageUser(Guid id){
            return await this.context.GarageUsers.FindAsync(id);
        }
    }
}