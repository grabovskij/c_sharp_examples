using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Example_1_classes
{
    public class Car
    {
        public static int count = 0;

        public String color;
        public int weels;

        public Car(String color, int weels)
        {
            count++;
            this.color = color;
            this.weels = weels;
        }

        public String toString()
        {
            return $"Автомоюиль цвета: {color}, число колес:  {weels}";
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car("red", 2));
            cars.Add(new Car("yellow", 3));

            Console.WriteLine($"Спущено машин с конвеера:{Car.count}");

            foreach (var car in cars)
            {
                Console.WriteLine(car.toString());
            }

            Dictionary<String, Car> namedCars = new Dictionary<String, Car>();

            const String olegsCar = "Oleg's car";
            const String vladimirsCar = "Vladimir's car";

            namedCars.Add(olegsCar, new Car("yellow", 3));
            namedCars.Add(vladimirsCar, new Car("red", 1));

            if (namedCars.ContainsKey("olegsCar"))
            {
                Console.WriteLine($"{olegsCar}:{namedCars["olegsCar"].toString()}");
            }


            // car1 = new Car("yellow", 3);
            // car1 = "";
            //
            //
            // if (car1 is Car)
            // {
            //     Console.WriteLine((car1 as Car).toString());
            // }


            // Console.WriteLine(car2.toString());
            // Console.WriteLine($"Спущено машин с конвеера:{Car.count}");

            Console.ReadLine();
        }
    }
}