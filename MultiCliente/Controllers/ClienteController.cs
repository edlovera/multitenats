using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MultiCliente.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MultiCliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IConfiguration Configuration { get; }

        public ClienteController(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromQuery] string empresaBD)
        {
            using DBContext Context = new DBContext(string.Format(Configuration.GetConnectionString("Default"), empresaBD));

            await Context.Database.MigrateAsync();
            await Context.DisposeAsync();

            DBMContext ContextMetadata = new DBMContext(string.Format(Configuration.GetConnectionString("Default"), "metadata"));
            ContextMetadata.Cliente.Add(new Models.Metadata.Cliente
            {
                Fecha = DateTime.Now,
                Nombre = empresaBD
                
            });

            await ContextMetadata.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put()
        {

            DBMContext ContextMetadata = new DBMContext(string.Format(Configuration.GetConnectionString("Default"), "metadata"));
            var clientes = await ContextMetadata.Cliente.ToListAsync();

            foreach(var i in clientes)
            {
                using DBContext Context = new DBContext(string.Format(Configuration.GetConnectionString("Default"), i.Nombre));

                await Context.Database.MigrateAsync();
                

                i.Fecha = DateTime.Now;
            }
   

            await ContextMetadata.SaveChangesAsync();

            return Ok();
        }
    }
}
