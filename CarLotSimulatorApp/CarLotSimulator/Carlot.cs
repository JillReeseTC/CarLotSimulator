﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car;


namespace CarLotSimulator
{
    public class Carlot
    {
        public Carlot() 
        { 
        
        }

        public List<Car> listcars { get; set; } = new List<Car>();
       


        public static void ListCars(listcars)
        {
            foreach (var item in listcars)
            {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                Car.MakeEngineNoise(item.EngineNoise);
                Car.MakeHonkNoise(item.HonkNoise);
                Console.WriteLine();
            }
        }

    }
}
