using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHomeWork.Models;

namespace WebApplicationHomeWork.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DogList(Gender? dogGender, FurColor? dogFurColor )
        {
            var dogs = PopulateDog();
            if (dogGender.HasValue)
            {
                dogs = dogs.Where(x => x.DogGender == dogGender.Value).ToList();
                return View(dogs);
            }
            if (dogFurColor.HasValue)
            {
                dogs = dogs.Where(x => x.DogFurColor == dogFurColor.Value).ToList();
                return View(dogs);
            }
            return View(dogs);
        }

        public List<Dog> PopulateDog()
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog()
            {
                DogName = "Azorel",
                DogGender = Gender.Male,
                DogFurColor = FurColor.White
            });
            dogs.Add(new Dog()
            {
                DogName = "Rex",
                DogGender = Gender.Male,
                DogFurColor = FurColor.Yellow
            });
            dogs.Add(new Dog()
            {
                DogName = "Blanket",
                DogGender = Gender.Female,
                DogFurColor = FurColor.Black
            });
            return dogs;
        }
    }
}