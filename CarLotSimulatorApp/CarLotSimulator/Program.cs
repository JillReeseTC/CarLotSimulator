using System;
using Microsoft.VisualBasic;



namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Carlot constructor
            var salesLot = new Carlot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var carOne= new Car();

            carOne.Year = 2022;
            carOne.Make = "Chevrolet";
            carOne.Model = "Suburban";
            carOne.HonkNoise = "Honk!";
            carOne.EngineNoise = "VROOM!";
            carOne.IsDriveable = true;

            salesLot.listcars.Add(carOne);

            var carTwo = new Car()
            {
                Year = 2020,
                Make = "Tesla",
                Model = "Roadster",
                HonkNoise = "Blaap!",
                EngineNoise = "(silence)",
                IsDriveable = true
            };

            salesLot.listcars.Add(carTwo);


            var carThree = new Car(2021, "Toyota", "Prius", "(silence)", "BEEP BEEP!", true);

            salesLot.listcars.Add(carThree);

            salesLot.ListCars(salesLot.listcars);

            

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
