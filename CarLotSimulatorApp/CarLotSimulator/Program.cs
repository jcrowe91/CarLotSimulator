﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Car dodge = new Car();
            dodge.Year = 2001;
            dodge.Make = "Dodge";
            dodge.Make = "Ram 1500";
            dodge.EngineNoise = "Vroom!";
            dodge.HornNoise = "HONK!";
            dodge.IsDriveable = true;
            int dodge1 = Carlot.numOfCars(1);
            Console.WriteLine($"{dodge1}");

            Car ford = new Car();
            ford.Year = 1996;
            ford.Make = "Ford";
            ford.Make = "Ranger";
            ford.EngineNoise = "*Sounds of misfiring*!";
            ford.HornNoise = "honk.";
            ford.IsDriveable = true;
            int ford1 = Carlot.numOfCars(2);
            Console.WriteLine($"{ford1}");

            Car pt = new Car();
            pt.Year = 2001;
            pt.Make = "Dodge";
            pt.Make = "Ram 1500";
            pt.EngineNoise = "Vroom!";
            pt.HornNoise = "HONK!";
            pt.IsDriveable = true;
            int pt1 = Carlot.numOfCars(3);
            Console.WriteLine($"{pt1}");

            Console.ReadLine();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

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
