using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CarLotSimulator
{
    public class Carlot
    {
        public Carlot() 
        { 
        
        }

        public List<Car> listcars { get; set; } = new List<Car>();
       


        public void ListCars(List<Car> listcars)
        {
            foreach (var item in listcars)
            {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                item.MakeEngineNoise(item.EngineNoise);
                item.MakeHonkNoise(item.HonkNoise);
                Console.WriteLine();
            }
        }

    }
}
