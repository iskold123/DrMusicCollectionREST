﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrMusicCollection.Controllers
{

    // Azure link: http://musicservice.azurewebsites.net/api/musics/artist/
    //Azure link mads: http://drmusic.azurewebsites.net/api/musics

    [Route("api/[controller]")]
    [ApiController]
    public class MusicsController : ControllerBase
    {

        private static List<Music> _data = new List<Music>()
        {
            new Music("sådan der", "Tessa", 180, 2019),
            new Music("Ung Kniv", "Minds of 99", 175, 2018)
        };

        // type this URL for get method
        // http://localhost:51068/api/Musics
        // GET: api/<MusicsController>
        [HttpGet]
        public IEnumerable<Music> Get()
        {
            return _data;
        }

        [HttpGet]
        [Route("Artist/{substring}")]
        public IEnumerable<Music> GetFromSubstring(string substring)
        {
            return _data.FindAll(i => i.Artist.Contains(substring));
        }

        // POST api/<MusicsController>
        [HttpPost]
        public void Post([FromBody] Music value)
        {
            
            _data.Add(value);

        }

        //// GET api/<MusicsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}



        //// PUT api/<MusicsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MusicsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
