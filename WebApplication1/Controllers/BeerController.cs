using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {

        List<Beer> Beers = new List<Beer>()
        {
           new Beer() {Id=1 , Name = "Corona"},
           new Beer() {Id=2 , Name = "aguila"},
           new Beer() {Id=3 , Name = "budWeiser"},
        };


        [HttpGet]
        public ActionResult<Beer> Get(int Id) {

            var beer = Beers.Where(d => d.Id == Id).FirstOrDefault();
            if (beer == null) return NotFound();
            return beer;
        }
    }

    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
