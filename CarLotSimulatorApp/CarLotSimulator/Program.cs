using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car(2019, "Honda", "Accord", "hum", "beep", true);
            
            Console.WriteLine($"You have {CarLot.numberOfCars} cars on your lot.");
            
            Car car2 = new Car();
            car2.Year = 1974;
            car2.Make = "Chevrolet";
            car2.Model = "C10";
            car2.EngineNoise = "sputtering";
            car2.HonkNoise = "Murrr";
            car2.IsDriveable = false;
            Console.WriteLine($"You have {CarLot.numberOfCars} cars on your lot.");
            Car car3 = new Car()
            {
                Year = 2010,
                Make = "Audi",
                Model = "R8",
                EngineNoise = "Brroom",
                HonkNoise   = "mip"
            };
            Console.WriteLine($"You have {CarLot.numberOfCars} cars on your lot.");

            car1.MakeEngineNoise(car1.EngineNoise);
            car2.MakeEngineNoise(car2.EngineNoise);
            car3.MakeEngineNoise(car3.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

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
