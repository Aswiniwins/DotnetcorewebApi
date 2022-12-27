using DotnetcorewebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetcorewebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookbyidsController : ControllerBase
    {
        List<Bookbyid> _obookbyids = new List<Bookbyid>()
        {
            new Bookbyid(){ Id=1,Name="Rich Dad Poor Dad",AuthorName="Robert Kiyosaki",Copiessold=5000},
            new Bookbyid(){ Id=2,Name="How beautiful she is",AuthorName="Rohit",Copiessold=6000},
            new Bookbyid(){ Id=3,Name="hello life",AuthorName="Ravi",Copiessold=7000},
            new Bookbyid(){ Id=4,Name="Byomkesh bakshi",AuthorName="Sameer",Copiessold=8000},
            new Bookbyid(){ Id=5,Name="Evolution",AuthorName="Ashneer",Copiessold=9000}
        };
        [HttpGet]
        public IActionResult Gets()
        {
            if (_obookbyids.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(_obookbyids);
        }
        [HttpGet("GetBooksbyid")]
        public IActionResult Get(int id)
        {
            var obookbyid = _obookbyids.SingleOrDefault(x => x.Id == id);
            if (obookbyid == null)
            {
                return NotFound("No Book record Found");
            }
            return Ok(obookbyid);
        }
        [HttpPost]
        public IActionResult save(Bookbyid obookbyid)
        {
            _obookbyids.Add(obookbyid);
                if (_obookbyids.Count==0)
            {
                return NotFound("No List Found");
            }
            return Ok(_obookbyids);
        }
        [HttpDelete]
        public IActionResult deleteBook(int id)
        {
            var obookbyid = _obookbyids.SingleOrDefault(x => x.Id == id);
            if (obookbyid == null)
            {
                return NotFound("No Book record Found");
            }
            _obookbyids.Remove(obookbyid);
            if (_obookbyids.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(_obookbyids);


        }
        

    }
}
