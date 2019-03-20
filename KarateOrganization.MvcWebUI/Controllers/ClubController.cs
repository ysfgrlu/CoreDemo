using KarateOrganization.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarateOrganization.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClubController:ControllerBase
    {
        IClubService _clubService;
        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }
        public IActionResult GetList()
        {
            var clubs = _clubService.GetAll();
            return Ok(clubs);
        }
        public IActionResult GetClubs()
        {
            var clubs = _clubService.GetClubs();
            return Ok(clubs);
        }
    }
}
