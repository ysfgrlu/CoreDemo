using KarateOrganization.Business;
using System;
using System.Web.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KarateOrganization.MvcWebUI.Models;
using KarateOrganization.Entities;

namespace KarateOrganization.MvcWebUI
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AthleteController:ControllerBase
    {
        IAthleteService _athleteService;
        public AthleteController(IAthleteService athleteService)
        {
            _athleteService = athleteService;
        }

        public IActionResult GetList()
        {
            var athletes = _athleteService.GetAll();
            /*AthleteListViewModel model = new AthleteListViewModel
            {
                Athletes = athletes
            };*/
            return Ok(athletes);
        }

        public IActionResult Save(Athlete athlete) {
            if (athlete.Id >= 1)
            {
                _athleteService.Update(athlete);
            }
            else {
                _athleteService.Add(athlete);
            }
            return Ok(_athleteService.SaveAll());
        }

        public IActionResult Get(int Id) {
            var athlete = _athleteService.GetAthleteById(Id);
            if (athlete != null) {
                return Ok(athlete);
             }
            else {
                return BadRequest();
            }
        }
    }
}
