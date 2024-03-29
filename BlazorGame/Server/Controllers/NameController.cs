﻿using BlazorGame.Server.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorGame.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {

        private readonly INameGenerateService _NameGenerateService;
        public NameController(INameGenerateService NameGenerateService)
        {
            _NameGenerateService = NameGenerateService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
        var name = await  _NameGenerateService.GetARadomName();
            if(name!=null)
            return Ok(name);
            return BadRequest();
        }
    }
}
