using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Automapper.WebApi.DTOs;
using Automapper.WebApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Automapper.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IMapper _mapper;
        public DeveloperController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<IActionResult> Post(Developer developer)
        {
            var developerDtoMapped = _mapper.Map<DeveloperDTO>(developer);

            //Reverse Mapping 
            //return Ok(_mapper.Map<Developer>(developer));

            return Ok(developerDtoMapped);
        }
    }
}