using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;
using LuckySpin.Services;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
         private readonly IRepository _repository;

        /***
         * Constructor - 
           //TODO: call for a IRepository object to be injected into the constructor
         **/
        public SpinnerController()
        {
            //TODO: save the DIJ Repository object into your instance variable

        }

        /***
         * Index Action
         **/
        [HttpGet]
        public IActionResult Index()
        {
                return View();
        }

        [HttpPost]
        public IActionResult Index(Player player)
        {
            return RedirectToAction("Spin", new {FirstName = player.FirstName, Luck=player.Luck});
        }
        /***
         * Spin Action
         **/  
               
        public IActionResult Spin(Player player)
        {
            //Create a new Spin with the player
            
            Spin spin = new Spin { Player = player };
            //TODO: Save a spin in the repository by uncommenting the line below
            //_repository.AddSpin(spin);
            

            return View("Spin", spin);
        }

        /***
         * ListSpins Action
         **/
        [HttpGet]
        public IActionResult LuckList()
        {
                //TODO: Swap out the line below with the commented line to pass the repository's Player Spins to the LuckList View
                //return RedirectToAction("Index");
                return View(_repository?.getSpins());
        }

    }
}

