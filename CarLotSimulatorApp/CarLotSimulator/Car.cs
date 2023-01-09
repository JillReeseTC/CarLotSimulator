using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
    //Default Constructor
    public Car()
    {
    }
        //Properties for Car
        public int? Year { get; set; }
        public string? Make { get; set; } 
        public string? Model { get; set; }
        public string? EngineNoise { get; set; }
        public string? HonkNoise { get; set; }
        public bool? IsDriveable { get; set; } = true;

        public static void MakeEngineNoise(string? EngineNoise)
        {
            Console.WriteLine($"The car goes {EngineNoise}");
        }

        public static void MakeHonkNoise(string? HonkNoise)
        {
            Console.WriteLine($"The car horn goes {HonkNoise}");
        }


    }
}
