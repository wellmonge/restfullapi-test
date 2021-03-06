﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using restfullapi.Dao;
using restfullapi.Models;

namespace restfullapi.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        
        [HttpGet("{id}")]
        public Client ClientById([FromServices]ClientDao clientDao, long id)
        {
            return clientDao.ClientById(id);
        }

        [HttpGet("AllClients")]        
        public IList<Client> AllClients([FromServices]ClientDao clientDao)
        {
            return clientDao.AllClients();
        }


        [HttpPost]
        public JsonResult Post([FromServices]ClientDao clientDao, [FromBody]Client value)
        {
            var teste = value;
            clientDao.CreateClient(value);

            var res = Json(new { success = value });
            return res;

        }

        [HttpPut("{id}")]

        public JsonResult Put([FromServices]ClientDao clientDao, int id, [FromBody]Client value)
        {

            clientDao.UpdateClient(id, value);

            var res = Json(new { success = true });
            return res;
        }

        [HttpDelete("{id}")]
        public JsonResult Delete([FromServices]ClientDao clientDao, int id)
        {
            clientDao.DeleteClient(id);

            var res = Json(new { success = true });
            return res;
        }

    }
}
