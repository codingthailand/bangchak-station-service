﻿using Microsoft.AspNetCore.Mvc;

namespace BangchakStationService.Controllers
{

    [Route("api")] // http://localhost:port/api
    [ApiController]
    public class HomeController : ControllerBase
    {


        [HttpGet]
        public ActionResult Index()
        {
            return Ok(new
            {
                message = "Station API Running..."
            });
        }
    }
}
