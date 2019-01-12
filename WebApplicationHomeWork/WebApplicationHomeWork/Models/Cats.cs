using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationHomeWork.Models
{
    public class Cats
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public FurColor FurColor { get; set; }
    }

    public enum Gender { Female, Male}

    public enum FurColor { Black, White, Yellow}
}
